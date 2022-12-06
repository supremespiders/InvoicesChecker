using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicesChecker.Extensions;
using InvoicesChecker.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace InvoicesChecker.Services;

public class ScanInvoicesService
{
    private string _wintechInvoiceFolder;
    private string _wintechLBInvoiceFolder;
    private string _winsatInvoiceFolder;
    private string _paymentFolder;
    private HashSet<string> _filesOnDb;
    private HashSet<string> _savedPos;
    private Dictionary<string, Payment> _savedPayments;
    readonly MyContext _context = new();
    private decimal _kwDiscount;
    private decimal _lbDiscount;

    public ScanInvoicesService(string wintechInvoiceFolder, string wintechLBInvoiceFolder, string winsatInvoiceFolder, string paymentFolder, decimal kwDiscount, decimal lbDiscount)
    {
        _wintechInvoiceFolder = wintechInvoiceFolder;
        _wintechLBInvoiceFolder = wintechLBInvoiceFolder;
        _winsatInvoiceFolder = winsatInvoiceFolder;
        _paymentFolder = paymentFolder;
        _kwDiscount = kwDiscount;
        _lbDiscount = lbDiscount;
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }


    private List<Payment> ParseFormat1(ExcelWorksheet sheet)
    {
        var payments = new List<Payment>();
        for (int i = 19; i <= sheet.Dimension.End.Row; i++)
        {
            var order = sheet.Cells[i, 3].Value?.ToString();
            if (string.IsNullOrEmpty(order)) break;
            if (order.Contains("/"))
                order = order.Substring(0, order.IndexOf("/", StringComparison.Ordinal));

            if (!DateTime.TryParseExact(sheet.Cells[i, 2].Value?.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                if (!DateTime.TryParseExact(sheet.Cells[i, 2].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    if (!DateTime.TryParse(sheet.Cells[i, 2].Value?.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                        throw new KnownException($"Failed to parse date : {sheet.Cells[i, 2].Value?.ToString()} at line : {i}");
            if (_savedPayments.ContainsKey(order))
            {
                continue;
            }

            var payment = new Payment
            {
                Date = date,
                InvoiceAmount = Math.Abs(decimal.Parse(sheet.Cells[i, 4].Value?.ToString() ?? "0")),
                DiscountUsed = Math.Abs(decimal.Parse(sheet.Cells[i, 5].Value?.ToString() ?? "0")),
                PaymentAmount = Math.Abs(decimal.Parse(sheet.Cells[i, 6].Value?.ToString() ?? "0")),
                InvoiceNumber = order
            };
            _savedPayments.Add(order, payment);
            payments.Add(payment);
        }

        return payments;
    }

    private List<Payment> ParseFormat2(ExcelWorksheet sheet)
    {
        var payments = new List<Payment>();
        for (int i = 19; i <= sheet.Dimension.End.Row; i++)
        {
            var order = sheet.Cells[i, 1].Value?.ToString();
            if (string.IsNullOrEmpty(order)) break;
            var isBis = order.Contains("BIS");

            //we don't take Bis
            if (isBis) continue;
            if (order.Contains("/") && !isBis)
                order = order.Substring(0, order.IndexOf("/", StringComparison.Ordinal));


            if (!DateTime.TryParseExact(sheet.Cells[i, 2].Value?.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                if (!DateTime.TryParseExact(sheet.Cells[i, 2].Value?.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    if (!DateTime.TryParse(sheet.Cells[i, 2].Value?.ToString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                        throw new KnownException($"Failed to parse date : {sheet.Cells[i, 2].Value?.ToString()} at line : {i}");
            if (_savedPayments.ContainsKey(order))
            {
                continue;
            }

            var payment = new Payment
            {
                Date = date,
                InvoiceAmount = Math.Abs(decimal.Parse(sheet.Cells[i, 3].Value?.ToString() ?? "0")),
                DiscountUsed = Math.Abs(decimal.Parse(sheet.Cells[i, 5].Value?.ToString() ?? "0")),
                PaymentAmount = Math.Abs(decimal.Parse(sheet.Cells[i, 7].Value?.ToString() ?? "0")),
                InvoiceNumber = order,
                IsBis = isBis
            };
            _savedPayments.Add(order, payment);
            payments.Add(payment);
        }

        return payments;
    }

    private List<Payment> ScanPaymentFile(string path)
    {
        var package = new ExcelPackage(new FileInfo(path));
        var sheet = package.Workbook.Worksheets.FirstOrDefault();
        if (sheet == null) throw new KnownException($"File {path} don't have sheet");
        var h = sheet.Cells[18, 3].Value?.ToString()?.Trim();
        var isHeader3IsFacture = h == "Invoice";
        return isHeader3IsFacture ? ParseFormat1(sheet) : ParseFormat2(sheet);
    }

    private List<Payment> ScanPayment(string paymentFolder)
    {
        var files = Directory.GetFiles(paymentFolder);
        var newFiles = new List<string>();
        var payments = new List<Payment>();
        foreach (var file in files)
        {
            if (!file.EndsWith(".xlsx")) continue;
            Notifier.Log($"Working on payment file : {Path.GetFileName(file)}");
            try
            {
                var p = ScanPaymentFile(file);
                payments.AddRange(p);
            }
            catch (KnownException ex)
            {
                Notifier.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Notifier.Error(ex.ToString());
            }
        }

        return payments;
    }

    private (string client, int week, int year) ParseFileName(string filePath)
    {
        var name = Path.GetFileName(filePath.Replace(".xml", ""));
        var client = "";
        var week = -1;
        var year = -1;
        if (name.StartsWith("HFG"))
        {
            client = "KW";
            week = int.Parse(name.Substring(3, 3));
            year = int.Parse(name[6..]);
        }
        else if (name.Contains("KW"))
        {
            client = "KW";
            week = int.Parse(name[6..]);
            year = int.Parse(name[..4]);
        }
        else if (name.Contains("LB"))
        {
            client = "LB";
            week = int.Parse(name[6..]);
            year = int.Parse(name[..4]);
        }
        else
        {
            throw new Exception($"new format for file name : {name}");
        }

        return (client, week, year);
    }

    private async Task<InvoiceFile> ScanFile(string path)
    {
        var element = await path.DeserializeXmlToObject<RootElement>();
        var (client, week, year) = ParseFileName(path);
        var invoices = new List<Invoice>();
        var discount = _kwDiscount;
        if (client == "LB")
            discount = _lbDiscount;
        foreach (var factuur in element.FACTUUR)
        {
            var amount = factuur.FACTUURREGELS.FACTUURREGEL.Sum(x => x.NETTOBEDRAG);
            if (amount == 0) continue;
            invoices.Add(new Invoice
            {
                InvoiceDate = DateTime.ParseExact(factuur.FACTUURDATUM, "yyyyMMdd", CultureInfo.InvariantCulture),
                OrderDate = DateTime.ParseExact(factuur.ORDER_DATUM, "yyyyMMdd", CultureInfo.InvariantCulture),
                GlnPartner = factuur.GLN_PARTNER,
                InvoiceNumber = factuur.FACTUURNUMMER,
                PurchaseNumber = factuur.ORDERNR_AFNEMER,
                TotalAmount = amount,
                TotalToPay = Math.Round(amount - (amount * discount / 100), 2)
            });
        }

        var invoiceFile = new InvoiceFile
        {
            Year = year,
            FileNumber = week,
            Client = client,
            FileName = Path.GetFileNameWithoutExtension(path),
            Invoices = invoices,
            TotalAmount = invoices.Sum(x => x.TotalAmount),
            TotalToPay = invoices.Sum(x => x.TotalToPay)
        };
        return invoiceFile;
    }

    private async Task<List<InvoiceFile>> CheckForNewFiles(string folderPath)
    {
        if (!Directory.Exists(folderPath)) throw new KnownException($"Directory : {folderPath} don't exist");
        var invoiceFiles = new List<InvoiceFile>();
        var files = Directory.GetFiles(folderPath);
        var newFiles = new List<string>();
        foreach (var file in files)
        {
            if (!file.EndsWith(".xml")) continue;
            //     var (client, week, year) = ParseFileName(file);
            var name = Path.GetFileNameWithoutExtension(file);
            if (_filesOnDb.Contains(name)) continue;
            newFiles.Add(file);
        }

        Notifier.Log($"Found {newFiles.Count} new files from {files.Length}");
        if (newFiles.Count == 0) return invoiceFiles;
        foreach (var newFile in newFiles)
        {
            try
            {
                var invoiceFile = await ScanFile(newFile);
                invoiceFiles.Add(invoiceFile);
            }
            catch (Exception e)
            {
                Notifier.Error($"Failed to parse file : {newFile} : {e.Message}");
            }
        }

        return invoiceFiles;
    }

    async Task SaveInvoices(List<InvoiceFile> invoiceFiles)
    {
        var invoices = invoiceFiles.Select(x => x.Invoices).ToList();
        var context = new MyContext();
        foreach (var invoiceFile in invoiceFiles)
        {
            invoiceFile.Invoices = null;
            context.InvoiceFiles.Add(invoiceFile);
        }

        await context.SaveChangesAsync();
        for (var i = 0; i < invoiceFiles.Count; i++)
        {
            var invoiceFile = invoiceFiles[i];
            invoiceFile.Invoices = invoices[i];
            foreach (var invoice in invoiceFile.Invoices)
            {
                invoice.InvoiceFileId = invoiceFile.Id;
            }
        }

        await context.BulkInsert(invoiceFiles.SelectMany(x => x.Invoices).ToList());
        Notifier.Log($"{invoiceFiles.Count} new invoice files saved");
    }

    async Task SavePayment(List<Payment> payments)
    {
        if (payments.Count == 0) return;
        //save payments
        var poToPull = payments.Where(x => _savedPos.Contains(x.InvoiceNumber)).Select(x => x.InvoiceNumber).ToList();
        var invoices = await _context.Invoices.AsNoTracking().Where(x => poToPull.Contains(x.InvoiceNumber)).ToListAsync();
        foreach (var invoice in invoices)
        {
            var payment = payments.First(x => x.InvoiceNumber == invoice.InvoiceNumber);
            payment.InvoiceId = invoice.Id;
        }

        await _context.BulkInsert(payments);

        //update invoices with payments

        var insertedPayments = await _context.Payments.AsNoTracking().Where(x => poToPull.Contains(x.InvoiceNumber)).ToListAsync();
        Notifier.Log($"{insertedPayments.Count} payments seams to match invoices we have");
        if (insertedPayments.Count == 0) return;
        var invoiceFilesIds = invoices.Select(x => x.InvoiceFileId).Distinct().ToHashSet();
        var invoiceFiles = await _context.InvoiceFiles.AsNoTracking().Where(x => invoiceFilesIds.Contains(x.Id)).ToListAsync();
        foreach (var invoice in invoices)
        {
            var payment = insertedPayments.First(x => x.InvoiceNumber == invoice.InvoiceNumber);
            if (invoice.TotalPayed != 0)
            {
                Notifier.Error($"Invoice : {invoice.InvoiceNumber} is already have : {invoice.TotalPayed} payed, second payments is not implemented");
                continue;
            }

            var invoiceFile = invoiceFiles.First(x => x.Id == invoice.InvoiceFileId);

            invoiceFile.TotalPayed += payment.PaymentAmount;
            invoiceFile.RestToPay = invoiceFile.TotalToPay - invoiceFile.TotalPayed;
            invoice.TotalPayed = payment.PaymentAmount;
            invoice.RestToPay = invoice.TotalToPay - invoice.TotalPayed;
        }

        await _context.BulkUpdate(invoices, new List<string> { "TotalPayed", "RestToPay" });
        await _context.BulkUpdate(invoiceFiles, new List<string> { "TotalPayed", "RestToPay" });

        //var invoiceFiles = await _context.InvoiceFiles.AsNoTracking().Include(x=>x.Invoices).Where(x => invoiceFilesIds.Contains(x.Id)).ToListAsync();
        //foreach (var invoiceFile in invoiceFiles)
        //{
        //    invoiceFile.TotalPayed=invoiceFile.Invoices.Sum(x=>x.)
        //}


        //foreach (var payment in payments)
        //{
        //    if (_purchaseNumbers.Contains(payment.Order))
        //    {
        //        poToPull.Add(payment.Order);
        //        //var factuur = await context.FACTUUR.FirstAsync(x => x.ORDERNR_AFNEMER.Equals(payment.Order));
        //        //payment.Factuur = factuur;
        //        //factuur.Payed = payment.PaymentAmount;
        //        //factuur.Payment = payment;
        //    }
        //}
    }

    void CheckPaymentsForInvoices(List<InvoiceFile> invoicesFiles)
    {
        foreach (var invoicesFile in invoicesFiles)
        {
            foreach (var invoice in invoicesFile.Invoices)
            {
                if (_savedPayments.ContainsKey(invoice.InvoiceNumber))
                {
                    invoice.PaymentId = _savedPayments[invoice.InvoiceNumber].Id;
                    invoice.TotalPayed = _savedPayments[invoice.InvoiceNumber].PaymentAmount;
                }

                invoice.RestToPay = invoice.TotalToPay - invoice.TotalPayed;
            }

            invoicesFile.TotalPayed = invoicesFile.Invoices.Sum(x => x.TotalPayed);
            invoicesFile.RestToPay = invoicesFile.Invoices.Sum(x => x.RestToPay);
        }
    }

    public async Task<(bool invoiceChanged, bool paymentChanged)> MainWork()
    {
        Notifier.Log($"Start working");

        Notifier.Log("fetching file headers from db");
        // _filesOnDb = (await _context.InvoiceFiles.AsNoTracking().Select(x => new { x.Client, x.Year, x.FileNumber }).ToListAsync()).Select(x => $"{x.Client}{x.Year}{x.FileNumber}").ToHashSet();
        _filesOnDb = (await _context.InvoiceFiles.AsNoTracking().Select(x => x.FileName).ToListAsync()).ToHashSet();
        _savedPayments = (await _context.Payments.AsNoTracking().ToListAsync()).ToDictionary(x => x.InvoiceNumber, x => x);
        Notifier.Log("fetching purchase numbers from db");
        _savedPos = (await _context.Invoices.AsNoTracking().ToListAsync()).Select(x => x.InvoiceNumber).ToHashSet();

        var invoiceFiles = new List<InvoiceFile>();
        Notifier.Log("Checking Wintech KW folder for new invoices");
        invoiceFiles.AddRange(await CheckForNewFiles(_wintechInvoiceFolder));
        Notifier.Log("Checking Wintech LB folder for new invoices");
        invoiceFiles.AddRange(await CheckForNewFiles(_wintechLBInvoiceFolder));
        Notifier.Log("Checking Winsat folder for new invoices");
        invoiceFiles.AddRange(await CheckForNewFiles(_winsatInvoiceFolder));

        CheckDuplicatePurchaseNumbers(invoiceFiles);
        CheckPaymentsForInvoices(invoiceFiles);
        await SaveInvoices(invoiceFiles);

        var payments = ScanPayment(_paymentFolder);
        await SavePayment(payments);
        Notifier.Log($"{payments.Count} new payments saved");


        Notifier.Log($"work complete");
        return (invoiceFiles.Count != 0, payments.Count != 0);
    }

    private void CheckDuplicatePurchaseNumbers(List<InvoiceFile> invoiceFiles)
    {
        var dups = invoiceFiles.SelectMany(x => x.Invoices).GroupBy(x => x.InvoiceNumber).Where(x => x.Count() > 1).ToList();
        var duplicateDisplay = new List<string>();
        foreach (var dup in dups)
        {
            var sb = new StringBuilder($"purchase number {dup.Key} is duplicate in ");
            foreach (var invoice in dup)
            {
                var file = invoiceFiles.FirstOrDefault(x => x.Invoices.Contains(invoice));
                sb.Append($"{invoice.InvoiceNumber} : {file.FileName}, ");
            }

            duplicateDisplay.Add(sb.ToString());
        }

        if (duplicateDisplay.Count > 0)
            throw new KnownException($"Duplicate purchasing number found : \n{string.Join("\n", duplicateDisplay)}");

        foreach (var invoiceFile in invoiceFiles)
        {
            foreach (var invoice in invoiceFile.Invoices)
            {
                if (_savedPos.Contains(invoice.InvoiceNumber))
                    throw new KnownException($"Purchase number : {invoice.InvoiceNumber} in file : {invoiceFile.FileName} exist!!");
                _savedPos.Add(invoice.InvoiceNumber);
            }
        }
    }
}
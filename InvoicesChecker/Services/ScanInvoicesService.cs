using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    private string _winsatInvoiceFolder;
    private string _paymentFolder;
    private HashSet<string> _filesOnDb;
    private HashSet<string> _purchaseNumbers;
    private HashSet<string> _savedPayments;
    public ScanInvoicesService(string wintechInvoiceFolder, string winsatInvoiceFolder, string paymentFolder)
    {
        _wintechInvoiceFolder = wintechInvoiceFolder;
        _winsatInvoiceFolder = winsatInvoiceFolder;
        _paymentFolder = paymentFolder;
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    }

    private List<Payment> ScanPaymentFile(string path)
    {
        var package = new ExcelPackage(new FileInfo(path));
        var sheet = package.Workbook.Worksheets.FirstOrDefault();
        if (sheet == null) throw new KnownException($"File {path} don't have sheet");
        var payments = new List<Payment>();
        for (int i = 19; i <= sheet.Dimension.End.Row; i++)
        {
            var invoice = sheet.Cells[i, 3].Value?.ToString()?.Split("/");
            if (invoice == null) break;
            var client = "";
            var week = 0;
            var year = 0;
            if (invoice.Length != 4)
            {
                Debug.WriteLine($"Unknown format : {sheet.Cells[i, 3].Value?.ToString()}");
                continue;
            }
            if (char.IsDigit(invoice[0][0]))
            {
                client = invoice[1];
                if (!int.TryParse(invoice[2], out week)) throw new KnownException($"Unexpected format at line : {i} on payment file week(2) : {sheet.Cells[i, 3].Value?.ToString()}");
                if (!int.TryParse(invoice[0], out year)) throw new KnownException($"Unexpected format at line : {i} on payment file year(0) : {sheet.Cells[i, 3].Value?.ToString()}");
            }
            else
            {
                client = invoice[0];
                if (!int.TryParse(invoice[1], out week)) throw new KnownException($"Unexpected format at line : {i} on payment file week(1) : {sheet.Cells[i, 3].Value?.ToString()}");
                if (!int.TryParse(invoice[2], out year)) throw new KnownException($"Unexpected format at line : {i} on payment file year(2) : {sheet.Cells[i, 3].Value?.ToString()}");
            }

            var order = invoice[3];


            if (!DateTime.TryParse(sheet.Cells[i, 2].Value?.ToString(), out var date)) throw new KnownException($"Failed to parse date : {sheet.Cells[i, 2].Value?.ToString()} at line : {i}");
            if (_savedPayments.Contains(order))
            {
               // Notifier.Error($"Duplicate purchase number : {order} on payment file");
                continue;
            }

            _savedPayments.Add(order);
            payments.Add(new Payment
            {
                Date = date,
                InvoiceAmount = decimal.Parse(sheet.Cells[i, 4].Value?.ToString() ?? "0"),
                DiscountUsed = decimal.Parse(sheet.Cells[i, 5].Value?.ToString() ?? "0"),
                PaymentAmount = decimal.Parse(sheet.Cells[i, 6].Value?.ToString() ?? "0"),
                Client = client,
                Week = week,
                Year = year,
                Order = order
            });
        }

        return payments;
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

        return (client, week, year);
    }

    private InvoiceFile ScanFile(string path)
    {
        var invoiceFile = path.DeserializeXmlToObject<InvoiceFile>();
        var (client, week, year) = ParseFileName(path);
        invoiceFile.Client = client;
        invoiceFile.Week = week;
        invoiceFile.Year = year;
        invoiceFile.RawXml = File.ReadAllText(path);
        foreach (var factuur in invoiceFile.FACTUUR)
        {
            factuur.Total = factuur.FACTUURREGELS.FACTUURREGEL.Sum(x => x.NETTOBEDRAG);
        }
        return invoiceFile;
    }

    private List<InvoiceFile> CheckForNewFiles(string folderPath)
    {
        if (!Directory.Exists(folderPath)) throw new KnownException($"Directory : {folderPath} don't exist");
        var invoiceFiles = new List<InvoiceFile>();
        var files = Directory.GetFiles(folderPath);
        var newFiles = new List<string>();
        foreach (var file in files)
        {
            if (!file.EndsWith(".xml")) continue;
            var (client, week, year) = ParseFileName(file);
            if (_filesOnDb.Contains($"{client}{year}{week}")) continue;
            newFiles.Add(file);
        }
        Notifier.Log($"Found {newFiles.Count} new files");
        if (newFiles.Count == 0) return invoiceFiles;
        foreach (var newFile in newFiles)
        {
            try
            {
                var invoiceFile = ScanFile(newFile);
                invoiceFiles.Add(invoiceFile);
            }
            catch (Exception e)
            {
                Notifier.Error($"Failed to parse file : {newFile} : {e.Message}");
            }
        }

        return invoiceFiles;
    }

    public async Task MainWork()
    {
        Notifier.Log($"Start working");
        var context = new MyContext();
        Notifier.Log("fetching file headers from db");
        _filesOnDb = (await context.InvoiceFiles.AsNoTracking().Select(x => new { x.Client, x.Year, x.Week }).ToListAsync()).Select(x => $"{x.Client}{x.Year}{x.Week}").ToHashSet();
        _savedPayments = (await context.Payments.AsNoTracking().Select(x => x.Order).ToListAsync()).ToHashSet();
        Notifier.Log("fetching purchase numbers from db");
        _purchaseNumbers = (await context.FACTUUR.AsNoTracking().ToListAsync()).Select(x => x.ORDERNR_AFNEMER).ToHashSet();
        var invoiceFiles = new List<InvoiceFile>();
        Notifier.Log("Checking Wintech folder for new invoices");
        invoiceFiles.AddRange(CheckForNewFiles(_wintechInvoiceFolder));
        Notifier.Log("Checking Winsat folder for new invoices");
        invoiceFiles.AddRange(CheckForNewFiles(_winsatInvoiceFolder));
        var dups = invoiceFiles.SelectMany(x => x.FACTUUR).GroupBy(x => x.ORDERNR_AFNEMER).Where(x => x.Count() > 1).ToList();
        var duplicateDisplay = new List<string>();
        foreach (var dup in dups)
        {
            var sb = new StringBuilder($"purchase number {dup.Key} is duplicate in ");
            foreach (var factuur in dup)
            {
                var file = invoiceFiles.FirstOrDefault(x => x.FACTUUR.Contains(factuur));
                sb.Append($"{factuur.FACTUURNUMMER} : {file?.Client}-{file?.Year}-{file?.Week}, ");
            }
            duplicateDisplay.Add(sb.ToString());
        }
        if (duplicateDisplay.Count > 0)
            throw new KnownException($"Duplicate purchasing number found : \n{string.Join("\n", duplicateDisplay)}");
        foreach (var invoiceFile in invoiceFiles)
        {
            foreach (var factuur in invoiceFile.FACTUUR)
            {
                if (_purchaseNumbers.Contains(factuur.ORDERNR_AFNEMER))
                    throw new KnownException($"Purchase number : {factuur.ORDERNR_AFNEMER} in file : {invoiceFile.Client}{invoiceFile.Year}{invoiceFile.Week} exist!!");
                _purchaseNumbers.Add(factuur.ORDERNR_AFNEMER);
            }
        }
        await context.InvoiceFiles.AddRangeAsync(invoiceFiles);
        await context.SaveChangesAsync();
        Notifier.Log($"{invoiceFiles.Count} new invoice files saved");
        //await ScanFile("2022LB0001.xml");
        var payments = ScanPayment(_paymentFolder);

        foreach (var payment in payments)
        {
            if (_purchaseNumbers.Contains(payment.Order))
            {
                var factuur = await context.FACTUUR.FirstAsync(x => x.ORDERNR_AFNEMER.Equals(payment.Order));
                payment.Factuur = factuur;
                factuur.Payed = payment.PaymentAmount;
                factuur.Payment = payment;
            }
        }

        await context.Payments.AddRangeAsync(payments);
        await context.SaveChangesAsync();
        Notifier.Log($"{payments.Count} new payments saved");
    }
}
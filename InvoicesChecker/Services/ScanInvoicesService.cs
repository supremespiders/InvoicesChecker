using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using InvoicesChecker.Extensions;
using InvoicesChecker.Models;
using OfficeOpenXml;

namespace InvoicesChecker.Services;

public class ScanInvoicesService
{
    public ScanInvoicesService()
    {
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
    }

    private async Task ScanPayment()
    {
        var path = "";
        var package = new ExcelPackage(new FileInfo("paymentnotification_09459744-b9ba-4735-939d-8c247ed9ac70.xlsx"));
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
                Debug.WriteLine($"Unknown format : {invoice}");
                continue;
            }
            if (char.IsDigit(invoice[0][0]))
            {
                client = invoice[1];
                week = int.Parse(invoice[2]);
                year = int.Parse(invoice[0]);
            }
            else
            {
                client = invoice[0];
                week = int.Parse(invoice[1]);
                year = int.Parse(invoice[2]);
            }

            var order = invoice[3];
            payments.Add(new Payment
            {
                Date = DateTime.Parse(sheet.Cells[i, 2].Value.ToString()),
                InvoiceAmount = decimal.Parse(sheet.Cells[i, 4].Value?.ToString() ?? "0"),
                DiscountUsed = decimal.Parse(sheet.Cells[i, 5].Value?.ToString() ?? "0"),
                PaymentAmount = decimal.Parse(sheet.Cells[i, 6].Value?.ToString() ?? "0"),
                Client = client,
                Week = week,
                Year = year,
                Order = order
            });
        }

        var context = new MyContext();
        await context.Payments.AddRangeAsync(payments);
        await context.SaveChangesAsync();
    }

    private async Task ScanFile(string path)
    {
        var invoiceFile = path.DeserializeXmlToObject<InvoiceFile>();
        var name = path.Replace(".xml", "");
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

        invoiceFile.Client = client;
        invoiceFile.Week = week;
        invoiceFile.Year = year;
        var context = new MyContext();
        context.InvoiceFiles.Add(invoiceFile);
        await context.SaveChangesAsync();
    }

    public async Task MainWork()
    {
        //await ScanFile("2022LB0001.xml");
        await ScanPayment();
    }
}
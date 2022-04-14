using System;

namespace InvoicesChecker.Models;

public class InvoiceAdapter
{
    public string Client { get; set; }
    public int Year { get; set; }
    public int FileNumber { get; set; }

    public string InvoiceNumber { get; set; }
    public string PurchaseNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string OrderDate { get; set; }
    public string GlnPartner { get; set; }
    public decimal Total { get; set; }
    public decimal Payment { get; set; }
    public decimal RestToPay { get; set; }

}
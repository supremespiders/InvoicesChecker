using System;

namespace InvoicesChecker.Models;

public class InvoiceOutput
{
    public string Client { get; set; }
    public string InvoiceFile { get; set; }
    public int Year { get; set; }
    public int FileNumber { get; set; }
    public string InvoiceNumber { get; set; }
    public string PurchaseNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime OrderDate { get; set; }
    public string GlnPartner { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalToPay { get; set; }
    public decimal TotalPayed { get; set; }
    public decimal RestToPay { get; set; }
}
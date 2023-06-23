using System;

namespace InvoicesChecker.Models;

public class Invoice
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; }
    public string PurchaseNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime OrderDate { get; set; }
    public string GlnPartner { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalToPay { get; set; }
    public decimal TotalPayed { get; set; }
    public decimal RestToPay { get; set; }
    public int? PaymentId { get; set; }
    public Payment Payment { get; set; }
    public int InvoiceFileId { get; set; }
    public InvoiceFile InvoiceFile { get; set; }

    public decimal Ecart => RestToPay / TotalToPay;

}
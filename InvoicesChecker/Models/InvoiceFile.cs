using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Models;

public class InvoiceFile
{
    public int Id { get; set; }
    public string Client { get; set; }
    public int Year { get; set; }
    public int FileNumber { get; set; }
    public string FileName { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalToPay { get; set; }
    public decimal TotalPayed { get; set; }
    public decimal RestToPay { get; set; }
    public List<Invoice> Invoices { get; set; }
    public decimal Ecart => RestToPay / TotalToPay;
}
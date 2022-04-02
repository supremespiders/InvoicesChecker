using System;

namespace InvoicesChecker.Models;

public class Payment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Client { get; set; }
    public int Year { get; set; }
    public int Week { get; set; }
    public decimal InvoiceAmount { get; set; }
    public decimal DiscountUsed { get; set; }
    public decimal PaymentAmount { get; set; }
    public string Order { get; set; }
}
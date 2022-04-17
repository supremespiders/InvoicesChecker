using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Models;

[Index(nameof(InvoiceNumber), IsUnique = true)]
public class Payment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Client { get; set; }
    //public int Year { get; set; }
    //public int Week { get; set; }
    public decimal InvoiceAmount { get; set; }
    public decimal DiscountUsed { get; set; }
    public decimal PaymentAmount { get; set; }
    [Column(TypeName = "varchar(20)")]
    public string InvoiceNumber { get; set; }

    public int? InvoiceId { get; set; }
    public Invoice Invoice { get; set; }
}
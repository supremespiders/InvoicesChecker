using InvoicesChecker.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Services;

public class MyContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G1IQ31I;Initial Catalog=InvoiceDb;Integrated Security=True;");
    }

    public DbSet<InvoiceFile> InvoiceFiles { get; set; }
    public DbSet<Payment> Payments { get; set; }
}
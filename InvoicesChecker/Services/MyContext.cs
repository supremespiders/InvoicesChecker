using InvoicesChecker.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Services;

public class MyContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G1IQ31I;Initial Catalog=InvoiceDb;Integrated Security=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Payment>().HasOne(t => t.Factuur)
            .WithOne(t => t.Payment)
            .HasForeignKey<FACTUUR>(t => t.PaymentId);

        modelBuilder.Entity<FACTUUR>().HasOne(t => t.Payment)
            .WithOne(t => t.Factuur)
            .HasForeignKey<Payment>(t => t.FactuurId);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<InvoiceFile> InvoiceFiles { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<FACTUUR> FACTUUR { get; set; }
    public DbSet<Log> Logs { get; set; }
}
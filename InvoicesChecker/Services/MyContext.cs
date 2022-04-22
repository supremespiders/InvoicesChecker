using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using InvoicesChecker.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Services;

public class MyContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (File.Exists(GlobalData.ConnectionStringPath))
            GlobalData.ConnectionString = File.ReadAllText(GlobalData.ConnectionStringPath);
        //if (string.IsNullOrEmpty(GlobalData.ConnectionString))
        //{
        //    var config = JsonSerializer.Deserialize<Config>(File.ReadAllText($"{Application.StartupPath}/config"));
        //    GlobalData.ConnectionString = config.ConnectionString;
        //}
        optionsBuilder.UseSqlServer(GlobalData.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Payment>().HasOne(t => t.Invoice)
            .WithOne(t => t.Payment)
            .HasForeignKey<Invoice>(t => t.PaymentId);

        modelBuilder.Entity<Invoice>().HasOne(t => t.Payment)
            .WithOne(t => t.Invoice)
            .HasForeignKey<Payment>(t => t.InvoiceId);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<InvoiceFile> InvoiceFiles { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Log> Logs { get; set; }
}
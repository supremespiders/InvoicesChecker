namespace InvoicesChecker.Models;

public class Config
{
    public string WintechInvoiceFolder { get; set; }
    public string WintechLBInvoiceFolder { get; set; }
    public string WinsatInvoiceFolder { get; set; }
    public string PaymentFolder { get; set; }
    public string ConnectionString { get; set; }
    public decimal KwDiscount { get; set; }
    public decimal lbDiscount { get; set; }


}
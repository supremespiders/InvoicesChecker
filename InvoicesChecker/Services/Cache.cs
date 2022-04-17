using System.Collections.Generic;
using InvoicesChecker.Models;

namespace InvoicesChecker.Services;

public static class Cache
{
    public static List<InvoiceFile> InvoiceFiles{ get; set; }
}
using System;

namespace InvoicesChecker.Models;

public class Log
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public Severity Severity { get; set; }
    public string Text { get; set; }
}

public enum Severity
{
    Info,
    Warning,
    Error,
}
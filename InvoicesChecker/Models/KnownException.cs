using System;

namespace InvoicesChecker.Models;

public class KnownException : Exception
{
    public KnownException(string s) : base(s)
    {

    }
}
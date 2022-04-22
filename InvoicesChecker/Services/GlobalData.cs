using System.IO;

namespace InvoicesChecker.Services;

public static class GlobalData
{
    public static string ConnectionString;
    public static string Path = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
    public static string ConnectionStringPath=Path+"\\connection";
}
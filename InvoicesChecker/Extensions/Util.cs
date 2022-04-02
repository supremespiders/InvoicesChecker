using System.IO;

namespace InvoicesChecker.Extensions;

public static class Util
{
    public static T DeserializeXmlToObject<T>(this string filepath) where T : class
    {
        var ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

        using var sr = new StreamReader(filepath);
        return (T)ser.Deserialize(sr);
    }
}
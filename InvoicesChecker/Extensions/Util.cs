using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraSplashScreen;
using MessageBox = System.Windows.MessageBox;

namespace InvoicesChecker.Extensions;

public static class Util
{
    public static string Location(this Exception ex)
    {
        var st = new StackTrace(ex, true);
        var frame = st.GetFrames().FirstOrDefault(x => x.GetFileLineNumber() != 0);
        if (frame == null) return "NA";
        return $"({Path.GetFileName(frame.GetFileName())} : {frame.GetFileLineNumber()})";
    }
    public static async Task<T> DeserializeXmlToObject<T>(this string filepath) where T : class
    {
        var ser = new System.Xml.Serialization.XmlSerializer(typeof(T));
        //using var sr = new StreamReader(filepath);
        var xml = await File.ReadAllTextAsync(filepath);
        if (xml.StartsWith("ï»¿"))
            xml = xml[3..];
        using var reader = new StringReader(xml);
        return (T)ser.Deserialize(reader);
    }

    public static void SerializeToXml<T>(this T o, string path) where T : class
    {
        var ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

        using var sr = new StreamWriter(path);
        ser.Serialize(sr, o);
    }

    public static async Task Exec(this Form mainForm, Func<Task> action, bool showDetails = true)
    {
        var handle = SplashScreenManager.ShowOverlayForm(((MainForm)mainForm).client, new OverlayWindowOptions
        {
            SkinName = SkinManager.Default.Skins[2].SkinName,
            FadeIn = true,
            FadeOut = true,
        });
        try
        {
            //await Task.Run(action);
            await action();
        }
        catch (Exception e)
        {
            //MessageBox.Show(showDetails ? e.ToString() : e.Message);
            MessageBox.Show($"{e.Message} {e.Location()}");
        }
        finally
        {
            handle.Close();
        }
    }
}
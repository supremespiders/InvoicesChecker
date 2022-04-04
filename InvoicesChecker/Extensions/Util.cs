using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraSplashScreen;
using MessageBox = System.Windows.MessageBox;

namespace InvoicesChecker.Extensions;

public static class Util
{
    public static T DeserializeXmlToObject<T>(this string filepath) where T : class
    {
        var ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

        using var sr = new StreamReader(filepath);
        return (T)ser.Deserialize(sr);
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
            MessageBox.Show(showDetails ? e.ToString() : e.Message);
        }
        finally
        {
            handle.Close();
        }
    }
}
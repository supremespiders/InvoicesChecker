using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace InvoicesChecker.Services;

public class DropboxClient
{
    private readonly HttpClient _httpClient;
    //public EventHandler<ProgressReportModel> OnProgress;
    public EventHandler<(int, int)> OnTotalProgress;
    public EventHandler<string> OnLog;
    private readonly HttpClientHandler _httpClientHandler = new HttpClientHandler()
    {
        AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
    };
    public DropboxClient()
    {
        _httpClient = new HttpClient(_httpClientHandler) { Timeout = TimeSpan.FromSeconds(30) };
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "x3WVejS8EyIAAAAAAAAJ_gkqMXx4SZBQW7OxFyM0ls2xeEgx0cOBskYasL70kTAQ");
        //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "ixBmiBMKxjAAAAAAAAAYsA5_6wXh7O58qyvF0_9j6u1fbJ1logh16ayXiNZmdQ73");
        //_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "z29syscwqsk2uo15kd5oy1uyhisbsdx3WVejS8EyIAAAAAAAAJ_gkqMXx4SZBQW7OxFyM0ls2xeEgx0cOBskYasL70kTAQ");
    }

    private void Log(string s)
    {
        OnLog?.Invoke(this, s);
    }

    public async Task<int> IsThereAnUpdate(string remotePath = "", string localPath = "")
    {
        var response = await _httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/list_folder"),
            Content = new StringContent("{\"path\": \"" + remotePath + "\",\"recursive\": true,\"include_media_info\": true,\"include_deleted\": false,\"include_has_explicit_shared_members\": false,\"include_mounted_folders\": true,\"include_non_downloadable_files\": true,\"limit\":2000}", Encoding.UTF8, "application/json")
        });
        int total = 0;
        int totalDllAndExe = 0;
        var json = await response.Content.ReadAsStringAsync();
        response.EnsureSuccessStatusCode();
        var obj = JObject.Parse(json);
        var entries = (JArray)obj.SelectToken("entries");
        var list = new List<string>();
        foreach (var entry in entries)
        {
            var tag = (string)entry.SelectToken("['.tag']");
            var name = (string)entry.SelectToken("name");
            var pathDisplay = (string)entry.SelectToken("path_display");
            var contentHash = (string)entry.SelectToken("content_hash");
            var restPath = pathDisplay.Replace(remotePath, "");
            if (restPath.Equals("")) continue;
            if (tag.Equals("file"))
            {
                if (restPath.LastIndexOf("/", StringComparison.Ordinal) != 0)
                {
                    var d = localPath + Path.GetDirectoryName(restPath);
                    if (!Directory.Exists(d))
                    {

                    }
                }
                var l = localPath + restPath;
                if (!File.Exists(l))
                {
                    total++;
                    if (l.EndsWith(".dll") || l.EndsWith(".exe"))
                    {
                        totalDllAndExe++;
                    }
                }
                else
                {
                    var hash = CalculateHash(l);
                    if (!contentHash.Equals(hash))
                    {
                        total++;
                        if (l.EndsWith(".dll") || l.EndsWith(".exe"))
                        {
                            totalDllAndExe++;
                        }
                    }
                }
            }
            if (tag.Equals("folder"))
            {
                var d = localPath + restPath;
                if (!Directory.Exists(d))
                {

                }
            }
        }

        return totalDllAndExe > 0 ? total : 0;
    }

    private void SetProgress(int nbr, int total)
    {
        OnTotalProgress?.Invoke(this, (nbr, total));
    }
    public async Task Sync(int total, string remotePath = "", string localPath = "")
    {
        var exe = Process.GetCurrentProcess().ProcessName;
        Log("Start sync");
        var response = await _httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/list_folder"),
            Content = new StringContent("{\"path\": \"" + remotePath + "\",\"recursive\": true,\"include_media_info\": true,\"include_deleted\": false,\"include_has_explicit_shared_members\": false,\"include_mounted_folders\": true,\"include_non_downloadable_files\": true,\"limit\":2000}", Encoding.UTF8, "application/json")
        });
        var json = await response.Content.ReadAsStringAsync();
        response.EnsureSuccessStatusCode();
        var obj = JObject.Parse(json);
        var entries = (JArray)obj.SelectToken("entries");
        var list = new List<string>();
        int nbr = 0;
        foreach (var entry in entries)
        {
            var tag = (string)entry.SelectToken("['.tag']");
            var name = (string)entry.SelectToken("name");
            var pathDisplay = (string)entry.SelectToken("path_display");
            var contentHash = (string)entry.SelectToken("content_hash");
            var restPath = pathDisplay.Replace(remotePath, "");
            if (restPath.Equals("")) continue;
            if (tag.Equals("file"))
            {
                if (restPath.LastIndexOf("/", StringComparison.Ordinal) != 0)
                {
                    var d = localPath + Path.GetDirectoryName(restPath);
                    if (!Directory.Exists(d))
                        Directory.CreateDirectory(d);
                }
                var l = localPath + restPath;
                if (!File.Exists(l))
                {
                    nbr++;
                    SetProgress(nbr, total);
                    await DownloadFile(pathDisplay, l);
                }
                else
                {
                    var hash = CalculateHash(l);
                    if (!contentHash.Equals(hash))
                    {
                        Console.WriteLine(@"the file are not the same");
                        if (name.StartsWith(exe) || name.Contains("DataAccess.dll"))
                        {
                            if (File.Exists(l + ".bc"))
                                File.Delete(l + ".bc");
                            File.Move(l, l + ".bc");
                        }
                        nbr++;
                        SetProgress(nbr, total);
                        await DownloadFile(pathDisplay, l);
                    }
                }
            }
            if (tag.Equals("folder"))
            {
                var d = localPath + restPath;
                if (!Directory.Exists(d))
                    Directory.CreateDirectory(d);
            }
        }
        Log("Completed the sync");
    }

    private static string CalculateHash(string filename)
    {
        var hasher = new DropboxContentHasher();
        var buf = new byte[1024];
        using (var file = File.OpenRead(filename))
        {
            while (true)
            {
                var n = file.Read(buf, 0, buf.Length);
                if (n <= 0) break;   // EOF
                hasher.TransformBlock(buf, 0, n, buf, 0);
            }
        }

        hasher.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
        var hexHash = DropboxContentHasher.ToHex(hasher.Hash);
        return hexHash;
    }
    public async Task<List<string>> GetEntries(string remotePath = "")
    {
        var response = await _httpClient.SendAsync(new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.dropboxapi.com/2/files/list_folder"),
            Content = new StringContent("{\"path\": \"" + remotePath + "\",\"recursive\": false,\"include_media_info\": false,\"include_deleted\": false,\"include_has_explicit_shared_members\": false,\"include_mounted_folders\": true,\"include_non_downloadable_files\": true,\"limit\":2000}", Encoding.UTF8, "application/json")
        });
        var json = await response.Content.ReadAsStringAsync();
        response.EnsureSuccessStatusCode();
        var obj = JObject.Parse(json);
        var entries = (JArray)obj.SelectToken("entries");
        var list = new List<string>();
        foreach (var entry in entries)
        {
            var tag = (string)entry.SelectToken("['.tag']");
            var name = (string)entry.SelectToken("name");
            if (!tag.Equals("folder") && remotePath.Equals("/Totsee Videos")) continue;
            if (!tag.Equals("file") && !remotePath.Equals("/Totsee Videos")) continue;
            if (name.Equals("Completed")) continue;
            list.Add(name);
        }

        return list;
    }

    public async Task DownloadFile(string remotePath, string localPath)
    {
        var response = await _httpClient.SendAsync(new HttpRequestMessage
        {
            RequestUri = new Uri("https://content.dropboxapi.com/2/files/download"),
            Method = HttpMethod.Post,
            Headers = { { "Dropbox-API-Arg", "{ \"path\": \"" + remotePath + "\"}" } }
        }, HttpCompletionOption.ResponseHeadersRead);
        response.EnsureSuccessStatusCode();
        var contentLength = response.Content.Headers.ContentLength;

        var contentStream = await response.Content.ReadAsStreamAsync();
        await ProcessContentStream(contentLength, contentStream, localPath);
    }

    private async Task ProcessContentStream(long? totalDownloadSize, Stream contentStream, string fileName)
    {
        var totalBytesRead = 0L;
        var readCount = 0L;
        var buffer = new byte[8192];
        var isMoreToRead = true;

        using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
        {
            do
            {
                var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    isMoreToRead = false;
                    TriggerProgressChanged(totalDownloadSize, totalBytesRead, fileName);
                    continue;
                }

                await fileStream.WriteAsync(buffer, 0, bytesRead);

                totalBytesRead += bytesRead;
                readCount += 1;

                if (readCount % 100 == 0)
                    TriggerProgressChanged(totalDownloadSize, totalBytesRead, fileName);
            }
            while (isMoreToRead);
        }
    }

    private void TriggerProgressChanged(long? totalDownloadSize, long totalBytesRead, string fileName)
    {
        //    if (OnProgress == null)
        //        return;

        //    double? progressPercentage = null;
        //    if (totalDownloadSize.HasValue)
        //        progressPercentage = Math.Round((double)totalBytesRead / totalDownloadSize.Value * 100, 2);

        //    OnProgress?.Invoke(this, new ProgressReportModel() { FileName = Path.GetFileName(fileName), ProgressPercent = progressPercentage, BytesDownloaded = totalBytesRead, TotalFileSize = totalDownloadSize });
    }
}
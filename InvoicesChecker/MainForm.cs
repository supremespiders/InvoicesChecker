using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using InvoicesChecker.Extensions;
using InvoicesChecker.Models;
using InvoicesChecker.Services;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MdiClient client;
        public MainForm()
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, SkinSvgPalette.Bezier.OfficeColorful);
            UserLookAndFeel.Default.SetStyle(LookAndFeelStyle.Skin, false, false);
            InitializeComponent();
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Notifier.OnDisplay += OnDisplay;
            Notifier.OnLog += OnLog;
            Notifier.OnError += OnError;
            Notifier.OnProgress += OnProgress;
            client = this.Controls.OfType<MdiClient>().FirstOrDefault();

            if (!File.Exists("config")) return;
            var config = JsonSerializer.Deserialize<Config>(await File.ReadAllTextAsync("config"));
            wintechInvoiceFolderI.Text = config?.WintechInvoiceFolder;
            winsatInvoiceFolderI.Text = config?.WinsatInvoiceFolder;
            paymentsFolderI.Text = config?.PaymentFolder;
            if (!File.Exists("connection"))
            {
                await File.WriteAllTextAsync("connection", "Server=DESKTOP-G1IQ31I;Database=InvoiceDb;User Id=invoice;Password=qw182sdfRt7$;");
                MessageBox.Show("Please enter a connection string");
                return;
            }
            GlobalData.ConnectionString = await File.ReadAllTextAsync("connection");
            if (string.IsNullOrEmpty(GlobalData.ConnectionString))
                return;

            InvoiceDateEdit.EditValue = DateTime.Now;
            paymentDateI.EditValue = DateTime.Now;

            _ = Task.Run(CheckForUpdates);
            //await this.Exec(async () =>
            //{
            //    await LoadInvoices();
            //    await LoadPayments();
            //});

            await this.Exec(async () =>
            {
                await LoadInvoiceFiles();
                await LoadPayments();
            });
        }

        async Task CheckForUpdates()
        {
            if (!File.Exists("app")) return;
            if (!File.Exists("Updater.exe")) return;
            var appName = await File.ReadAllTextAsync("app");
            if (!Debugger.IsAttached)
            {

                var p = Application.StartupPath + "";
                Directory.CreateDirectory(p);
                var updaterPath = $"/{appName}/Application Files/{appName}_1_0_0_0";
                var remotePath = updaterPath;
                var dropboxClient = new DropboxClient();
                Invoke((MethodInvoker)async delegate
                {
                    try
                    {
                        var updates = await dropboxClient.IsThereAnUpdate(remotePath, p);
                        if (updates == 0) return;
                        if (File.Exists(Application.StartupPath + "/Updater.exe"))
                        {
                            Hide();
                            Process.Start("Updater.exe");
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                });
            }
        }

        private void OnProgress(object sender, (int x, int total) e)
        {
            SetProgress(e.x * 100 / e.total);
        }

        private void OnError(object sender, string e)
        {
            ErrorLog(e);

        }

        private void OnLog(object sender, string e)
        {
            NormalLog(e);
        }

        private void OnDisplay(object sender, string e)
        {
            Display(e);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), @"Unhandled Thread Exception");
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception)?.ToString(), @"Unhandled UI Exception");
        }

        #region UIFunctions
        private string _simpleDateFormat = "dd/MM/yyyy HH:mm:ss";
        public delegate void WriteToLogD(string s, Color c);
        public void WriteToLog(string s, Color c)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new WriteToLogD(WriteToLog), s, c);
                    return;
                }
                if (debugT.Lines.Length > 5000)
                {
                    debugT.Text = "";
                }
                debugT.SelectionStart = debugT.Text.Length;
                debugT.SelectionColor = c;
                debugT.AppendText(DateTime.Now.ToString(_simpleDateFormat) + " : " + s + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void NormalLog(string s)
        {
            WriteToLog(s, Color.Black);
        }
        public void ErrorLog(string s)
        {
            WriteToLog(s, Color.Red);
        }
        public void SuccessLog(string s)
        {
            WriteToLog(s, Color.Green);
        }
        public void CommandLog(string s)
        {
            WriteToLog(s, Color.Blue);
        }

        public delegate void SetProgressD(int x);
        public void SetProgress(int x)
        {
            if (InvokeRequired)
            {
                Invoke(new SetProgressD(SetProgress), x);
                return;
            }
            if ((x <= 100))
            {
                //progressBar.Value1 = x;
            }
        }
        public delegate void DisplayD(string s);
        public void Display(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new DisplayD(Display), s);
                return;
            }
            //displayT.Text = s;
        }

        #endregion


        private async Task SaveConfig()
        {
            var config = new Config
            {
                WintechInvoiceFolder = wintechInvoiceFolderI.Text,
                WinsatInvoiceFolder = winsatInvoiceFolderI.Text,
                PaymentFolder = paymentsFolderI.Text,
            };
            try
            {
                await File.WriteAllTextAsync("config", JsonSerializer.Serialize(config));
                GlobalData.ConnectionString = config.ConnectionString;
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Failed to save config : {e.Message}");
            }
        }


        private async Task LoadInvoices()
        {
            var d = InvoiceDateEdit.DateTime;
            var context = new MyContext();
            // var invoices = await context.InvoiceFiles.AsNoTracking().Include(x => x.FACTUUR).Select(x => new { x.Client, x.Year, x.Week, x.FACTUUR }).ToListAsync();
            var invoiceFiles = (await context.InvoiceFiles.AsNoTracking().ToListAsync()).ToDictionary(x => x.Id);
            var invoices = await context.Invoices.AsNoTracking().Where(x => x.InvoiceDate.Year == d.Year && x.InvoiceDate.Month == d.Month).ToListAsync();
            foreach (var invoice in invoices)
            {
                invoice.InvoiceFile = new InvoiceFile
                {
                    Client = invoiceFiles[invoice.InvoiceFileId].Client,
                    Year = invoiceFiles[invoice.InvoiceFileId].Year,
                    FileNumber = invoiceFiles[invoice.InvoiceFileId].FileNumber
                };
            }

            var invoiceAdapters = new List<InvoiceAdapter>();
            foreach (var invoice in invoices)
            {
                invoiceAdapters.Add(new InvoiceAdapter()
                {
                    Client = invoice.InvoiceFile.Client,
                    FileNumber = invoice.InvoiceFile.FileNumber,
                    Year = invoice.InvoiceFile.Year,
                    GlnPartner = invoice.GlnPartner,
                    InvoiceDate = invoice.InvoiceDate,
                    OrderDate = invoice.OrderDate,
                    PurchaseNumber = invoice.PurchaseNumber,
                    InvoiceNumber = invoice.InvoiceNumber,
                    Total = invoice.TotalToPay,
                    Payment = invoice.TotalPayed,
                    RestToPay = invoice.TotalToPay - invoice.TotalPayed
                });
            }

            InvoicesGrid.DataSource = invoiceAdapters;
        }


        private async Task LoadInvoiceFiles()
        {
            //var d = InvoiceDateEdit.DateTime;
            var context = new MyContext();
            var invoiceFiles = (await context.InvoiceFiles.AsNoTracking().Include(x => x.Invoices).ToListAsync());

            invoiceFileGrid.DataSource = invoiceFiles;
        }

        private async Task LoadPayments()
        {
            var d = paymentDateI.DateTime;
            var context = new MyContext();
            // var payments = await context.Payments.AsNoTracking().Where(x => x.InvoiceId == null && x.Date.Year == d.Year && x.Date.Month == d.Month).ToListAsync();
            var payments = await context.Payments.AsNoTracking().Where(x => x.InvoiceId == null).ToListAsync();
            paymentsGrid.DataSource = payments;
        }


        private async void SearchInvoicesButton_Click(object sender, EventArgs e)
        {
            await this.Exec(async () =>
            {
                await LoadInvoices();
            });
        }

        private async void searchPaymentsButton_Click(object sender, EventArgs e)
        {
            await this.Exec(async () =>
            {
                await LoadPayments();
            });
        }

        private async void recreateDbButton_Click_1(object sender, EventArgs e)
        {
            if (!this.Confirm($"Are you sure you want to recreate the current db ?")) return;
            if (string.IsNullOrEmpty(GlobalData.ConnectionString))
            {
                MessageBox.Show(@"Connection string is empty!");
                return;
            }

            await this.Exec(async () =>
            {
                var context = new MyContext();
                await Task.Run(context.Database.EnsureDeleted);
                await Task.Run(context.Database.Migrate);

            });
        }

        private async void scanButton_Click_1(object sender, EventArgs e)
        {
            debugT.Text = "";
            myTabs.SelectedTabPageIndex = 1;
            await SaveConfig();
            var service = new ScanInvoicesService(wintechInvoiceFolderI.Text, winsatInvoiceFolderI.Text, paymentsFolderI.Text);
            try
            {
                var (invoiceChanged, paymentChanged) = await Task.Run(service.MainWork);
                if (invoiceChanged || paymentChanged)
                    await this.Exec(async () =>
                    {
                        await LoadInvoiceFiles();
                        await LoadPayments();
                    });
            }
            catch (KnownException ex)
            {
                ErrorLog(ex.Message);
            }
            catch (Exception exception)
            {
                ErrorLog(exception.ToString());
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await SaveConfig();
        }
    }
}
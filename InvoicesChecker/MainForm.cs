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
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;
using InvoicesChecker.Extensions;
using InvoicesChecker.Forms;
using InvoicesChecker.Models;
using InvoicesChecker.Services;
using Microsoft.EntityFrameworkCore;
using Single = System.Single;

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
            connectionStringI.Text = config?.ConnectionString;
            GlobalData.ConnectionString = connectionStringI.Text;
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
                ConnectionString = connectionStringI.Text
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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await SaveConfig();
        }

        private async Task LoadInvoices()
        {
            var d = InvoiceDateEdit.DateTime;
            var context = new MyContext();
            // var invoices = await context.InvoiceFiles.AsNoTracking().Include(x => x.FACTUUR).Select(x => new { x.Client, x.Year, x.Week, x.FACTUUR }).ToListAsync();
            var invoiceFiles = (await context.InvoiceFiles.Select(x => new { x.Id, x.Client, x.Year, x.Week, x.FACTUUR }).ToListAsync()).ToDictionary(x => x.Id);
            var invoices = await context.FACTUUR.AsNoTracking().Where(x => x.CreatedAt.Year == d.Year && x.CreatedAt.Month == d.Month).ToListAsync();
            foreach (var invoice in invoices)
            {
                invoice.InvoiceFile = new InvoiceFile
                {
                    Client = invoiceFiles[invoice.InvoiceFileId].Client,
                    Year = invoiceFiles[invoice.InvoiceFileId].Year,
                    Week = invoiceFiles[invoice.InvoiceFileId].Week
                };
            }

            var invoiceAdapters = new List<InvoiceAdapter>();
            foreach (var invoice in invoices)
            {
                invoiceAdapters.Add(new InvoiceAdapter()
                {
                    Client = invoice.InvoiceFile.Client,
                    FileNumber = invoice.InvoiceFile.Week,
                    Year = invoice.InvoiceFile.Year,
                    GlnPartner = invoice.GLN_PARTNER,
                    InvoiceDate = invoice.CreatedAt,
                    OrderDate = invoice.ORDER_DATUM,
                    PurchaseNumber = invoice.ORDERNR_AFNEMER,
                    InvoiceNumber = invoice.FACTUURNUMMER,
                    Total = invoice.Total,
                    Payment = invoice.Payed,
                    RestToPay = invoice.Total - invoice.Payed
                });
            }

            InvoicesGrid.DataSource = invoiceAdapters;
        }

        private async Task LoadPayments()
        {
            var d = paymentDateI.DateTime;
            var context = new MyContext();
            var payments = await context.Payments.AsNoTracking().Where(x => x.FactuurId == null && x.Date.Year == d.Year && x.Date.Month == d.Month).ToListAsync();
            paymentsGrid.DataSource = payments;
        }

        private async void scanButton_Click(object sender, EventArgs e)
        {
            debugT.Text = "";
            myTabs.SelectedTabPageIndex = 1;
            await SaveConfig();
            var service = new ScanInvoicesService(wintechInvoiceFolderI.Text, winsatInvoiceFolderI.Text, paymentsFolderI.Text);
            try
            {
                await Task.Run(service.MainWork);
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

        private void recreateDbButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GlobalData.ConnectionString))
            {
                MessageBox.Show(@"Connection string is empty!");
                return;
            }

            try
            {
                var context = new MyContext();
                context.Database.EnsureDeleted();
                context.Database.Migrate();
                MessageBox.Show("Recreated");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message} {exception.Location()}");
            }
            // context.Database.ExecuteSqlRaw("use master;go;alter database InvoiceDb set single_user with rollback immediate;DROP DATABASE InvoiceDb;");
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
    }
}
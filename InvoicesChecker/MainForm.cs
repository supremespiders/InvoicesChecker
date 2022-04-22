using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Export;
using DevExpress.LookAndFeel;
using ExcelHelperExe;
using InvoicesChecker.Extensions;
using InvoicesChecker.Models;
using InvoicesChecker.Services;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MdiClient client;
        private List<InvoiceFile> _invoiceFiles;
        private List<InvoiceFile> _filteredInvoiceFiles;
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
            kwDiscountText.Text = config?.KwDiscount.ToString();
            LbDiscountText.Text = config?.lbDiscount.ToString();
            var cs = config?.ConnectionString;


            if (!File.Exists(GlobalData.ConnectionStringPath))
            {
                if (string.IsNullOrEmpty(cs))
                {
                    await File.WriteAllTextAsync(GlobalData.ConnectionStringPath, "Server=DESKTOP-G1IQ31I;Database=InvoiceDb;User Id=invoice;Password=qw182sdfRt7$;");
                    MessageBox.Show("Please enter a connection string");
                    return;
                }
                else
                {
                    GlobalData.ConnectionString = cs;
                }
            }
            else
            {
                GlobalData.ConnectionString = await File.ReadAllTextAsync(GlobalData.ConnectionStringPath);
            }

            if (string.IsNullOrEmpty(GlobalData.ConnectionString))
                return;

            InvoiceDateEdit.EditValue = DateTime.Now;
            paymentDateI.EditValue = DateTime.Now;
            invoiceStatusCombo.SelectedIndex = 0;
            _ = Task.Run(CheckForUpdates);
            //await this.Exec(async () =>
            //{
            //    await LoadInvoices();
            //    await LoadPayments();
            //});

            await this.Exec(async () =>
            {
                await LoadDates();
                await LoadInvoiceFiles();
                await LoadPayments();
            });
        }

        async Task LoadDates()
        {
            var selectedItem = -1;
            if (selectYearCombo.Properties.Items.Count > 0)
                selectedItem = (int)selectYearCombo.SelectedItem;
            var context = new MyContext();
            var invoiceFiles = await Task.Run(() => context.InvoiceFiles.ToList());
            var dates = invoiceFiles.Select(x => x.Year).Distinct().OrderByDescending(x => x).ToList();
            selectYearCombo.Properties.Items.AddRange(dates);
            selectYearCombo.SelectedIndex = 0;
            if (selectedItem != -1 && selectYearCombo.Properties.Items.Contains(selectedItem))
                selectYearCombo.SelectedItem = selectedItem;
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
            var b = decimal.TryParse(kwDiscountText.Text, out var kwDiscount);
            var b2 = decimal.TryParse(LbDiscountText.Text, out var lbDiscount);
            if (!b || !b2)
            {
                MessageBox.Show("Please enter valid discounts");
                return;
            }
            var config = new Config
            {
                WintechInvoiceFolder = wintechInvoiceFolderI.Text,
                WinsatInvoiceFolder = winsatInvoiceFolderI.Text,
                PaymentFolder = paymentsFolderI.Text,
                KwDiscount = kwDiscount,
                lbDiscount = lbDiscount

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
            if (selectYearCombo.Properties.Items.Count == 0) return;
            var year = (int)selectYearCombo.SelectedItem;
            var context = new MyContext();
            _invoiceFiles = (await context.InvoiceFiles.AsNoTracking().Where(x => x.Year == year).Include(x => x.Invoices).ToListAsync());
            _filteredInvoiceFiles = _invoiceFiles;
            invoiceFileGrid.DataSource = _invoiceFiles;
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

            var config = JsonSerializer.Deserialize<Config>(await File.ReadAllTextAsync("config"));
            var service = new ScanInvoicesService(wintechInvoiceFolderI.Text, winsatInvoiceFolderI.Text, paymentsFolderI.Text, config.KwDiscount, config.lbDiscount);
            try
            {
                var (invoiceChanged, paymentChanged) = await Task.Run(service.MainWork);
                if (invoiceChanged || paymentChanged)
                    await this.Exec(async () =>
                    {
                        await LoadDates();
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

        private async void searchInvoiceFilesButton_Click(object sender, EventArgs e)
        {
            await this.Exec(async () =>
            {
                await LoadInvoiceFiles();
                //await LoadPayments();
            });
        }

        private void invoiceStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_invoiceFiles == null) return;
            _filteredInvoiceFiles = new List<InvoiceFile>();
            foreach (var invoiceFile in _invoiceFiles)
            {
                var f = new InvoiceFile
                {
                    Id = invoiceFile.Id,
                    Year = invoiceFile.Year,
                    Client = invoiceFile.Client,
                    FileName = invoiceFile.FileName,
                    FileNumber = invoiceFile.FileNumber
                };
                switch (invoiceStatusCombo.SelectedIndex)
                {
                    case 0:
                        f.Invoices = invoiceFile.Invoices;
                        break;
                    case 1:
                        f.Invoices = invoiceFile.Invoices.Where(x => x.RestToPay == x.TotalToPay).ToList();
                        break;
                    case 2:
                        f.Invoices = invoiceFile.Invoices.Where(x => x.RestToPay != 0 && x.RestToPay != x.TotalToPay).ToList();
                        break;
                    case 3:
                        f.Invoices = invoiceFile.Invoices.Where(x => x.RestToPay == 0).ToList();
                        break;
                }

                f.TotalToPay = f.Invoices.Sum(x => x.TotalToPay);
                f.TotalPayed = f.Invoices.Sum(x => x.TotalPayed);
                f.RestToPay = f.Invoices.Sum(x => x.RestToPay);
                if (f.Invoices.Count != 0)
                    _filteredInvoiceFiles.Add(f);
            }
            invoiceFileGrid.DataSource = _filteredInvoiceFiles;
        }

        private async void exportInvoicesToExcel_Click(object sender, EventArgs e)
        {
            if (_filteredInvoiceFiles == null || _filteredInvoiceFiles.Count == 0) return;
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                InitialDirectory = Application.StartupPath,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            var savePath = saveFileDialog.FileName;
            try
            {
                var invoiceOutputs = new List<InvoiceOutput>();
                foreach (var invoiceFile in _filteredInvoiceFiles)
                {
                    foreach (var invoice in invoiceFile.Invoices)
                    {
                        var inv = new InvoiceOutput()
                        {
                            TotalPayed = invoice.TotalPayed,
                            RestToPay = invoice.RestToPay,
                            TotalToPay = invoice.TotalToPay,
                            Year = invoiceFile.Year,
                            InvoiceFile = invoiceFile.FileName,
                            FileNumber = invoiceFile.FileNumber,
                            GlnPartner = invoice.GlnPartner,
                            InvoiceDate = invoice.InvoiceDate,
                            InvoiceNumber = invoice.InvoiceNumber,
                            PurchaseNumber = invoice.PurchaseNumber,
                            OrderDate = invoice.OrderDate,
                            Client = invoiceFile.Client
                        };
                        invoiceOutputs.Add(inv);
                    }
                }
                await invoiceOutputs.SaveToExcel(savePath);
                var psi = new ProcessStartInfo
                {
                    FileName = savePath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private async void exportPaymentsButton_Click(object sender, EventArgs e)
        {
            var payments = (List<Payment>)paymentsGrid.DataSource;
            if (payments == null || payments.Count == 0) return;
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                InitialDirectory = Application.StartupPath,
                RestoreDirectory = true
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            var savePath = saveFileDialog.FileName;
            try
            {
                //await payments.SaveToExcel(savePath);
                paymentsGrid.ExportToXlsx(savePath);
                var psi = new ProcessStartInfo
                {
                    FileName = savePath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
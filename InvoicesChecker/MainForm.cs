﻿using DevExpress.XtraEditors;
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

            await this.Exec(async () =>
            {
                await LoadInvoices();
                await LoadPayments();
            });

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
                PaymentFolder = paymentsFolderI.Text
            };
            try
            {
                await File.WriteAllTextAsync("config", JsonSerializer.Serialize(config));
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
            var context = new MyContext();
            var invoices = await context.InvoiceFiles.AsNoTracking().Include(x => x.FACTUUR).Select(x => new { x.Client, x.Year, x.Week, x.FACTUUR }).ToListAsync();
            var invoiceAdapters = new List<InvoiceAdapter>();
            foreach (var invoice in invoices)
            {
                foreach (var factuur in invoice.FACTUUR)
                {
                    invoiceAdapters.Add(new InvoiceAdapter()
                    {
                        Client = invoice.Client,
                        Week = invoice.Week,
                        Year = invoice.Year,
                        GlnPartner = factuur.GLN_PARTNER,
                        InvoiceDate = factuur.FACTUURDATUM,
                        OrderDate = factuur.ORDER_DATUM,
                        PurchaseNumber = factuur.ORDERNR_AFNEMER,
                        InvoiceNumber = factuur.FACTUURNUMMER,
                        Total = factuur.Total,
                        Payment = factuur.Payed,
                        RestToPay = factuur.Total - factuur.Payed
                    });
                }
            }

            InvoicesGrid.DataSource = invoiceAdapters;
        }

        private async Task LoadPayments()
        {
            var context = new MyContext();
            var payments = await context.Payments.AsNoTracking().Where(x => x.FactuurId == null).ToListAsync();
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
    }
}
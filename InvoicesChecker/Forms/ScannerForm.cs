using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoicesChecker.Models;
using InvoicesChecker.Services;

namespace InvoicesChecker.Forms
{
    public partial class ScannerForm : DevExpress.XtraEditors.XtraForm
    {
        public ScannerForm()
        {
            InitializeComponent();
        }

        private async Task SaveConfig()
        {
            var config = new Config
            {
                WintechInvoiceFolder = wintechInvoiceFolderI.Text,
                WinsatInvoiceFolder = winsatInvoiceFolder.Text,
                PaymentFolder = paymentFolderI.Text
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



        private async void ScanButton_Click(object sender, EventArgs e)
        {
            await SaveConfig();
            var service = new ScanInvoicesService(wintechInvoiceFolderI.Text, winsatInvoiceFolder.Text, paymentFolderI.Text);
            try
            {
                await service.MainWork();
            }
            catch (KnownException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private async void ScannerForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("config")) return;
            var config = JsonSerializer.Deserialize<Config>(await File.ReadAllTextAsync("config"));
            wintechInvoiceFolderI.Text = config?.WintechInvoiceFolder;
            winsatInvoiceFolder.Text = config?.WinsatInvoiceFolder;
            paymentFolderI.Text = config?.PaymentFolder;
        }
    }
}
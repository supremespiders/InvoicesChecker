using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;
using InvoicesChecker.Forms;

namespace InvoicesChecker
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InvoicesTab_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(InvoicesForm));
        }

        public void OpenForm(Type type)
        {

            //allow only one instance of form to be opened
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                if (page.MdiChild.Name.Equals(type.Name))
                {
                    xtraTabbedMdiManager1.SelectedPage = page;
                    return;
                }

            var form = (XtraForm)Activator.CreateInstance(type);
            if (form == null) return;
            form.MdiParent = this;
            form.Show();
        }

        private void ScannerTab_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(ScannerForm));
        }
    }
}
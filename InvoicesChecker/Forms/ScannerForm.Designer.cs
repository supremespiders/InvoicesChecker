namespace InvoicesChecker.Forms
{
    partial class ScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.paymentFolderI = new DevExpress.XtraEditors.TextEdit();
            this.winsatInvoiceFolder = new DevExpress.XtraEditors.TextEdit();
            this.ScanButton = new DevExpress.XtraEditors.SimpleButton();
            this.wintechInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsatInvoiceFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wintechInvoiceFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.paymentFolderI);
            this.layoutControl1.Controls.Add(this.winsatInvoiceFolder);
            this.layoutControl1.Controls.Add(this.ScanButton);
            this.layoutControl1.Controls.Add(this.wintechInvoiceFolderI);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1174, 360, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1102, 746);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // paymentFolderI
            // 
            this.paymentFolderI.Location = new System.Drawing.Point(185, 72);
            this.paymentFolderI.Name = "paymentFolderI";
            this.paymentFolderI.Size = new System.Drawing.Size(905, 26);
            this.paymentFolderI.StyleController = this.layoutControl1;
            this.paymentFolderI.TabIndex = 3;
            // 
            // winsatInvoiceFolder
            // 
            this.winsatInvoiceFolder.Location = new System.Drawing.Point(185, 42);
            this.winsatInvoiceFolder.Name = "winsatInvoiceFolder";
            this.winsatInvoiceFolder.Size = new System.Drawing.Size(905, 26);
            this.winsatInvoiceFolder.StyleController = this.layoutControl1;
            this.winsatInvoiceFolder.TabIndex = 2;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(553, 102);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(537, 32);
            this.ScanButton.StyleController = this.layoutControl1;
            this.ScanButton.TabIndex = 4;
            this.ScanButton.Text = "Scan for changes";
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // wintechInvoiceFolderI
            // 
            this.wintechInvoiceFolderI.Location = new System.Drawing.Point(185, 12);
            this.wintechInvoiceFolderI.Name = "wintechInvoiceFolderI";
            this.wintechInvoiceFolderI.Size = new System.Drawing.Size(905, 26);
            this.wintechInvoiceFolderI.StyleController = this.layoutControl1;
            this.wintechInvoiceFolderI.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1102, 746);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.wintechInvoiceFolderI;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem1.Text = "Wintech Invoice Folder";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(161, 19);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 126);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1082, 600);
            this.emptySpaceItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ScanButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(541, 90);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(541, 36);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.winsatInvoiceFolder;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem3.Text = "Winsat Invoice Folder";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.paymentFolderI;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem4.Text = "Payment Folder";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(161, 19);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(541, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 746);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ScannerForm";
            this.Text = "ScannerForm";
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsatInvoiceFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wintechInvoiceFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton ScanButton;
        private DevExpress.XtraEditors.TextEdit wintechInvoiceFolderI;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit winsatInvoiceFolder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit paymentFolderI;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
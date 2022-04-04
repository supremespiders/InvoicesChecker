namespace InvoicesChecker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.myTabs = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.scanButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.paymentsFolderI = new DevExpress.XtraEditors.TextEdit();
            this.winsatInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            this.wintechInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.debugT = new System.Windows.Forms.RichTextBox();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.InvoicesGrid = new DevExpress.XtraGrid.GridControl();
            this.invoiceAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGlnPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.paymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeek1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabs)).BeginInit();
            this.myTabs.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsatInvoiceFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wintechInvoiceFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // myTabs
            // 
            this.myTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabs.Location = new System.Drawing.Point(0, 0);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedTabPage = this.xtraTabPage1;
            this.myTabs.Size = new System.Drawing.Size(2142, 961);
            this.myTabs.TabIndex = 1;
            this.myTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(2140, 926);
            this.xtraTabPage1.Text = "Scanner";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.scanButton);
            this.layoutControl1.Controls.Add(this.SaveButton);
            this.layoutControl1.Controls.Add(this.paymentsFolderI);
            this.layoutControl1.Controls.Add(this.winsatInvoiceFolderI);
            this.layoutControl1.Controls.Add(this.wintechInvoiceFolderI);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(2140, 926);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(1071, 138);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(1057, 32);
            this.scanButton.StyleController = this.layoutControl1;
            this.scanButton.TabIndex = 5;
            this.scanButton.Text = "Scan now";
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1071, 102);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(1057, 32);
            this.SaveButton.StyleController = this.layoutControl1;
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // paymentsFolderI
            // 
            this.paymentsFolderI.Location = new System.Drawing.Point(183, 72);
            this.paymentsFolderI.Name = "paymentsFolderI";
            this.paymentsFolderI.Size = new System.Drawing.Size(1945, 26);
            this.paymentsFolderI.StyleController = this.layoutControl1;
            this.paymentsFolderI.TabIndex = 3;
            // 
            // winsatInvoiceFolderI
            // 
            this.winsatInvoiceFolderI.Location = new System.Drawing.Point(183, 42);
            this.winsatInvoiceFolderI.Name = "winsatInvoiceFolderI";
            this.winsatInvoiceFolderI.Size = new System.Drawing.Size(1945, 26);
            this.winsatInvoiceFolderI.StyleController = this.layoutControl1;
            this.winsatInvoiceFolderI.TabIndex = 2;
            // 
            // wintechInvoiceFolderI
            // 
            this.wintechInvoiceFolderI.Location = new System.Drawing.Point(183, 12);
            this.wintechInvoiceFolderI.Name = "wintechInvoiceFolderI";
            this.wintechInvoiceFolderI.Size = new System.Drawing.Size(1945, 26);
            this.wintechInvoiceFolderI.StyleController = this.layoutControl1;
            this.wintechInvoiceFolderI.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.emptySpaceItem3,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(2140, 926);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.wintechInvoiceFolderI;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(2120, 30);
            this.layoutControlItem8.Text = "wintech Invoice Folder";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(159, 19);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 162);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(2120, 744);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.winsatInvoiceFolderI;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(2120, 30);
            this.layoutControlItem9.Text = "Winsat Invoice Folder";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(159, 19);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.paymentsFolderI;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(2120, 30);
            this.layoutControlItem10.Text = "Payments Folder";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(159, 19);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.SaveButton;
            this.layoutControlItem11.Location = new System.Drawing.Point(1059, 90);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(1061, 36);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.scanButton;
            this.layoutControlItem12.Location = new System.Drawing.Point(1059, 126);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(1061, 36);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(1059, 36);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 126);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(1059, 36);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.debugT);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(2140, 926);
            this.xtraTabPage2.Text = "Logs";
            // 
            // debugT
            // 
            this.debugT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugT.Location = new System.Drawing.Point(0, 49);
            this.debugT.Name = "debugT";
            this.debugT.Size = new System.Drawing.Size(2140, 877);
            this.debugT.TabIndex = 0;
            this.debugT.Text = "";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.InvoicesGrid);
            this.xtraTabPage3.Controls.Add(this.panelControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(2140, 926);
            this.xtraTabPage3.Text = "Invoices";
            // 
            // InvoicesGrid
            // 
            this.InvoicesGrid.DataSource = this.invoiceAdapterBindingSource;
            this.InvoicesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoicesGrid.Location = new System.Drawing.Point(0, 102);
            this.InvoicesGrid.MainView = this.gridView1;
            this.InvoicesGrid.Name = "InvoicesGrid";
            this.InvoicesGrid.Size = new System.Drawing.Size(2140, 824);
            this.InvoicesGrid.TabIndex = 1;
            this.InvoicesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // invoiceAdapterBindingSource
            // 
            this.invoiceAdapterBindingSource.DataSource = typeof(InvoicesChecker.Models.InvoiceAdapter);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClient,
            this.colYear,
            this.colWeek,
            this.colInvoiceNumber,
            this.colPurchaseNumber,
            this.colInvoiceDate,
            this.colOrderDate,
            this.colGlnPartner,
            this.colTotal,
            this.colPayment,
            this.colRestToPay});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[RestToPay] = 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[RestToPay] <> 0 And [RestToPay] <> [Total]";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.InvoicesGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colClient
            // 
            this.colClient.FieldName = "Client";
            this.colClient.MinWidth = 30;
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 0;
            this.colClient.Width = 112;
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.MinWidth = 30;
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            this.colYear.Width = 112;
            // 
            // colWeek
            // 
            this.colWeek.FieldName = "Week";
            this.colWeek.MinWidth = 30;
            this.colWeek.Name = "colWeek";
            this.colWeek.Visible = true;
            this.colWeek.VisibleIndex = 2;
            this.colWeek.Width = 112;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.FieldName = "InvoiceNumber";
            this.colInvoiceNumber.MinWidth = 30;
            this.colInvoiceNumber.Name = "colInvoiceNumber";
            this.colInvoiceNumber.Visible = true;
            this.colInvoiceNumber.VisibleIndex = 3;
            this.colInvoiceNumber.Width = 112;
            // 
            // colPurchaseNumber
            // 
            this.colPurchaseNumber.FieldName = "PurchaseNumber";
            this.colPurchaseNumber.MinWidth = 30;
            this.colPurchaseNumber.Name = "colPurchaseNumber";
            this.colPurchaseNumber.Visible = true;
            this.colPurchaseNumber.VisibleIndex = 4;
            this.colPurchaseNumber.Width = 112;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.MinWidth = 30;
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 5;
            this.colInvoiceDate.Width = 112;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 30;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 6;
            this.colOrderDate.Width = 112;
            // 
            // colGlnPartner
            // 
            this.colGlnPartner.FieldName = "GlnPartner";
            this.colGlnPartner.MinWidth = 30;
            this.colGlnPartner.Name = "colGlnPartner";
            this.colGlnPartner.Visible = true;
            this.colGlnPartner.VisibleIndex = 7;
            this.colGlnPartner.Width = 112;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 30;
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 112;
            // 
            // colPayment
            // 
            this.colPayment.FieldName = "Payment";
            this.colPayment.MinWidth = 30;
            this.colPayment.Name = "colPayment";
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 9;
            this.colPayment.Width = 112;
            // 
            // colRestToPay
            // 
            this.colRestToPay.FieldName = "RestToPay";
            this.colRestToPay.MinWidth = 30;
            this.colRestToPay.Name = "colRestToPay";
            this.colRestToPay.Visible = true;
            this.colRestToPay.VisibleIndex = 10;
            this.colRestToPay.Width = 112;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2140, 102);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.paymentsGrid);
            this.xtraTabPage4.Controls.Add(this.panelControl2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(2140, 926);
            this.xtraTabPage4.Text = "Payments";
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.DataSource = this.paymentBindingSource;
            this.paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsGrid.Location = new System.Drawing.Point(0, 76);
            this.paymentsGrid.MainView = this.gridView2;
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.Size = new System.Drawing.Size(2140, 850);
            this.paymentsGrid.TabIndex = 1;
            this.paymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = typeof(InvoicesChecker.Models.Payment);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDate,
            this.colClient1,
            this.colYear1,
            this.colWeek1,
            this.colInvoiceAmount,
            this.colDiscountUsed,
            this.colPaymentAmount,
            this.colOrder});
            this.gridView2.GridControl = this.paymentsGrid;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 30;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 112;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 30;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 112;
            // 
            // colClient1
            // 
            this.colClient1.FieldName = "Client";
            this.colClient1.MinWidth = 30;
            this.colClient1.Name = "colClient1";
            this.colClient1.Visible = true;
            this.colClient1.VisibleIndex = 2;
            this.colClient1.Width = 112;
            // 
            // colYear1
            // 
            this.colYear1.FieldName = "Year";
            this.colYear1.MinWidth = 30;
            this.colYear1.Name = "colYear1";
            this.colYear1.Visible = true;
            this.colYear1.VisibleIndex = 3;
            this.colYear1.Width = 112;
            // 
            // colWeek1
            // 
            this.colWeek1.FieldName = "Week";
            this.colWeek1.MinWidth = 30;
            this.colWeek1.Name = "colWeek1";
            this.colWeek1.Visible = true;
            this.colWeek1.VisibleIndex = 4;
            this.colWeek1.Width = 112;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.FieldName = "InvoiceAmount";
            this.colInvoiceAmount.MinWidth = 30;
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.Visible = true;
            this.colInvoiceAmount.VisibleIndex = 5;
            this.colInvoiceAmount.Width = 112;
            // 
            // colDiscountUsed
            // 
            this.colDiscountUsed.FieldName = "DiscountUsed";
            this.colDiscountUsed.MinWidth = 30;
            this.colDiscountUsed.Name = "colDiscountUsed";
            this.colDiscountUsed.Visible = true;
            this.colDiscountUsed.VisibleIndex = 6;
            this.colDiscountUsed.Width = 112;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.FieldName = "PaymentAmount";
            this.colPaymentAmount.MinWidth = 30;
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.Visible = true;
            this.colPaymentAmount.VisibleIndex = 7;
            this.colPaymentAmount.Width = 112;
            // 
            // colOrder
            // 
            this.colOrder.FieldName = "Order";
            this.colOrder.MinWidth = 30;
            this.colOrder.Name = "colOrder";
            this.colOrder.Visible = true;
            this.colOrder.VisibleIndex = 8;
            this.colOrder.Width = 112;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(2140, 76);
            this.panelControl2.TabIndex = 0;
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
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1102, 746);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
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
            this.layoutControlItem2.Location = new System.Drawing.Point(541, 90);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(541, 36);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem3.Text = "Winsat Invoice Folder";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem4
            // 
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
            // layoutControlItem5
            // 
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem5.Name = "layoutControlItem3";
            this.layoutControlItem5.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem5.Text = "Winsat Invoice Folder";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem6.Name = "layoutControlItem4";
            this.layoutControlItem6.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem6.Text = "Payment Folder";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem1";
            this.layoutControlItem7.Size = new System.Drawing.Size(1082, 30);
            this.layoutControlItem7.Text = "Wintech Invoice Folder";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(161, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2142, 961);
            this.Controls.Add(this.myTabs);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "InvoicesChecker 1.00";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabs)).EndInit();
            this.myTabs.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsatInvoiceFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wintechInvoiceFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraTab.XtraTabControl myTabs;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit paymentsFolderI;
        private DevExpress.XtraEditors.TextEdit winsatInvoiceFolderI;
        private DevExpress.XtraEditors.TextEdit wintechInvoiceFolderI;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.SimpleButton scanButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private System.Windows.Forms.RichTextBox debugT;
        private DevExpress.XtraGrid.GridControl InvoicesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource invoiceAdapterBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colGlnPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colRestToPay;
        private DevExpress.XtraGrid.GridControl paymentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colClient1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear1;
        private DevExpress.XtraGrid.Columns.GridColumn colWeek1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountUsed;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOrder;
    }
}
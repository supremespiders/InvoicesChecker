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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression7 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression8 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule9 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression9 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule10 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression10 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.invoicesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGlnPartner1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalToPay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPayed1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestToPay2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceFileGrid = new DevExpress.XtraGrid.GridControl();
            this.invoiceFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceFileView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClient2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRestToPay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.myTabs = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LbDiscountText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.kwDiscountText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.recreateDbButton = new DevExpress.XtraEditors.SimpleButton();
            this.scanButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.paymentsFolderI = new DevExpress.XtraEditors.TextEdit();
            this.winsatInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            this.wintechInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
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
            this.SearchInvoicesButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.InvoiceDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.paymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.exportPaymentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchPaymentsButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.paymentDateI = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.exportInvoicesToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.invoiceStatusCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.searchInvoiceFilesButton = new DevExpress.XtraEditors.SimpleButton();
            this.selectYearCombo = new DevExpress.XtraEditors.ComboBoxEdit();
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.wintechLBInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFileGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFileView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabs)).BeginInit();
            this.myTabs.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LbDiscountText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwDiscountText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsatInvoiceFolderI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wintechInvoiceFolderI.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateEdit.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateI.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateI.Properties)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectYearCombo.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.wintechLBInvoiceFolderI.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesView
            // 
            this.invoicesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNumber1,
            this.colInvoiceDate1,
            this.colOrderDate1,
            this.colPurchaseNumber1,
            this.colGlnPartner1,
            this.colTotalToPay1,
            this.colTotalPayed1,
            this.colRestToPay2,
            this.colTotalAmount1,
            this.gridColumn2});
            gridFormatRule7.ApplyToRow = true;
            gridFormatRule7.Name = "Format0";
            formatConditionRuleExpression7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression7.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression7.Expression = "[RestToPay] = 0";
            gridFormatRule7.Rule = formatConditionRuleExpression7;
            gridFormatRule8.ApplyToRow = true;
            gridFormatRule8.Name = "Format1";
            formatConditionRuleExpression8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression8.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression8.Expression = "[RestToPay] <> 0 And [RestToPay] <> [TotalToPay]";
            gridFormatRule8.Rule = formatConditionRuleExpression8;
            this.invoicesView.FormatRules.Add(gridFormatRule7);
            this.invoicesView.FormatRules.Add(gridFormatRule8);
            this.invoicesView.GridControl = this.invoiceFileGrid;
            this.invoicesView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalToPay", null, "")});
            this.invoicesView.Name = "invoicesView";
            this.invoicesView.OptionsBehavior.Editable = false;
            this.invoicesView.OptionsView.ShowFooter = true;
            this.invoicesView.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceNumber1
            // 
            this.colInvoiceNumber1.FieldName = "InvoiceNumber";
            this.colInvoiceNumber1.MinWidth = 30;
            this.colInvoiceNumber1.Name = "colInvoiceNumber1";
            this.colInvoiceNumber1.Visible = true;
            this.colInvoiceNumber1.VisibleIndex = 0;
            this.colInvoiceNumber1.Width = 112;
            // 
            // colInvoiceDate1
            // 
            this.colInvoiceDate1.FieldName = "InvoiceDate";
            this.colInvoiceDate1.MinWidth = 30;
            this.colInvoiceDate1.Name = "colInvoiceDate1";
            this.colInvoiceDate1.Visible = true;
            this.colInvoiceDate1.VisibleIndex = 1;
            this.colInvoiceDate1.Width = 112;
            // 
            // colOrderDate1
            // 
            this.colOrderDate1.FieldName = "OrderDate";
            this.colOrderDate1.MinWidth = 30;
            this.colOrderDate1.Name = "colOrderDate1";
            this.colOrderDate1.Visible = true;
            this.colOrderDate1.VisibleIndex = 2;
            this.colOrderDate1.Width = 112;
            // 
            // colPurchaseNumber1
            // 
            this.colPurchaseNumber1.FieldName = "PurchaseNumber";
            this.colPurchaseNumber1.MinWidth = 30;
            this.colPurchaseNumber1.Name = "colPurchaseNumber1";
            this.colPurchaseNumber1.Visible = true;
            this.colPurchaseNumber1.VisibleIndex = 3;
            this.colPurchaseNumber1.Width = 112;
            // 
            // colGlnPartner1
            // 
            this.colGlnPartner1.FieldName = "GlnPartner";
            this.colGlnPartner1.MinWidth = 30;
            this.colGlnPartner1.Name = "colGlnPartner1";
            this.colGlnPartner1.Visible = true;
            this.colGlnPartner1.VisibleIndex = 4;
            this.colGlnPartner1.Width = 112;
            // 
            // colTotalToPay1
            // 
            this.colTotalToPay1.FieldName = "TotalToPay";
            this.colTotalToPay1.MinWidth = 30;
            this.colTotalToPay1.Name = "colTotalToPay1";
            this.colTotalToPay1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalToPay", "Total To Pay={0:0.##}")});
            this.colTotalToPay1.Visible = true;
            this.colTotalToPay1.VisibleIndex = 7;
            this.colTotalToPay1.Width = 112;
            // 
            // colTotalPayed1
            // 
            this.colTotalPayed1.FieldName = "TotalPayed";
            this.colTotalPayed1.MinWidth = 30;
            this.colTotalPayed1.Name = "colTotalPayed1";
            this.colTotalPayed1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPayed", "Total Payed={0:0.##}")});
            this.colTotalPayed1.Visible = true;
            this.colTotalPayed1.VisibleIndex = 8;
            this.colTotalPayed1.Width = 112;
            // 
            // colRestToPay2
            // 
            this.colRestToPay2.FieldName = "RestToPay";
            this.colRestToPay2.MinWidth = 30;
            this.colRestToPay2.Name = "colRestToPay2";
            this.colRestToPay2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RestToPay", "Rest To Pay={0:0.##}")});
            this.colRestToPay2.Visible = true;
            this.colRestToPay2.VisibleIndex = 9;
            this.colRestToPay2.Width = 112;
            // 
            // colTotalAmount1
            // 
            this.colTotalAmount1.FieldName = "TotalAmount";
            this.colTotalAmount1.MinWidth = 30;
            this.colTotalAmount1.Name = "colTotalAmount1";
            this.colTotalAmount1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "Total Amount={0:0.##}")});
            this.colTotalAmount1.Visible = true;
            this.colTotalAmount1.VisibleIndex = 5;
            this.colTotalAmount1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Discount";
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn2", "Total Discount={0:0.##}")});
            this.gridColumn2.UnboundDataType = typeof(decimal);
            this.gridColumn2.UnboundExpression = "[TotalAmount] - [TotalToPay]";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 112;
            // 
            // invoiceFileGrid
            // 
            this.invoiceFileGrid.DataSource = this.invoiceFileBindingSource;
            this.invoiceFileGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.LevelTemplate = this.invoicesView;
            gridLevelNode2.RelationName = "Invoices";
            this.invoiceFileGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.invoiceFileGrid.Location = new System.Drawing.Point(2, 2);
            this.invoiceFileGrid.MainView = this.invoiceFileView;
            this.invoiceFileGrid.Name = "invoiceFileGrid";
            this.invoiceFileGrid.Size = new System.Drawing.Size(1646, 783);
            this.invoiceFileGrid.TabIndex = 0;
            this.invoiceFileGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.invoiceFileView,
            this.invoicesView});
            // 
            // invoiceFileBindingSource
            // 
            this.invoiceFileBindingSource.DataSource = typeof(InvoicesChecker.Models.InvoiceFile);
            // 
            // invoiceFileView
            // 
            this.invoiceFileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClient2,
            this.colYear2,
            this.colFileNumber,
            this.colFileName,
            this.colTotalToPay,
            this.colTotalPayed,
            this.colRestToPay1,
            this.colTotalAmount,
            this.gridColumn1});
            gridFormatRule9.ApplyToRow = true;
            gridFormatRule9.Name = "Format0";
            formatConditionRuleExpression9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression9.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression9.Expression = "[RestToPay] = 0";
            gridFormatRule9.Rule = formatConditionRuleExpression9;
            gridFormatRule10.ApplyToRow = true;
            gridFormatRule10.Name = "Format1";
            formatConditionRuleExpression10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression10.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression10.Expression = "[RestToPay] <> 0 And [RestToPay] <> [TotalToPay]";
            gridFormatRule10.Rule = formatConditionRuleExpression10;
            this.invoiceFileView.FormatRules.Add(gridFormatRule9);
            this.invoiceFileView.FormatRules.Add(gridFormatRule10);
            this.invoiceFileView.GridControl = this.invoiceFileGrid;
            this.invoiceFileView.Name = "invoiceFileView";
            this.invoiceFileView.OptionsBehavior.Editable = false;
            this.invoiceFileView.OptionsView.ShowFooter = true;
            this.invoiceFileView.OptionsView.ShowGroupPanel = false;
            // 
            // colClient2
            // 
            this.colClient2.FieldName = "Client";
            this.colClient2.MinWidth = 30;
            this.colClient2.Name = "colClient2";
            this.colClient2.Visible = true;
            this.colClient2.VisibleIndex = 1;
            this.colClient2.Width = 112;
            // 
            // colYear2
            // 
            this.colYear2.FieldName = "Year";
            this.colYear2.MinWidth = 30;
            this.colYear2.Name = "colYear2";
            this.colYear2.Visible = true;
            this.colYear2.VisibleIndex = 2;
            this.colYear2.Width = 112;
            // 
            // colFileNumber
            // 
            this.colFileNumber.FieldName = "FileNumber";
            this.colFileNumber.MinWidth = 30;
            this.colFileNumber.Name = "colFileNumber";
            this.colFileNumber.Visible = true;
            this.colFileNumber.VisibleIndex = 3;
            this.colFileNumber.Width = 112;
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.MinWidth = 30;
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 112;
            // 
            // colTotalToPay
            // 
            this.colTotalToPay.FieldName = "TotalToPay";
            this.colTotalToPay.MinWidth = 30;
            this.colTotalToPay.Name = "colTotalToPay";
            this.colTotalToPay.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalToPay", "Total to pay={0:0.##}")});
            this.colTotalToPay.Visible = true;
            this.colTotalToPay.VisibleIndex = 6;
            this.colTotalToPay.Width = 112;
            // 
            // colTotalPayed
            // 
            this.colTotalPayed.FieldName = "TotalPayed";
            this.colTotalPayed.MinWidth = 30;
            this.colTotalPayed.Name = "colTotalPayed";
            this.colTotalPayed.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPayed", "Total Payed={0:0.##}")});
            this.colTotalPayed.Visible = true;
            this.colTotalPayed.VisibleIndex = 7;
            this.colTotalPayed.Width = 112;
            // 
            // colRestToPay1
            // 
            this.colRestToPay1.FieldName = "RestToPay";
            this.colRestToPay1.MinWidth = 30;
            this.colRestToPay1.Name = "colRestToPay1";
            this.colRestToPay1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RestToPay", "Rest To Pay={0:0.##}")});
            this.colRestToPay1.Visible = true;
            this.colRestToPay1.VisibleIndex = 8;
            this.colRestToPay1.Width = 112;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.MinWidth = 30;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "Total Amount={0:0.##}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 4;
            this.colTotalAmount.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Discount";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "Total Discount={0:0.##}")});
            this.gridColumn1.UnboundDataType = typeof(decimal);
            this.gridColumn1.UnboundExpression = "[TotalAmount] - [TotalToPay]";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 112;
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
            this.myTabs.Size = new System.Drawing.Size(1652, 911);
            this.myTabs.TabIndex = 1;
            this.myTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.wintechLBInvoiceFolderI);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.LbDiscountText);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.kwDiscountText);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.recreateDbButton);
            this.xtraTabPage1.Controls.Add(this.scanButton);
            this.xtraTabPage1.Controls.Add(this.SaveButton);
            this.xtraTabPage1.Controls.Add(this.paymentsFolderI);
            this.xtraTabPage1.Controls.Add(this.winsatInvoiceFolderI);
            this.xtraTabPage1.Controls.Add(this.wintechInvoiceFolderI);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1650, 876);
            this.xtraTabPage1.Text = "Scanner";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(435, 249);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(83, 19);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "LB Discount";
            // 
            // LbDiscountText
            // 
            this.LbDiscountText.Location = new System.Drawing.Point(586, 246);
            this.LbDiscountText.Name = "LbDiscountText";
            this.LbDiscountText.Size = new System.Drawing.Size(123, 26);
            this.LbDiscountText.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(33, 249);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 19);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "KW Discount";
            // 
            // kwDiscountText
            // 
            this.kwDiscountText.Location = new System.Drawing.Point(255, 246);
            this.kwDiscountText.Name = "kwDiscountText";
            this.kwDiscountText.Size = new System.Drawing.Size(107, 26);
            this.kwDiscountText.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 197);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 19);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Payments Location";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 143);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(174, 19);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Winsat Invoices Location";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(211, 19);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Wintech KW Invoices Location";
            // 
            // recreateDbButton
            // 
            this.recreateDbButton.Appearance.BackColor = System.Drawing.Color.White;
            this.recreateDbButton.Appearance.Options.UseBackColor = true;
            this.recreateDbButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("recreateDbButton.ImageOptions.Image")));
            this.recreateDbButton.Location = new System.Drawing.Point(501, 312);
            this.recreateDbButton.Name = "recreateDbButton";
            this.recreateDbButton.Size = new System.Drawing.Size(219, 65);
            this.recreateDbButton.TabIndex = 11;
            this.recreateDbButton.Text = "Recreate database";
            this.recreateDbButton.Click += new System.EventHandler(this.recreateDbButton_Click_1);
            // 
            // scanButton
            // 
            this.scanButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("scanButton.ImageOptions.Image")));
            this.scanButton.Location = new System.Drawing.Point(726, 311);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(219, 66);
            this.scanButton.TabIndex = 12;
            this.scanButton.Text = "Scan now";
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.ImageOptions.Image")));
            this.SaveButton.Location = new System.Drawing.Point(951, 311);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(219, 64);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // paymentsFolderI
            // 
            this.paymentsFolderI.Location = new System.Drawing.Point(255, 194);
            this.paymentsFolderI.Name = "paymentsFolderI";
            this.paymentsFolderI.Size = new System.Drawing.Size(910, 26);
            this.paymentsFolderI.TabIndex = 9;
            // 
            // winsatInvoiceFolderI
            // 
            this.winsatInvoiceFolderI.Location = new System.Drawing.Point(255, 140);
            this.winsatInvoiceFolderI.Name = "winsatInvoiceFolderI";
            this.winsatInvoiceFolderI.Size = new System.Drawing.Size(910, 26);
            this.winsatInvoiceFolderI.TabIndex = 8;
            // 
            // wintechInvoiceFolderI
            // 
            this.wintechInvoiceFolderI.Location = new System.Drawing.Point(255, 38);
            this.wintechInvoiceFolderI.Name = "wintechInvoiceFolderI";
            this.wintechInvoiceFolderI.Size = new System.Drawing.Size(910, 26);
            this.wintechInvoiceFolderI.TabIndex = 7;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.debugT);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1650, 876);
            this.xtraTabPage2.Text = "Logs";
            // 
            // debugT
            // 
            this.debugT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.debugT.Location = new System.Drawing.Point(0, -1);
            this.debugT.Name = "debugT";
            this.debugT.Size = new System.Drawing.Size(1650, 877);
            this.debugT.TabIndex = 0;
            this.debugT.Text = "";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.InvoicesGrid);
            this.xtraTabPage3.Controls.Add(this.panelControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1650, 876);
            this.xtraTabPage3.Text = "Invoices";
            // 
            // InvoicesGrid
            // 
            this.InvoicesGrid.DataSource = this.invoiceAdapterBindingSource;
            this.InvoicesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoicesGrid.Location = new System.Drawing.Point(0, 102);
            this.InvoicesGrid.MainView = this.gridView1;
            this.InvoicesGrid.Name = "InvoicesGrid";
            this.InvoicesGrid.Size = new System.Drawing.Size(1650, 774);
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
            this.colWeek.Caption = "File number";
            this.colWeek.FieldName = "FileNumber";
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
            this.panelControl1.Controls.Add(this.SearchInvoicesButton);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.InvoiceDateEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1650, 102);
            this.panelControl1.TabIndex = 0;
            // 
            // SearchInvoicesButton
            // 
            this.SearchInvoicesButton.Location = new System.Drawing.Point(516, 33);
            this.SearchInvoicesButton.Name = "SearchInvoicesButton";
            this.SearchInvoicesButton.Size = new System.Drawing.Size(168, 35);
            this.SearchInvoicesButton.TabIndex = 2;
            this.SearchInvoicesButton.Text = "Search";
            this.SearchInvoicesButton.Click += new System.EventHandler(this.SearchInvoicesButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(164, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Month";
            // 
            // InvoiceDateEdit
            // 
            this.InvoiceDateEdit.EditValue = null;
            this.InvoiceDateEdit.Location = new System.Drawing.Point(255, 38);
            this.InvoiceDateEdit.Name = "InvoiceDateEdit";
            this.InvoiceDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoiceDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoiceDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.InvoiceDateEdit.Properties.MaskSettings.Set("mask", "Y");
            this.InvoiceDateEdit.Properties.UseMaskAsDisplayFormat = true;
            this.InvoiceDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.InvoiceDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.InvoiceDateEdit.Size = new System.Drawing.Size(225, 26);
            this.InvoiceDateEdit.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.paymentsGrid);
            this.xtraTabPage4.Controls.Add(this.panelControl2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1650, 876);
            this.xtraTabPage4.Text = "Non mapped Payments";
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.DataSource = this.paymentBindingSource;
            this.paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsGrid.Location = new System.Drawing.Point(0, 70);
            this.paymentsGrid.MainView = this.gridView2;
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.Size = new System.Drawing.Size(1650, 806);
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
            this.colDate,
            this.colClient1,
            this.colInvoiceAmount,
            this.colDiscountUsed,
            this.colPaymentAmount,
            this.colInvoiceNumber2});
            this.gridView2.GridControl = this.paymentsGrid;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 30;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 207;
            // 
            // colClient1
            // 
            this.colClient1.FieldName = "Client";
            this.colClient1.MinWidth = 30;
            this.colClient1.Name = "colClient1";
            this.colClient1.Visible = true;
            this.colClient1.VisibleIndex = 0;
            this.colClient1.Width = 98;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.FieldName = "InvoiceAmount";
            this.colInvoiceAmount.MinWidth = 30;
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.Visible = true;
            this.colInvoiceAmount.VisibleIndex = 3;
            this.colInvoiceAmount.Width = 498;
            // 
            // colDiscountUsed
            // 
            this.colDiscountUsed.FieldName = "DiscountUsed";
            this.colDiscountUsed.MinWidth = 30;
            this.colDiscountUsed.Name = "colDiscountUsed";
            this.colDiscountUsed.Visible = true;
            this.colDiscountUsed.VisibleIndex = 4;
            this.colDiscountUsed.Width = 498;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.FieldName = "PaymentAmount";
            this.colPaymentAmount.MinWidth = 30;
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.Visible = true;
            this.colPaymentAmount.VisibleIndex = 5;
            this.colPaymentAmount.Width = 517;
            // 
            // colInvoiceNumber2
            // 
            this.colInvoiceNumber2.FieldName = "InvoiceNumber";
            this.colInvoiceNumber2.MinWidth = 30;
            this.colInvoiceNumber2.Name = "colInvoiceNumber2";
            this.colInvoiceNumber2.Visible = true;
            this.colInvoiceNumber2.VisibleIndex = 2;
            this.colInvoiceNumber2.Width = 355;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.exportPaymentsButton);
            this.panelControl2.Controls.Add(this.searchPaymentsButton);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.paymentDateI);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1650, 70);
            this.panelControl2.TabIndex = 0;
            // 
            // exportPaymentsButton
            // 
            this.exportPaymentsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exportPaymentsButton.ImageOptions.Image")));
            this.exportPaymentsButton.Location = new System.Drawing.Point(562, 14);
            this.exportPaymentsButton.Name = "exportPaymentsButton";
            this.exportPaymentsButton.Size = new System.Drawing.Size(177, 35);
            this.exportPaymentsButton.TabIndex = 6;
            this.exportPaymentsButton.Text = "Export to Excel";
            this.exportPaymentsButton.Click += new System.EventHandler(this.exportPaymentsButton_Click);
            // 
            // searchPaymentsButton
            // 
            this.searchPaymentsButton.Location = new System.Drawing.Point(388, 14);
            this.searchPaymentsButton.Name = "searchPaymentsButton";
            this.searchPaymentsButton.Size = new System.Drawing.Size(168, 35);
            this.searchPaymentsButton.TabIndex = 5;
            this.searchPaymentsButton.Text = "Search";
            this.searchPaymentsButton.Visible = false;
            this.searchPaymentsButton.Click += new System.EventHandler(this.searchPaymentsButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Month";
            this.labelControl2.Visible = false;
            // 
            // paymentDateI
            // 
            this.paymentDateI.EditValue = null;
            this.paymentDateI.Location = new System.Drawing.Point(127, 19);
            this.paymentDateI.Name = "paymentDateI";
            this.paymentDateI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentDateI.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.paymentDateI.Properties.MaskSettings.Set("mask", "Y");
            this.paymentDateI.Properties.UseMaskAsDisplayFormat = true;
            this.paymentDateI.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.paymentDateI.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.paymentDateI.Size = new System.Drawing.Size(225, 26);
            this.paymentDateI.TabIndex = 3;
            this.paymentDateI.Visible = false;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.panelControl4);
            this.xtraTabPage5.Controls.Add(this.panelControl3);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1650, 876);
            this.xtraTabPage5.Text = "Invoice Files";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.invoiceFileGrid);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 89);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1650, 787);
            this.panelControl4.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.exportInvoicesToExcel);
            this.panelControl3.Controls.Add(this.invoiceStatusCombo);
            this.panelControl3.Controls.Add(this.searchInvoiceFilesButton);
            this.panelControl3.Controls.Add(this.selectYearCombo);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1650, 89);
            this.panelControl3.TabIndex = 0;
            // 
            // exportInvoicesToExcel
            // 
            this.exportInvoicesToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exportInvoicesToExcel.ImageOptions.Image")));
            this.exportInvoicesToExcel.Location = new System.Drawing.Point(460, 25);
            this.exportInvoicesToExcel.Name = "exportInvoicesToExcel";
            this.exportInvoicesToExcel.Size = new System.Drawing.Size(177, 35);
            this.exportInvoicesToExcel.TabIndex = 3;
            this.exportInvoicesToExcel.Text = "Export to Excel";
            this.exportInvoicesToExcel.Click += new System.EventHandler(this.exportInvoicesToExcel_Click);
            // 
            // invoiceStatusCombo
            // 
            this.invoiceStatusCombo.Location = new System.Drawing.Point(1372, 30);
            this.invoiceStatusCombo.Name = "invoiceStatusCombo";
            this.invoiceStatusCombo.Properties.AutoComplete = false;
            this.invoiceStatusCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invoiceStatusCombo.Properties.Items.AddRange(new object[] {
            "All",
            "Not Payed",
            "Partially Payed",
            "Payed"});
            this.invoiceStatusCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.invoiceStatusCombo.Size = new System.Drawing.Size(225, 26);
            this.invoiceStatusCombo.TabIndex = 2;
            this.invoiceStatusCombo.SelectedIndexChanged += new System.EventHandler(this.invoiceStatusCombo_SelectedIndexChanged);
            // 
            // searchInvoiceFilesButton
            // 
            this.searchInvoiceFilesButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("searchInvoiceFilesButton.ImageOptions.Image")));
            this.searchInvoiceFilesButton.Location = new System.Drawing.Point(286, 25);
            this.searchInvoiceFilesButton.Name = "searchInvoiceFilesButton";
            this.searchInvoiceFilesButton.Size = new System.Drawing.Size(168, 35);
            this.searchInvoiceFilesButton.TabIndex = 1;
            this.searchInvoiceFilesButton.Text = "Search";
            this.searchInvoiceFilesButton.Click += new System.EventHandler(this.searchInvoiceFilesButton_Click);
            // 
            // selectYearCombo
            // 
            this.selectYearCombo.Location = new System.Drawing.Point(34, 30);
            this.selectYearCombo.Name = "selectYearCombo";
            this.selectYearCombo.Properties.AutoComplete = false;
            this.selectYearCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.selectYearCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.selectYearCombo.Size = new System.Drawing.Size(225, 26);
            this.selectYearCombo.TabIndex = 0;
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
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(33, 92);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(205, 19);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Wintech LB Invoices Location";
            // 
            // wintechLBInvoiceFolderI
            // 
            this.wintechLBInvoiceFolderI.Location = new System.Drawing.Point(255, 89);
            this.wintechLBInvoiceFolderI.Name = "wintechLBInvoiceFolderI";
            this.wintechLBInvoiceFolderI.Size = new System.Drawing.Size(910, 26);
            this.wintechLBInvoiceFolderI.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 911);
            this.Controls.Add(this.myTabs);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "InvoicesChecker 1.05";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFileGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFileView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabs)).EndInit();
            this.myTabs.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LbDiscountText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kwDiscountText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsatInvoiceFolderI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wintechInvoiceFolderI.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDateEdit.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateI.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateI.Properties)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceStatusCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectYearCombo.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.wintechLBInvoiceFolderI.Properties)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colClient1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountUsed;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAmount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit InvoiceDateEdit;
        private DevExpress.XtraEditors.SimpleButton SearchInvoicesButton;
        private DevExpress.XtraEditors.SimpleButton searchPaymentsButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit paymentDateI;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl invoiceFileGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView invoiceFileView;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.BindingSource invoiceFileBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClient2;
        private DevExpress.XtraGrid.Columns.GridColumn colYear2;
        private DevExpress.XtraGrid.Columns.GridColumn colFileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalToPay;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayed;
        private DevExpress.XtraGrid.Columns.GridColumn colRestToPay1;
        private DevExpress.XtraGrid.Views.Grid.GridView invoicesView;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colGlnPartner1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalToPay1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPayed1;
        private DevExpress.XtraGrid.Columns.GridColumn colRestToPay2;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNumber2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton recreateDbButton;
        private DevExpress.XtraEditors.SimpleButton scanButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.TextEdit paymentsFolderI;
        private DevExpress.XtraEditors.TextEdit winsatInvoiceFolderI;
        private DevExpress.XtraEditors.TextEdit wintechInvoiceFolderI;
        private DevExpress.XtraEditors.ComboBoxEdit selectYearCombo;
        private DevExpress.XtraEditors.SimpleButton searchInvoiceFilesButton;
        private DevExpress.XtraEditors.ComboBoxEdit invoiceStatusCombo;
        private DevExpress.XtraEditors.SimpleButton exportInvoicesToExcel;
        private DevExpress.XtraEditors.SimpleButton exportPaymentsButton;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit LbDiscountText;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit kwDiscountText;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit wintechLBInvoiceFolderI;
    }
}
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression5 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression6 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            invoicesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colInvoiceNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPurchaseNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colGlnPartner1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalToPay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPayed1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colRestToPay2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colEcart1 = new DevExpress.XtraGrid.Columns.GridColumn();
            invoiceFileGrid = new DevExpress.XtraGrid.GridControl();
            invoiceFileBindingSource = new System.Windows.Forms.BindingSource(components);
            invoiceFileView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colClient2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colYear2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colFileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            colRestToPay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colEcart = new DevExpress.XtraGrid.Columns.GridColumn();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            myTabs = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            wintechLBInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            LbDiscountText = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            kwDiscountText = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            recreateDbButton = new DevExpress.XtraEditors.SimpleButton();
            scanButton = new DevExpress.XtraEditors.SimpleButton();
            SaveButton = new DevExpress.XtraEditors.SimpleButton();
            paymentsFolderI = new DevExpress.XtraEditors.TextEdit();
            winsatInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            wintechInvoiceFolderI = new DevExpress.XtraEditors.TextEdit();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            debugT = new System.Windows.Forms.RichTextBox();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            InvoicesGrid = new DevExpress.XtraGrid.GridControl();
            invoiceAdapterBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            colWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colPurchaseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colGlnPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            colRestToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            SearchInvoicesButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            InvoiceDateEdit = new DevExpress.XtraEditors.DateEdit();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            paymentsGrid = new DevExpress.XtraGrid.GridControl();
            paymentBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colClient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colDiscountUsed = new DevExpress.XtraGrid.Columns.GridColumn();
            colPaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceNumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            exportPaymentsButton = new DevExpress.XtraEditors.SimpleButton();
            searchPaymentsButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            paymentDateI = new DevExpress.XtraEditors.DateEdit();
            xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            invoiceStatusCheckedCombo = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            deleteButton = new DevExpress.XtraEditors.SimpleButton();
            exportInvoicesToExcel = new DevExpress.XtraEditors.SimpleButton();
            searchInvoiceFilesButton = new DevExpress.XtraEditors.SimpleButton();
            selectYearCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            panel1 = new System.Windows.Forms.Panel();
            BisGrid = new DevExpress.XtraGrid.GridControl();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl5 = new DevExpress.XtraEditors.PanelControl();
            ExportBisButton = new DevExpress.XtraEditors.SimpleButton();
            SearchBisButton = new DevExpress.XtraEditors.SimpleButton();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            BisDateI = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)invoicesView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceFileGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceFileBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceFileView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myTabs).BeginInit();
            myTabs.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wintechLBInvoiceFolderI.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LbDiscountText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kwDiscountText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentsFolderI.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winsatInvoiceFolderI.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wintechInvoiceFolderI.Properties).BeginInit();
            xtraTabPage2.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoicesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invoiceAdapterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceDateEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceDateEdit.Properties).BeginInit();
            xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentDateI.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentDateI.Properties).BeginInit();
            xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
            panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invoiceStatusCheckedCombo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectYearCombo.Properties).BeginInit();
            xtraTabPage6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BisGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl5).BeginInit();
            panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BisDateI.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BisDateI.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            SuspendLayout();
            // 
            // invoicesView
            // 
            invoicesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colInvoiceNumber1, colInvoiceDate1, colOrderDate1, colPurchaseNumber1, colGlnPartner1, colTotalToPay1, colTotalPayed1, colRestToPay2, colTotalAmount1, gridColumn2, colEcart1 });
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[RestToPay] = 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[RestToPay] <> 0 And [RestToPay] <> [TotalToPay]";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            invoicesView.FormatRules.Add(gridFormatRule1);
            invoicesView.FormatRules.Add(gridFormatRule2);
            invoicesView.GridControl = invoiceFileGrid;
            invoicesView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalToPay", null, "") });
            invoicesView.IndicatorWidth = 69;
            invoicesView.Name = "invoicesView";
            invoicesView.OptionsBehavior.Editable = false;
            invoicesView.OptionsView.ShowFooter = true;
            invoicesView.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceNumber1
            // 
            colInvoiceNumber1.FieldName = "InvoiceNumber";
            colInvoiceNumber1.MinWidth = 30;
            colInvoiceNumber1.Name = "colInvoiceNumber1";
            colInvoiceNumber1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InvoiceNumber", "Number of rows {0}") });
            colInvoiceNumber1.Visible = true;
            colInvoiceNumber1.VisibleIndex = 0;
            colInvoiceNumber1.Width = 112;
            // 
            // colInvoiceDate1
            // 
            colInvoiceDate1.FieldName = "InvoiceDate";
            colInvoiceDate1.MinWidth = 30;
            colInvoiceDate1.Name = "colInvoiceDate1";
            colInvoiceDate1.Visible = true;
            colInvoiceDate1.VisibleIndex = 1;
            colInvoiceDate1.Width = 112;
            // 
            // colOrderDate1
            // 
            colOrderDate1.FieldName = "OrderDate";
            colOrderDate1.MinWidth = 30;
            colOrderDate1.Name = "colOrderDate1";
            colOrderDate1.Visible = true;
            colOrderDate1.VisibleIndex = 2;
            colOrderDate1.Width = 112;
            // 
            // colPurchaseNumber1
            // 
            colPurchaseNumber1.FieldName = "PurchaseNumber";
            colPurchaseNumber1.MinWidth = 30;
            colPurchaseNumber1.Name = "colPurchaseNumber1";
            colPurchaseNumber1.Visible = true;
            colPurchaseNumber1.VisibleIndex = 3;
            colPurchaseNumber1.Width = 112;
            // 
            // colGlnPartner1
            // 
            colGlnPartner1.FieldName = "GlnPartner";
            colGlnPartner1.MinWidth = 30;
            colGlnPartner1.Name = "colGlnPartner1";
            colGlnPartner1.Visible = true;
            colGlnPartner1.VisibleIndex = 4;
            colGlnPartner1.Width = 112;
            // 
            // colTotalToPay1
            // 
            colTotalToPay1.FieldName = "TotalToPay";
            colTotalToPay1.MinWidth = 30;
            colTotalToPay1.Name = "colTotalToPay1";
            colTotalToPay1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalToPay", "Total To Pay={0:0.##}") });
            colTotalToPay1.Visible = true;
            colTotalToPay1.VisibleIndex = 7;
            colTotalToPay1.Width = 112;
            // 
            // colTotalPayed1
            // 
            colTotalPayed1.FieldName = "TotalPayed";
            colTotalPayed1.MinWidth = 30;
            colTotalPayed1.Name = "colTotalPayed1";
            colTotalPayed1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPayed", "Total Payed={0:0.##}") });
            colTotalPayed1.Visible = true;
            colTotalPayed1.VisibleIndex = 8;
            colTotalPayed1.Width = 112;
            // 
            // colRestToPay2
            // 
            colRestToPay2.FieldName = "RestToPay";
            colRestToPay2.MinWidth = 30;
            colRestToPay2.Name = "colRestToPay2";
            colRestToPay2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RestToPay", "Rest To Pay={0:0.##}") });
            colRestToPay2.Visible = true;
            colRestToPay2.VisibleIndex = 9;
            colRestToPay2.Width = 112;
            // 
            // colTotalAmount1
            // 
            colTotalAmount1.FieldName = "TotalAmount";
            colTotalAmount1.MinWidth = 30;
            colTotalAmount1.Name = "colTotalAmount1";
            colTotalAmount1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "Total Amount={0:0.##}") });
            colTotalAmount1.Visible = true;
            colTotalAmount1.VisibleIndex = 5;
            colTotalAmount1.Width = 112;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Discount";
            gridColumn2.FieldName = "gridColumn2";
            gridColumn2.MinWidth = 30;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn2", "Total Discount={0:0.##}") });
            gridColumn2.UnboundDataType = typeof(decimal);
            gridColumn2.UnboundExpression = "[TotalAmount] - [TotalToPay]";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 6;
            gridColumn2.Width = 112;
            // 
            // colEcart1
            // 
            colEcart1.DisplayFormat.FormatString = "P1";
            colEcart1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            colEcart1.FieldName = "Ecart";
            colEcart1.MinWidth = 32;
            colEcart1.Name = "colEcart1";
            colEcart1.Visible = true;
            colEcart1.VisibleIndex = 10;
            colEcart1.Width = 121;
            // 
            // invoiceFileGrid
            // 
            invoiceFileGrid.DataSource = invoiceFileBindingSource;
            invoiceFileGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            invoiceFileGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.LevelTemplate = invoicesView;
            gridLevelNode1.RelationName = "Invoices";
            invoiceFileGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            invoiceFileGrid.Location = new System.Drawing.Point(2, 2);
            invoiceFileGrid.MainView = invoiceFileView;
            invoiceFileGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            invoiceFileGrid.Name = "invoiceFileGrid";
            invoiceFileGrid.Size = new System.Drawing.Size(1646, 783);
            invoiceFileGrid.TabIndex = 0;
            invoiceFileGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { invoiceFileView, invoicesView });
            // 
            // invoiceFileBindingSource
            // 
            invoiceFileBindingSource.DataSource = typeof(Models.InvoiceFile);
            // 
            // invoiceFileView
            // 
            invoiceFileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colClient2, colYear2, colFileNumber, colFileName, colTotalToPay, colTotalPayed, colRestToPay1, colTotalAmount, gridColumn1, colEcart });
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format0";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "[RestToPay] = 0";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "Format1";
            formatConditionRuleExpression4.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            formatConditionRuleExpression4.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression4.Expression = "[RestToPay] <> 0 And [RestToPay] <> [TotalToPay]";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            invoiceFileView.FormatRules.Add(gridFormatRule3);
            invoiceFileView.FormatRules.Add(gridFormatRule4);
            invoiceFileView.GridControl = invoiceFileGrid;
            invoiceFileView.Name = "invoiceFileView";
            invoiceFileView.OptionsBehavior.Editable = false;
            invoiceFileView.OptionsView.ShowFooter = true;
            invoiceFileView.OptionsView.ShowGroupPanel = false;
            // 
            // colClient2
            // 
            colClient2.FieldName = "Client";
            colClient2.MinWidth = 30;
            colClient2.Name = "colClient2";
            colClient2.Visible = true;
            colClient2.VisibleIndex = 1;
            colClient2.Width = 112;
            // 
            // colYear2
            // 
            colYear2.FieldName = "Year";
            colYear2.MinWidth = 30;
            colYear2.Name = "colYear2";
            colYear2.Visible = true;
            colYear2.VisibleIndex = 2;
            colYear2.Width = 112;
            // 
            // colFileNumber
            // 
            colFileNumber.FieldName = "FileNumber";
            colFileNumber.MinWidth = 30;
            colFileNumber.Name = "colFileNumber";
            colFileNumber.Visible = true;
            colFileNumber.VisibleIndex = 3;
            colFileNumber.Width = 112;
            // 
            // colFileName
            // 
            colFileName.FieldName = "FileName";
            colFileName.MinWidth = 30;
            colFileName.Name = "colFileName";
            colFileName.Visible = true;
            colFileName.VisibleIndex = 0;
            colFileName.Width = 112;
            // 
            // colTotalToPay
            // 
            colTotalToPay.FieldName = "TotalToPay";
            colTotalToPay.MinWidth = 30;
            colTotalToPay.Name = "colTotalToPay";
            colTotalToPay.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalToPay", "Total to pay={0:0.##}") });
            colTotalToPay.Visible = true;
            colTotalToPay.VisibleIndex = 6;
            colTotalToPay.Width = 112;
            // 
            // colTotalPayed
            // 
            colTotalPayed.FieldName = "TotalPayed";
            colTotalPayed.MinWidth = 30;
            colTotalPayed.Name = "colTotalPayed";
            colTotalPayed.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPayed", "Total Payed={0:0.##}") });
            colTotalPayed.Visible = true;
            colTotalPayed.VisibleIndex = 7;
            colTotalPayed.Width = 112;
            // 
            // colRestToPay1
            // 
            colRestToPay1.FieldName = "RestToPay";
            colRestToPay1.MinWidth = 30;
            colRestToPay1.Name = "colRestToPay1";
            colRestToPay1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RestToPay", "Rest To Pay={0:0.##}") });
            colRestToPay1.Visible = true;
            colRestToPay1.VisibleIndex = 8;
            colRestToPay1.Width = 112;
            // 
            // colTotalAmount
            // 
            colTotalAmount.FieldName = "TotalAmount";
            colTotalAmount.MinWidth = 30;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "Total Amount={0:0.##}") });
            colTotalAmount.Visible = true;
            colTotalAmount.VisibleIndex = 4;
            colTotalAmount.Width = 112;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Discount";
            gridColumn1.FieldName = "gridColumn1";
            gridColumn1.MinWidth = 30;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "Total Discount={0:0.##}") });
            gridColumn1.UnboundDataType = typeof(decimal);
            gridColumn1.UnboundExpression = "[TotalAmount] - [TotalToPay]";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 5;
            gridColumn1.Width = 112;
            // 
            // colEcart
            // 
            colEcart.DisplayFormat.FormatString = "P1";
            colEcart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            colEcart.FieldName = "Ecart";
            colEcart.MinWidth = 32;
            colEcart.Name = "colEcart";
            colEcart.Visible = true;
            colEcart.VisibleIndex = 9;
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // myTabs
            // 
            myTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            myTabs.Location = new System.Drawing.Point(0, 0);
            myTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            myTabs.Name = "myTabs";
            myTabs.SelectedTabPage = xtraTabPage1;
            myTabs.Size = new System.Drawing.Size(1652, 911);
            myTabs.TabIndex = 1;
            myTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2, xtraTabPage3, xtraTabPage4, xtraTabPage5, xtraTabPage6 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(labelControl8);
            xtraTabPage1.Controls.Add(wintechLBInvoiceFolderI);
            xtraTabPage1.Controls.Add(labelControl7);
            xtraTabPage1.Controls.Add(LbDiscountText);
            xtraTabPage1.Controls.Add(labelControl6);
            xtraTabPage1.Controls.Add(kwDiscountText);
            xtraTabPage1.Controls.Add(labelControl5);
            xtraTabPage1.Controls.Add(labelControl4);
            xtraTabPage1.Controls.Add(labelControl3);
            xtraTabPage1.Controls.Add(recreateDbButton);
            xtraTabPage1.Controls.Add(scanButton);
            xtraTabPage1.Controls.Add(SaveButton);
            xtraTabPage1.Controls.Add(paymentsFolderI);
            xtraTabPage1.Controls.Add(winsatInvoiceFolderI);
            xtraTabPage1.Controls.Add(wintechInvoiceFolderI);
            xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(1650, 876);
            xtraTabPage1.Text = "Scanner";
            // 
            // labelControl8
            // 
            labelControl8.Location = new System.Drawing.Point(33, 91);
            labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(205, 19);
            labelControl8.TabIndex = 21;
            labelControl8.Text = "Wintech LB Invoices Location";
            // 
            // wintechLBInvoiceFolderI
            // 
            wintechLBInvoiceFolderI.Location = new System.Drawing.Point(255, 89);
            wintechLBInvoiceFolderI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            wintechLBInvoiceFolderI.Name = "wintechLBInvoiceFolderI";
            wintechLBInvoiceFolderI.Size = new System.Drawing.Size(910, 26);
            wintechLBInvoiceFolderI.TabIndex = 20;
            // 
            // labelControl7
            // 
            labelControl7.Location = new System.Drawing.Point(435, 249);
            labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(83, 19);
            labelControl7.TabIndex = 19;
            labelControl7.Text = "LB Discount";
            // 
            // LbDiscountText
            // 
            LbDiscountText.Location = new System.Drawing.Point(586, 246);
            LbDiscountText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LbDiscountText.Name = "LbDiscountText";
            LbDiscountText.Size = new System.Drawing.Size(123, 26);
            LbDiscountText.TabIndex = 18;
            // 
            // labelControl6
            // 
            labelControl6.Location = new System.Drawing.Point(33, 249);
            labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(89, 19);
            labelControl6.TabIndex = 17;
            labelControl6.Text = "KW Discount";
            // 
            // kwDiscountText
            // 
            kwDiscountText.Location = new System.Drawing.Point(255, 246);
            kwDiscountText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            kwDiscountText.Name = "kwDiscountText";
            kwDiscountText.Size = new System.Drawing.Size(107, 26);
            kwDiscountText.TabIndex = 16;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(33, 197);
            labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(132, 19);
            labelControl5.TabIndex = 15;
            labelControl5.Text = "Payments Location";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(33, 142);
            labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(174, 19);
            labelControl4.TabIndex = 14;
            labelControl4.Text = "Winsat Invoices Location";
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(33, 42);
            labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(211, 19);
            labelControl3.TabIndex = 13;
            labelControl3.Text = "Wintech KW Invoices Location";
            // 
            // recreateDbButton
            // 
            recreateDbButton.Appearance.BackColor = System.Drawing.Color.White;
            recreateDbButton.Appearance.Options.UseBackColor = true;
            recreateDbButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("recreateDbButton.ImageOptions.Image");
            recreateDbButton.Location = new System.Drawing.Point(501, 312);
            recreateDbButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            recreateDbButton.Name = "recreateDbButton";
            recreateDbButton.Size = new System.Drawing.Size(219, 65);
            recreateDbButton.TabIndex = 11;
            recreateDbButton.Text = "Recreate database";
            recreateDbButton.Visible = false;
            recreateDbButton.Click += recreateDbButton_Click_1;
            // 
            // scanButton
            // 
            scanButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("scanButton.ImageOptions.Image");
            scanButton.Location = new System.Drawing.Point(726, 311);
            scanButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            scanButton.Name = "scanButton";
            scanButton.Size = new System.Drawing.Size(219, 66);
            scanButton.TabIndex = 12;
            scanButton.Text = "Scan now";
            scanButton.Click += scanButton_Click_1;
            // 
            // SaveButton
            // 
            SaveButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("SaveButton.ImageOptions.Image");
            SaveButton.Location = new System.Drawing.Point(951, 311);
            SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(219, 64);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.Visible = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // paymentsFolderI
            // 
            paymentsFolderI.Location = new System.Drawing.Point(255, 194);
            paymentsFolderI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentsFolderI.Name = "paymentsFolderI";
            paymentsFolderI.Size = new System.Drawing.Size(910, 26);
            paymentsFolderI.TabIndex = 9;
            // 
            // winsatInvoiceFolderI
            // 
            winsatInvoiceFolderI.Location = new System.Drawing.Point(255, 140);
            winsatInvoiceFolderI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            winsatInvoiceFolderI.Name = "winsatInvoiceFolderI";
            winsatInvoiceFolderI.Size = new System.Drawing.Size(910, 26);
            winsatInvoiceFolderI.TabIndex = 8;
            // 
            // wintechInvoiceFolderI
            // 
            wintechInvoiceFolderI.Location = new System.Drawing.Point(255, 38);
            wintechInvoiceFolderI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            wintechInvoiceFolderI.Name = "wintechInvoiceFolderI";
            wintechInvoiceFolderI.Size = new System.Drawing.Size(910, 26);
            wintechInvoiceFolderI.TabIndex = 7;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(debugT);
            xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(1650, 876);
            xtraTabPage2.Text = "Logs";
            // 
            // debugT
            // 
            debugT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            debugT.Dock = System.Windows.Forms.DockStyle.Bottom;
            debugT.Location = new System.Drawing.Point(0, -2);
            debugT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            debugT.Name = "debugT";
            debugT.Size = new System.Drawing.Size(1650, 878);
            debugT.TabIndex = 0;
            debugT.Text = "";
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(InvoicesGrid);
            xtraTabPage3.Controls.Add(panelControl1);
            xtraTabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new System.Drawing.Size(1650, 876);
            xtraTabPage3.Text = "Invoices";
            // 
            // InvoicesGrid
            // 
            InvoicesGrid.DataSource = invoiceAdapterBindingSource;
            InvoicesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            InvoicesGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InvoicesGrid.Location = new System.Drawing.Point(0, 102);
            InvoicesGrid.MainView = gridView1;
            InvoicesGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InvoicesGrid.Name = "InvoicesGrid";
            InvoicesGrid.Size = new System.Drawing.Size(1650, 774);
            InvoicesGrid.TabIndex = 1;
            InvoicesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // invoiceAdapterBindingSource
            // 
            invoiceAdapterBindingSource.DataSource = typeof(Models.InvoiceAdapter);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colClient, colYear, colWeek, colInvoiceNumber, colPurchaseNumber, colInvoiceDate, colOrderDate, colGlnPartner, colTotal, colPayment, colRestToPay });
            gridFormatRule5.ApplyToRow = true;
            gridFormatRule5.Name = "Format0";
            formatConditionRuleExpression5.Appearance.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            formatConditionRuleExpression5.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression5.Expression = "[RestToPay] = 0";
            gridFormatRule5.Rule = formatConditionRuleExpression5;
            gridFormatRule6.ApplyToRow = true;
            gridFormatRule6.Name = "Format1";
            formatConditionRuleExpression6.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            formatConditionRuleExpression6.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression6.Expression = "[RestToPay] <> 0 And [RestToPay] <> [Total]";
            gridFormatRule6.Rule = formatConditionRuleExpression6;
            gridView1.FormatRules.Add(gridFormatRule5);
            gridView1.FormatRules.Add(gridFormatRule6);
            gridView1.GridControl = InvoicesGrid;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colClient
            // 
            colClient.FieldName = "Client";
            colClient.MinWidth = 30;
            colClient.Name = "colClient";
            colClient.Visible = true;
            colClient.VisibleIndex = 0;
            colClient.Width = 112;
            // 
            // colYear
            // 
            colYear.FieldName = "Year";
            colYear.MinWidth = 30;
            colYear.Name = "colYear";
            colYear.Visible = true;
            colYear.VisibleIndex = 1;
            colYear.Width = 112;
            // 
            // colWeek
            // 
            colWeek.Caption = "File number";
            colWeek.FieldName = "FileNumber";
            colWeek.MinWidth = 30;
            colWeek.Name = "colWeek";
            colWeek.Visible = true;
            colWeek.VisibleIndex = 2;
            colWeek.Width = 112;
            // 
            // colInvoiceNumber
            // 
            colInvoiceNumber.FieldName = "InvoiceNumber";
            colInvoiceNumber.MinWidth = 30;
            colInvoiceNumber.Name = "colInvoiceNumber";
            colInvoiceNumber.Visible = true;
            colInvoiceNumber.VisibleIndex = 3;
            colInvoiceNumber.Width = 112;
            // 
            // colPurchaseNumber
            // 
            colPurchaseNumber.FieldName = "PurchaseNumber";
            colPurchaseNumber.MinWidth = 30;
            colPurchaseNumber.Name = "colPurchaseNumber";
            colPurchaseNumber.Visible = true;
            colPurchaseNumber.VisibleIndex = 4;
            colPurchaseNumber.Width = 112;
            // 
            // colInvoiceDate
            // 
            colInvoiceDate.FieldName = "InvoiceDate";
            colInvoiceDate.MinWidth = 30;
            colInvoiceDate.Name = "colInvoiceDate";
            colInvoiceDate.Visible = true;
            colInvoiceDate.VisibleIndex = 5;
            colInvoiceDate.Width = 112;
            // 
            // colOrderDate
            // 
            colOrderDate.FieldName = "OrderDate";
            colOrderDate.MinWidth = 30;
            colOrderDate.Name = "colOrderDate";
            colOrderDate.Visible = true;
            colOrderDate.VisibleIndex = 6;
            colOrderDate.Width = 112;
            // 
            // colGlnPartner
            // 
            colGlnPartner.FieldName = "GlnPartner";
            colGlnPartner.MinWidth = 30;
            colGlnPartner.Name = "colGlnPartner";
            colGlnPartner.Visible = true;
            colGlnPartner.VisibleIndex = 7;
            colGlnPartner.Width = 112;
            // 
            // colTotal
            // 
            colTotal.FieldName = "Total";
            colTotal.MinWidth = 30;
            colTotal.Name = "colTotal";
            colTotal.Visible = true;
            colTotal.VisibleIndex = 8;
            colTotal.Width = 112;
            // 
            // colPayment
            // 
            colPayment.FieldName = "Payment";
            colPayment.MinWidth = 30;
            colPayment.Name = "colPayment";
            colPayment.Visible = true;
            colPayment.VisibleIndex = 9;
            colPayment.Width = 112;
            // 
            // colRestToPay
            // 
            colRestToPay.FieldName = "RestToPay";
            colRestToPay.MinWidth = 30;
            colRestToPay.Name = "colRestToPay";
            colRestToPay.Visible = true;
            colRestToPay.VisibleIndex = 10;
            colRestToPay.Width = 112;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(SearchInvoicesButton);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(InvoiceDateEdit);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1650, 102);
            panelControl1.TabIndex = 0;
            // 
            // SearchInvoicesButton
            // 
            SearchInvoicesButton.Location = new System.Drawing.Point(516, 33);
            SearchInvoicesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SearchInvoicesButton.Name = "SearchInvoicesButton";
            SearchInvoicesButton.Size = new System.Drawing.Size(168, 34);
            SearchInvoicesButton.TabIndex = 2;
            SearchInvoicesButton.Text = "Search";
            SearchInvoicesButton.Click += SearchInvoicesButton_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(165, 42);
            labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(44, 19);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Month";
            // 
            // InvoiceDateEdit
            // 
            InvoiceDateEdit.EditValue = null;
            InvoiceDateEdit.Location = new System.Drawing.Point(255, 38);
            InvoiceDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InvoiceDateEdit.Name = "InvoiceDateEdit";
            InvoiceDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            InvoiceDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            InvoiceDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            InvoiceDateEdit.Properties.MaskSettings.Set("mask", "Y");
            InvoiceDateEdit.Properties.UseMaskAsDisplayFormat = true;
            InvoiceDateEdit.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            InvoiceDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            InvoiceDateEdit.Size = new System.Drawing.Size(225, 26);
            InvoiceDateEdit.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(paymentsGrid);
            xtraTabPage4.Controls.Add(panelControl2);
            xtraTabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new System.Drawing.Size(1650, 876);
            xtraTabPage4.Text = "Non mapped Payments";
            // 
            // paymentsGrid
            // 
            paymentsGrid.DataSource = paymentBindingSource;
            paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            paymentsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentsGrid.Location = new System.Drawing.Point(0, 70);
            paymentsGrid.MainView = gridView2;
            paymentsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentsGrid.Name = "paymentsGrid";
            paymentsGrid.Size = new System.Drawing.Size(1650, 806);
            paymentsGrid.TabIndex = 1;
            paymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // paymentBindingSource
            // 
            paymentBindingSource.DataSource = typeof(Models.Payment);
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colDate, colClient1, colInvoiceAmount, colDiscountUsed, colPaymentAmount, colInvoiceNumber2 });
            gridView2.GridControl = paymentsGrid;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            colDate.FieldName = "Date";
            colDate.MinWidth = 30;
            colDate.Name = "colDate";
            colDate.Visible = true;
            colDate.VisibleIndex = 1;
            colDate.Width = 207;
            // 
            // colClient1
            // 
            colClient1.FieldName = "Client";
            colClient1.MinWidth = 30;
            colClient1.Name = "colClient1";
            colClient1.Visible = true;
            colClient1.VisibleIndex = 0;
            colClient1.Width = 98;
            // 
            // colInvoiceAmount
            // 
            colInvoiceAmount.FieldName = "InvoiceAmount";
            colInvoiceAmount.MinWidth = 30;
            colInvoiceAmount.Name = "colInvoiceAmount";
            colInvoiceAmount.Visible = true;
            colInvoiceAmount.VisibleIndex = 3;
            colInvoiceAmount.Width = 498;
            // 
            // colDiscountUsed
            // 
            colDiscountUsed.FieldName = "DiscountUsed";
            colDiscountUsed.MinWidth = 30;
            colDiscountUsed.Name = "colDiscountUsed";
            colDiscountUsed.Visible = true;
            colDiscountUsed.VisibleIndex = 4;
            colDiscountUsed.Width = 498;
            // 
            // colPaymentAmount
            // 
            colPaymentAmount.FieldName = "PaymentAmount";
            colPaymentAmount.MinWidth = 30;
            colPaymentAmount.Name = "colPaymentAmount";
            colPaymentAmount.Visible = true;
            colPaymentAmount.VisibleIndex = 5;
            colPaymentAmount.Width = 517;
            // 
            // colInvoiceNumber2
            // 
            colInvoiceNumber2.FieldName = "InvoiceNumber";
            colInvoiceNumber2.MinWidth = 30;
            colInvoiceNumber2.Name = "colInvoiceNumber2";
            colInvoiceNumber2.Visible = true;
            colInvoiceNumber2.VisibleIndex = 2;
            colInvoiceNumber2.Width = 355;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(exportPaymentsButton);
            panelControl2.Controls.Add(searchPaymentsButton);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(paymentDateI);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl2.Location = new System.Drawing.Point(0, 0);
            panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1650, 70);
            panelControl2.TabIndex = 0;
            // 
            // exportPaymentsButton
            // 
            exportPaymentsButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("exportPaymentsButton.ImageOptions.Image");
            exportPaymentsButton.Location = new System.Drawing.Point(562, 14);
            exportPaymentsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            exportPaymentsButton.Name = "exportPaymentsButton";
            exportPaymentsButton.Size = new System.Drawing.Size(177, 34);
            exportPaymentsButton.TabIndex = 6;
            exportPaymentsButton.Text = "Export to Excel";
            exportPaymentsButton.Click += exportPaymentsButton_Click;
            // 
            // searchPaymentsButton
            // 
            searchPaymentsButton.Location = new System.Drawing.Point(388, 14);
            searchPaymentsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchPaymentsButton.Name = "searchPaymentsButton";
            searchPaymentsButton.Size = new System.Drawing.Size(168, 34);
            searchPaymentsButton.TabIndex = 5;
            searchPaymentsButton.Text = "Search";
            searchPaymentsButton.Visible = false;
            searchPaymentsButton.Click += searchPaymentsButton_Click;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(36, 23);
            labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(44, 19);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Month";
            labelControl2.Visible = false;
            // 
            // paymentDateI
            // 
            paymentDateI.EditValue = null;
            paymentDateI.Location = new System.Drawing.Point(127, 19);
            paymentDateI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            paymentDateI.Name = "paymentDateI";
            paymentDateI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            paymentDateI.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            paymentDateI.Properties.MaskSettings.Set("mask", "Y");
            paymentDateI.Properties.UseMaskAsDisplayFormat = true;
            paymentDateI.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            paymentDateI.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            paymentDateI.Size = new System.Drawing.Size(225, 26);
            paymentDateI.TabIndex = 3;
            paymentDateI.Visible = false;
            // 
            // xtraTabPage5
            // 
            xtraTabPage5.Controls.Add(panelControl4);
            xtraTabPage5.Controls.Add(panelControl3);
            xtraTabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xtraTabPage5.Name = "xtraTabPage5";
            xtraTabPage5.Size = new System.Drawing.Size(1650, 876);
            xtraTabPage5.Text = "Invoice Files";
            // 
            // panelControl4
            // 
            panelControl4.Controls.Add(invoiceFileGrid);
            panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl4.Location = new System.Drawing.Point(0, 89);
            panelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new System.Drawing.Size(1650, 787);
            panelControl4.TabIndex = 1;
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(invoiceStatusCheckedCombo);
            panelControl3.Controls.Add(deleteButton);
            panelControl3.Controls.Add(exportInvoicesToExcel);
            panelControl3.Controls.Add(searchInvoiceFilesButton);
            panelControl3.Controls.Add(selectYearCombo);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl3.Location = new System.Drawing.Point(0, 0);
            panelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(1650, 89);
            panelControl3.TabIndex = 0;
            // 
            // invoiceStatusCheckedCombo
            // 
            invoiceStatusCheckedCombo.EditValue = "Not Payed, Partially Payed, Payed";
            invoiceStatusCheckedCombo.Location = new System.Drawing.Point(1084, 30);
            invoiceStatusCheckedCombo.Name = "invoiceStatusCheckedCombo";
            invoiceStatusCheckedCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            invoiceStatusCheckedCombo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Not Payed", System.Windows.Forms.CheckState.Checked), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Partially Payed", System.Windows.Forms.CheckState.Checked), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Payed", System.Windows.Forms.CheckState.Checked) });
            invoiceStatusCheckedCombo.Size = new System.Drawing.Size(363, 26);
            invoiceStatusCheckedCombo.TabIndex = 5;
            invoiceStatusCheckedCombo.EditValueChanged += invoiceStatusCheckedCombo_EditValueChanged;
            // 
            // deleteButton
            // 
            deleteButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("deleteButton.ImageOptions.Image");
            deleteButton.Location = new System.Drawing.Point(654, 25);
            deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(162, 34);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // exportInvoicesToExcel
            // 
            exportInvoicesToExcel.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("exportInvoicesToExcel.ImageOptions.Image");
            exportInvoicesToExcel.Location = new System.Drawing.Point(460, 25);
            exportInvoicesToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            exportInvoicesToExcel.Name = "exportInvoicesToExcel";
            exportInvoicesToExcel.Size = new System.Drawing.Size(177, 34);
            exportInvoicesToExcel.TabIndex = 3;
            exportInvoicesToExcel.Text = "Export to Excel";
            exportInvoicesToExcel.Click += exportInvoicesToExcel_Click;
            // 
            // searchInvoiceFilesButton
            // 
            searchInvoiceFilesButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("searchInvoiceFilesButton.ImageOptions.Image");
            searchInvoiceFilesButton.Location = new System.Drawing.Point(285, 25);
            searchInvoiceFilesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            searchInvoiceFilesButton.Name = "searchInvoiceFilesButton";
            searchInvoiceFilesButton.Size = new System.Drawing.Size(168, 34);
            searchInvoiceFilesButton.TabIndex = 1;
            searchInvoiceFilesButton.Text = "Search";
            searchInvoiceFilesButton.Click += searchInvoiceFilesButton_Click;
            // 
            // selectYearCombo
            // 
            selectYearCombo.Location = new System.Drawing.Point(33, 30);
            selectYearCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            selectYearCombo.Name = "selectYearCombo";
            selectYearCombo.Properties.AutoComplete = false;
            selectYearCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            selectYearCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            selectYearCombo.Size = new System.Drawing.Size(225, 26);
            selectYearCombo.TabIndex = 0;
            // 
            // xtraTabPage6
            // 
            xtraTabPage6.Controls.Add(panel1);
            xtraTabPage6.Controls.Add(panelControl5);
            xtraTabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xtraTabPage6.Name = "xtraTabPage6";
            xtraTabPage6.Size = new System.Drawing.Size(1650, 876);
            xtraTabPage6.Text = "BIS";
            // 
            // panel1
            // 
            panel1.Controls.Add(BisGrid);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 70);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1650, 806);
            panel1.TabIndex = 2;
            // 
            // BisGrid
            // 
            BisGrid.DataSource = paymentBindingSource;
            BisGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            BisGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BisGrid.Location = new System.Drawing.Point(0, 0);
            BisGrid.MainView = gridView3;
            BisGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BisGrid.Name = "BisGrid";
            BisGrid.Size = new System.Drawing.Size(1650, 806);
            BisGrid.TabIndex = 2;
            BisGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView3 });
            // 
            // gridView3
            // 
            gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8 });
            gridView3.GridControl = BisGrid;
            gridView3.Name = "gridView3";
            gridView3.OptionsBehavior.Editable = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            gridColumn3.FieldName = "Date";
            gridColumn3.MinWidth = 30;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            gridColumn3.Width = 207;
            // 
            // gridColumn4
            // 
            gridColumn4.FieldName = "Client";
            gridColumn4.MinWidth = 30;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 0;
            gridColumn4.Width = 98;
            // 
            // gridColumn5
            // 
            gridColumn5.FieldName = "InvoiceAmount";
            gridColumn5.MinWidth = 30;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 3;
            gridColumn5.Width = 498;
            // 
            // gridColumn6
            // 
            gridColumn6.FieldName = "DiscountUsed";
            gridColumn6.MinWidth = 30;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 4;
            gridColumn6.Width = 498;
            // 
            // gridColumn7
            // 
            gridColumn7.FieldName = "PaymentAmount";
            gridColumn7.MinWidth = 30;
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 5;
            gridColumn7.Width = 517;
            // 
            // gridColumn8
            // 
            gridColumn8.FieldName = "InvoiceNumber";
            gridColumn8.MinWidth = 30;
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 2;
            gridColumn8.Width = 355;
            // 
            // panelControl5
            // 
            panelControl5.Controls.Add(ExportBisButton);
            panelControl5.Controls.Add(SearchBisButton);
            panelControl5.Controls.Add(labelControl9);
            panelControl5.Controls.Add(BisDateI);
            panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl5.Location = new System.Drawing.Point(0, 0);
            panelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelControl5.Name = "panelControl5";
            panelControl5.Size = new System.Drawing.Size(1650, 70);
            panelControl5.TabIndex = 1;
            // 
            // ExportBisButton
            // 
            ExportBisButton.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("ExportBisButton.ImageOptions.Image");
            ExportBisButton.Location = new System.Drawing.Point(562, 14);
            ExportBisButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ExportBisButton.Name = "ExportBisButton";
            ExportBisButton.Size = new System.Drawing.Size(177, 34);
            ExportBisButton.TabIndex = 6;
            ExportBisButton.Text = "Export to Excel";
            ExportBisButton.Click += ExportBisButton_Click;
            // 
            // SearchBisButton
            // 
            SearchBisButton.Location = new System.Drawing.Point(388, 14);
            SearchBisButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SearchBisButton.Name = "SearchBisButton";
            SearchBisButton.Size = new System.Drawing.Size(168, 34);
            SearchBisButton.TabIndex = 5;
            SearchBisButton.Text = "Search";
            SearchBisButton.Visible = false;
            SearchBisButton.Click += SearchBisButton_Click;
            // 
            // labelControl9
            // 
            labelControl9.Location = new System.Drawing.Point(36, 23);
            labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(44, 19);
            labelControl9.TabIndex = 4;
            labelControl9.Text = "Month";
            labelControl9.Visible = false;
            // 
            // BisDateI
            // 
            BisDateI.EditValue = null;
            BisDateI.Location = new System.Drawing.Point(127, 19);
            BisDateI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BisDateI.Name = "BisDateI";
            BisDateI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            BisDateI.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            BisDateI.Properties.MaskSettings.Set("mask", "Y");
            BisDateI.Properties.UseMaskAsDisplayFormat = true;
            BisDateI.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            BisDateI.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            BisDateI.Size = new System.Drawing.Size(225, 26);
            BisDateI.TabIndex = 3;
            BisDateI.Visible = false;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, emptySpaceItem2 });
            Root.Location = new System.Drawing.Point(0, 0);
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1102, 746);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(1082, 30);
            layoutControlItem1.Text = "Wintech Invoice Folder";
            layoutControlItem1.TextSize = new System.Drawing.Size(161, 19);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 126);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(1082, 600);
            emptySpaceItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Location = new System.Drawing.Point(541, 90);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(541, 36);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(1082, 30);
            layoutControlItem3.Text = "Winsat Invoice Folder";
            layoutControlItem3.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(1082, 30);
            layoutControlItem4.Text = "Payment Folder";
            layoutControlItem4.TextSize = new System.Drawing.Size(161, 19);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(0, 90);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(541, 36);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Location = new System.Drawing.Point(0, 30);
            layoutControlItem5.Name = "layoutControlItem3";
            layoutControlItem5.Size = new System.Drawing.Size(1082, 30);
            layoutControlItem5.Text = "Winsat Invoice Folder";
            layoutControlItem5.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Location = new System.Drawing.Point(0, 60);
            layoutControlItem6.Name = "layoutControlItem4";
            layoutControlItem6.Size = new System.Drawing.Size(1082, 30);
            layoutControlItem6.Text = "Payment Folder";
            layoutControlItem6.TextSize = new System.Drawing.Size(161, 19);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            layoutControlItem7.Name = "layoutControlItem1";
            layoutControlItem7.Size = new System.Drawing.Size(1082, 30);
            layoutControlItem7.Text = "Wintech Invoice Folder";
            layoutControlItem7.TextSize = new System.Drawing.Size(161, 19);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1652, 911);
            Controls.Add(myTabs);
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "InvoicesChecker 1.10";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)invoicesView).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceFileGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceFileBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceFileView).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)myTabs).EndInit();
            myTabs.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wintechLBInvoiceFolderI.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LbDiscountText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)kwDiscountText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentsFolderI.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)winsatInvoiceFolderI.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)wintechInvoiceFolderI.Properties).EndInit();
            xtraTabPage2.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoicesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)invoiceAdapterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InvoiceDateEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceDateEdit.Properties).EndInit();
            xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)paymentsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paymentDateI.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentDateI.Properties).EndInit();
            xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
            panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)invoiceStatusCheckedCombo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectYearCombo.Properties).EndInit();
            xtraTabPage6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BisGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl5).EndInit();
            panelControl5.ResumeLayout(false);
            panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BisDateI.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BisDateI.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ResumeLayout(false);
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
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton ExportBisButton;
        private DevExpress.XtraEditors.SimpleButton SearchBisButton;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit BisDateI;
        private DevExpress.XtraGrid.GridControl BisGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraGrid.Columns.GridColumn colEcart;
        private DevExpress.XtraGrid.Columns.GridColumn colEcart1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit invoiceStatusCheckedCombo;
    }
}
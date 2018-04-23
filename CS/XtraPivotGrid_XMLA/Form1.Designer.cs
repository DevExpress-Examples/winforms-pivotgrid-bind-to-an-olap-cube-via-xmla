namespace XtraPivotGrid_XMLA
{
    partial class Form1
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldInternetSalesAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldInternetSalesAmount,
            this.fieldCountry,
            this.fieldYear});
            pivotGridGroup1.Caption = "Year - Month";
            pivotGridGroup1.Hierarchy = null;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            this.pivotGridControl1.Size = new System.Drawing.Size(651, 281);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldInternetSalesAmount
            // 
            this.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInternetSalesAmount.AreaIndex = 0;
            this.fieldInternetSalesAmount.Caption = "Sales";
            this.fieldInternetSalesAmount.FieldName = "[Measures].[Internet Sales Amount]";
            this.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount";
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "[Customer].[Country].[Country]";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "[Date].[Fiscal].[Fiscal Year]";
            this.fieldYear.Name = "fieldYear";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemProgressBar1.DisplayFormat.FormatString = "{0}%";
            this.repositoryItemProgressBar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 305);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInternetSalesAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
    }
}


namespace Project_Vispro.View
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewAllEarningBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.budgetingManagementDataSet = new Project_Vispro.BudgetingManagementDataSet();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.titleLabel = new System.Windows.Forms.Label();
            this.viewAllEarningTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.viewAllEarningTableAdapter();
            this.viewAllExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAllExpenseTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.viewAllExpenseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllEarningBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllExpenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllEarningBindingSource1
            // 
            this.viewAllEarningBindingSource1.DataMember = "viewAllEarning";
            this.viewAllEarningBindingSource1.DataSource = this.budgetingManagementDataSet;
            // 
            // budgetingManagementDataSet
            // 
            this.budgetingManagementDataSet.DataSetName = "BudgetingManagementDataSet";
            this.budgetingManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(956, 780);
            this.mainPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.reportViewer1);
            this.rightPanel.Controls.Add(this.titleLabel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(0, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(956, 780);
            this.rightPanel.TabIndex = 2;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ViewAllEarningDataSets";
            reportDataSource1.Value = this.viewAllEarningBindingSource1;
            reportDataSource2.Name = "ViewAllExpenseDataSet";
            reportDataSource2.Value = this.viewAllExpenseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Project_Vispro.View.FinalReport2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 138);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 471);
            this.reportViewer1.TabIndex = 18;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLabel.Location = new System.Drawing.Point(398, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(166, 58);
            this.titleLabel.TabIndex = 17;
            this.titleLabel.Text = "Report";
            // 
            // viewAllEarningTableAdapter
            // 
            this.viewAllEarningTableAdapter.ClearBeforeFill = true;
            // 
            // viewAllExpenseBindingSource
            // 
            this.viewAllExpenseBindingSource.DataMember = "viewAllExpense";
            this.viewAllExpenseBindingSource.DataSource = this.budgetingManagementDataSet;
            // 
            // viewAllExpenseTableAdapter
            // 
            this.viewAllExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 780);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllEarningBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllExpenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label titleLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BudgetingManagementDataSet budgetingManagementDataSet;
        private BudgetingManagementDataSetTableAdapters.viewAllEarningTableAdapter viewAllEarningTableAdapter;
        private System.Windows.Forms.BindingSource viewAllEarningBindingSource1;
        private System.Windows.Forms.BindingSource viewAllExpenseBindingSource;
        private BudgetingManagementDataSetTableAdapters.viewAllExpenseTableAdapter viewAllExpenseTableAdapter;
    }
}
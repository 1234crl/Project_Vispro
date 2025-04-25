namespace Project_Vispro.View
{
    partial class PigetingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.budgetDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addBudgetButton = new System.Windows.Forms.Button();
            this.linePanel = new System.Windows.Forms.Panel();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.viewExpenseBudgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetingManagementDataSet = new Project_Vispro.BudgetingManagementDataSet();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.BudgetTableAdapter();
            this.tableAdapterManager = new Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager();
            this.viewExpenseBudgetTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.viewExpenseBudgetTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewExpenseBudgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.budgetDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.linePanel);
            this.panel1.Controls.Add(this.budgetLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 835);
            this.panel1.TabIndex = 0;
            // 
            // budgetDataGridView
            // 
            this.budgetDataGridView.AllowUserToAddRows = false;
            this.budgetDataGridView.AllowUserToDeleteRows = false;
            this.budgetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.budgetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetDataGridView.Location = new System.Drawing.Point(4, 152);
            this.budgetDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.budgetDataGridView.Name = "budgetDataGridView";
            this.budgetDataGridView.ReadOnly = true;
            this.budgetDataGridView.RowHeadersWidth = 62;
            this.budgetDataGridView.Size = new System.Drawing.Size(1014, 438);
            this.budgetDataGridView.TabIndex = 13;
            this.budgetDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.budgetDataGridView_RowsAdded);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.addBudgetButton);
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 228);
            this.panel2.TabIndex = 12;
            // 
            // addBudgetButton
            // 
            this.addBudgetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBudgetButton.FlatAppearance.BorderSize = 0;
            this.addBudgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBudgetButton.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addBudgetButton.Location = new System.Drawing.Point(864, 18);
            this.addBudgetButton.Name = "addBudgetButton";
            this.addBudgetButton.Size = new System.Drawing.Size(110, 111);
            this.addBudgetButton.TabIndex = 0;
            this.addBudgetButton.UseVisualStyleBackColor = true;
            // 
            // linePanel
            // 
            this.linePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linePanel.Location = new System.Drawing.Point(3, 143);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(956, 0);
            this.linePanel.TabIndex = 10;
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLabel.Location = new System.Drawing.Point(45, 55);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(131, 39);
            this.budgetLabel.TabIndex = 1;
            this.budgetLabel.Text = "Pigeting";
            // 
            // viewExpenseBudgetBindingSource
            // 
            this.viewExpenseBudgetBindingSource.DataMember = "viewExpenseBudget";
            this.viewExpenseBudgetBindingSource.DataSource = this.budgetingManagementDataSet;
            // 
            // budgetingManagementDataSet
            // 
            this.budgetingManagementDataSet.DataSetName = "BudgetingManagementDataSet";
            this.budgetingManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "Budget";
            this.budgetBindingSource.DataSource = this.budgetingManagementDataSet;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = this.budgetTableAdapter;
            this.tableAdapterManager.CategoryExpensesTableAdapter = null;
            this.tableAdapterManager.CategoryIncomesTableAdapter = null;
            this.tableAdapterManager.CategoryPeopleTableAdapter = null;
            this.tableAdapterManager.DetailBudgetTableAdapter = null;
            this.tableAdapterManager.DetailExpensesTableAdapter = null;
            this.tableAdapterManager.DetailIncomeTableAdapter = null;
            this.tableAdapterManager.DetailPigetherTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.PigetherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // viewExpenseBudgetTableAdapter
            // 
            this.viewExpenseBudgetTableAdapter.ClearBeforeFill = true;
            // 
            // PigetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 835);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PigetingForm";
            this.Text = "Budget";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewExpenseBudgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBudgetButton;
        private BudgetingManagementDataSet budgetingManagementDataSet;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private BudgetingManagementDataSetTableAdapters.BudgetTableAdapter budgetTableAdapter;
        private BudgetingManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource viewExpenseBudgetBindingSource;
        private BudgetingManagementDataSetTableAdapters.viewExpenseBudgetTableAdapter viewExpenseBudgetTableAdapter;
        public System.Windows.Forms.DataGridView budgetDataGridView;
    }
}
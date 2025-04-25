namespace Project_Vispro.View
{
    partial class Pigether
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
            this.budgetingManagementDataSet = new Project_Vispro.BudgetingManagementDataSet();
            this.pigetherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pigetherTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.PigetherTableAdapter();
            this.tableAdapterManager = new Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager();
            this.viewDetailButton = new System.Windows.Forms.Button();
            this.addPigetherButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pigetherDataGridView = new System.Windows.Forms.DataGridView();
            this.budgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigetherBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pigetherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetingManagementDataSet
            // 
            this.budgetingManagementDataSet.DataSetName = "BudgetingManagementDataSet";
            this.budgetingManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pigetherBindingSource
            // 
            this.pigetherBindingSource.DataMember = "Pigether";
            this.pigetherBindingSource.DataSource = this.budgetingManagementDataSet;
            // 
            // pigetherTableAdapter
            // 
            this.pigetherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.CategoryExpensesTableAdapter = null;
            this.tableAdapterManager.CategoryIncomesTableAdapter = null;
            this.tableAdapterManager.CategoryPeopleTableAdapter = null;
            this.tableAdapterManager.DetailBudgetTableAdapter = null;
            this.tableAdapterManager.DetailExpensesTableAdapter = null;
            this.tableAdapterManager.DetailIncomeTableAdapter = null;
            this.tableAdapterManager.DetailPigetherTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.PigetherTableAdapter = this.pigetherTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // viewDetailButton
            // 
            this.viewDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDetailButton.BackColor = System.Drawing.Color.Transparent;
            this.viewDetailButton.FlatAppearance.BorderSize = 0;
            this.viewDetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDetailButton.Image = global::Project_Vispro.Properties.Resources.detail_icon;
            this.viewDetailButton.Location = new System.Drawing.Point(55, 30);
            this.viewDetailButton.Name = "viewDetailButton";
            this.viewDetailButton.Size = new System.Drawing.Size(99, 71);
            this.viewDetailButton.TabIndex = 3;
            this.viewDetailButton.UseVisualStyleBackColor = false;
            // 
            // addPigetherButton
            // 
            this.addPigetherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPigetherButton.FlatAppearance.BorderSize = 0;
            this.addPigetherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPigetherButton.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addPigetherButton.Location = new System.Drawing.Point(192, 10);
            this.addPigetherButton.Name = "addPigetherButton";
            this.addPigetherButton.Size = new System.Drawing.Size(110, 111);
            this.addPigetherButton.TabIndex = 1;
            this.addPigetherButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.viewDetailButton);
            this.panel1.Controls.Add(this.addPigetherButton);
            this.panel1.Location = new System.Drawing.Point(615, 572);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 197);
            this.panel1.TabIndex = 4;
            // 
            // pigetherDataGridView
            // 
            this.pigetherDataGridView.AllowUserToAddRows = false;
            this.pigetherDataGridView.AllowUserToDeleteRows = false;
            this.pigetherDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pigetherDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pigetherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pigetherDataGridView.Location = new System.Drawing.Point(1, 126);
            this.pigetherDataGridView.Name = "pigetherDataGridView";
            this.pigetherDataGridView.ReadOnly = true;
            this.pigetherDataGridView.RowHeadersWidth = 62;
            this.pigetherDataGridView.RowTemplate.Height = 28;
            this.pigetherDataGridView.Size = new System.Drawing.Size(987, 401);
            this.pigetherDataGridView.TabIndex = 5;
            this.pigetherDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.pigetherDataGridView_RowsAdded);
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLabel.Location = new System.Drawing.Point(51, 44);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(135, 39);
            this.budgetLabel.TabIndex = 6;
            this.budgetLabel.Text = "Pigether";
            // 
            // Pigether
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.pigetherDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pigether";
            this.Text = "Pigether";
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigetherBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pigetherDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPigetherButton;
        private BudgetingManagementDataSet budgetingManagementDataSet;
        private System.Windows.Forms.BindingSource pigetherBindingSource;
        private BudgetingManagementDataSetTableAdapters.PigetherTableAdapter pigetherTableAdapter;
        private BudgetingManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button viewDetailButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView pigetherDataGridView;
        private System.Windows.Forms.Label budgetLabel;
    }
}
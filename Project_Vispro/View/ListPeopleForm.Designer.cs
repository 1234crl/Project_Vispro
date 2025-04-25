namespace Project_Vispro.View
{
    partial class ListPeopleForm
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
            this.listPeopleLabel = new System.Windows.Forms.Label();
            this.listPeoplePanel = new System.Windows.Forms.Panel();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addPeopleListButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryPeopleDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryPeopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetingManagementDataSet = new Project_Vispro.BudgetingManagementDataSet();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.categoryPeopleTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.CategoryPeopleTableAdapter();
            this.tableAdapterManager = new Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager();
            this.people_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPeoplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPeopleLabel
            // 
            this.listPeopleLabel.AutoSize = true;
            this.listPeopleLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleLabel.Location = new System.Drawing.Point(38, 55);
            this.listPeopleLabel.Name = "listPeopleLabel";
            this.listPeopleLabel.Size = new System.Drawing.Size(169, 39);
            this.listPeopleLabel.TabIndex = 5;
            this.listPeopleLabel.Text = "List People";
            // 
            // listPeoplePanel
            // 
            this.listPeoplePanel.Controls.Add(this.amountNumericUpDown);
            this.listPeoplePanel.Controls.Add(this.addPeopleListButton);
            this.listPeoplePanel.Controls.Add(this.amountLabel);
            this.listPeoplePanel.Controls.Add(this.categoryPeopleDataGridView);
            this.listPeoplePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPeoplePanel.Location = new System.Drawing.Point(0, 0);
            this.listPeoplePanel.Name = "listPeoplePanel";
            this.listPeoplePanel.Size = new System.Drawing.Size(628, 632);
            this.listPeoplePanel.TabIndex = 6;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Font = new System.Drawing.Font("Tahoma", 16F);
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.amountNumericUpDown.Location = new System.Drawing.Point(45, 498);
            this.amountNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(399, 46);
            this.amountNumericUpDown.TabIndex = 4;
            // 
            // addPeopleListButton
            // 
            this.addPeopleListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPeopleListButton.FlatAppearance.BorderSize = 0;
            this.addPeopleListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPeopleListButton.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addPeopleListButton.Location = new System.Drawing.Point(480, 471);
            this.addPeopleListButton.Name = "addPeopleListButton";
            this.addPeopleListButton.Size = new System.Drawing.Size(110, 111);
            this.addPeopleListButton.TabIndex = 3;
            this.addPeopleListButton.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.amountLabel.Location = new System.Drawing.Point(38, 445);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(138, 39);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Amount:";
            // 
            // categoryPeopleDataGridView
            // 
            this.categoryPeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryPeopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.people_id});
            this.categoryPeopleDataGridView.Location = new System.Drawing.Point(0, 99);
            this.categoryPeopleDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryPeopleDataGridView.Name = "categoryPeopleDataGridView";
            this.categoryPeopleDataGridView.RowHeadersWidth = 62;
            this.categoryPeopleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryPeopleDataGridView.Size = new System.Drawing.Size(624, 305);
            this.categoryPeopleDataGridView.TabIndex = 0;
            this.categoryPeopleDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.categoryPeopleDataGridView_RowsAdded);
            // 
            // categoryPeopleBindingSource
            // 
            this.categoryPeopleBindingSource.DataMember = "CategoryPeople";
            this.categoryPeopleBindingSource.DataSource = this.budgetingManagementDataSet;
            // 
            // budgetingManagementDataSet
            // 
            this.budgetingManagementDataSet.DataSetName = "BudgetingManagementDataSet";
            this.budgetingManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(628, 51);
            this.topPanel.TabIndex = 7;
            // 
            // closedButton
            // 
            this.closedButton.FlatAppearance.BorderSize = 0;
            this.closedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedButton.Image = global::Project_Vispro.Properties.Resources.close_icon;
            this.closedButton.Location = new System.Drawing.Point(586, 9);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(34, 29);
            this.closedButton.TabIndex = 0;
            this.closedButton.UseVisualStyleBackColor = true;
            // 
            // categoryPeopleTableAdapter
            // 
            this.categoryPeopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.CategoryExpensesTableAdapter = null;
            this.tableAdapterManager.CategoryIncomesTableAdapter = null;
            this.tableAdapterManager.CategoryPeopleTableAdapter = this.categoryPeopleTableAdapter;
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
            // people_id
            // 
            this.people_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.people_id.DataPropertyName = "people_id";
            this.people_id.HeaderText = "people_id";
            this.people_id.MinimumWidth = 8;
            this.people_id.Name = "people_id";
            this.people_id.ReadOnly = true;
            // 
            // ListPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 632);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.listPeopleLabel);
            this.Controls.Add(this.listPeoplePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListPeopleForm";
            this.Text = "ListPeopleForm";
            this.listPeoplePanel.ResumeLayout(false);
            this.listPeoplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label listPeopleLabel;
        private System.Windows.Forms.Panel listPeoplePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        private BudgetingManagementDataSet budgetingManagementDataSet;
        private System.Windows.Forms.BindingSource categoryPeopleBindingSource;
        private BudgetingManagementDataSetTableAdapters.CategoryPeopleTableAdapter categoryPeopleTableAdapter;
        private BudgetingManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addPeopleListButton;
        public System.Windows.Forms.DataGridView categoryPeopleDataGridView;
        public System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn people_id;
    }
}
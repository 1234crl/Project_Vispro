namespace Project_Vispro.View
{
    partial class PeopleForm
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
            this.peoplePanel = new System.Windows.Forms.Panel();
            this.categoryPeopleDataGridView = new System.Windows.Forms.DataGridView();
            this.categoryPeopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetingManagementDataSet = new Project_Vispro.BudgetingManagementDataSet();
            this.linePanel = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addButon = new System.Windows.Forms.Button();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.categoryPeopleTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.CategoryPeopleTableAdapter();
            this.tableAdapterManager = new Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager();
            this.people_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peoplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).BeginInit();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // peoplePanel
            // 
            this.peoplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peoplePanel.Controls.Add(this.categoryPeopleDataGridView);
            this.peoplePanel.Controls.Add(this.linePanel);
            this.peoplePanel.Controls.Add(this.addPanel);
            this.peoplePanel.Controls.Add(this.peopleLabel);
            this.peoplePanel.Location = new System.Drawing.Point(0, 0);
            this.peoplePanel.Name = "peoplePanel";
            this.peoplePanel.Size = new System.Drawing.Size(1038, 831);
            this.peoplePanel.TabIndex = 0;
            // 
            // categoryPeopleDataGridView
            // 
            this.categoryPeopleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryPeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryPeopleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.people_name});
            this.categoryPeopleDataGridView.Location = new System.Drawing.Point(0, 138);
            this.categoryPeopleDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryPeopleDataGridView.Name = "categoryPeopleDataGridView";
            this.categoryPeopleDataGridView.ReadOnly = true;
            this.categoryPeopleDataGridView.RowHeadersWidth = 62;
            this.categoryPeopleDataGridView.Size = new System.Drawing.Size(1038, 377);
            this.categoryPeopleDataGridView.TabIndex = 11;
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
            // linePanel
            // 
            this.linePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linePanel.Location = new System.Drawing.Point(3, 138);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(956, 0);
            this.linePanel.TabIndex = 11;
            // 
            // addPanel
            // 
            this.addPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPanel.Controls.Add(this.addButon);
            this.addPanel.Location = new System.Drawing.Point(0, 523);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(1038, 308);
            this.addPanel.TabIndex = 2;
            // 
            // addButon
            // 
            this.addButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButon.FlatAppearance.BorderSize = 0;
            this.addButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButon.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addButon.Location = new System.Drawing.Point(842, 86);
            this.addButon.Name = "addButon";
            this.addButon.Size = new System.Drawing.Size(146, 109);
            this.addButon.TabIndex = 3;
            this.addButon.UseVisualStyleBackColor = true;
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleLabel.Location = new System.Drawing.Point(45, 55);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(111, 39);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "People";
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
            // people_name
            // 
            this.people_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.people_name.DataPropertyName = "people_name";
            this.people_name.HeaderText = "people_name";
            this.people_name.MinimumWidth = 8;
            this.people_name.Name = "people_name";
            this.people_name.ReadOnly = true;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 818);
            this.Controls.Add(this.peoplePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeopleForm";
            this.Text = "PeopleForm";
            this.peoplePanel.ResumeLayout(false);
            this.peoplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryPeopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel peoplePanel;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addButon;
        private System.Windows.Forms.Panel linePanel;
        private BudgetingManagementDataSet budgetingManagementDataSet;
        private System.Windows.Forms.BindingSource categoryPeopleBindingSource;
        private BudgetingManagementDataSetTableAdapters.CategoryPeopleTableAdapter categoryPeopleTableAdapter;
        private BudgetingManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.DataGridView categoryPeopleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn people_name;
    }
}
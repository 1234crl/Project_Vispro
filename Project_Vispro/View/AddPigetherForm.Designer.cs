namespace Project_Vispro.View
{
    partial class AddPigetherForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pigetterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpLabel = new System.Windows.Forms.Label();
            this.pigetherPanel = new System.Windows.Forms.Panel();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.savePigetherButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.addPeoplePigetherButton = new System.Windows.Forms.Button();
            this.detailPigetherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetingManagementDataSet = new Project_Vispro.BudgetingManagementDataSet();
            this.detailPigetherTableAdapter = new Project_Vispro.BudgetingManagementDataSetTableAdapters.DetailPigetherTableAdapter();
            this.tableAdapterManager = new Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager();
            this.pigetherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailPigetherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.nameTextBox.Location = new System.Drawing.Point(77, 94);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(317, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // pigetterTextBox
            // 
            this.pigetterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pigetterTextBox.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigetterTextBox.ForeColor = System.Drawing.Color.Silver;
            this.pigetterTextBox.Location = new System.Drawing.Point(77, 172);
            this.pigetterTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pigetterTextBox.Name = "pigetterTextBox";
            this.pigetterTextBox.Size = new System.Drawing.Size(317, 26);
            this.pigetterTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add people";
            // 
            // rpLabel
            // 
            this.rpLabel.AutoSize = true;
            this.rpLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpLabel.Location = new System.Drawing.Point(29, 172);
            this.rpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rpLabel.Name = "rpLabel";
            this.rpLabel.Size = new System.Drawing.Size(45, 27);
            this.rpLabel.TabIndex = 6;
            this.rpLabel.Text = "Rp.";
            // 
            // pigetherPanel
            // 
            this.pigetherPanel.Controls.Add(this.peopleDataGridView);
            this.pigetherPanel.Controls.Add(this.savePigetherButton);
            this.pigetherPanel.Controls.Add(this.label3);
            this.pigetherPanel.Controls.Add(this.label2);
            this.pigetherPanel.Controls.Add(this.nameTextBox);
            this.pigetherPanel.Controls.Add(this.rpLabel);
            this.pigetherPanel.Controls.Add(this.topPanel);
            this.pigetherPanel.Controls.Add(this.pigetterTextBox);
            this.pigetherPanel.Controls.Add(this.label1);
            this.pigetherPanel.Controls.Add(this.addPeoplePigetherButton);
            this.pigetherPanel.Location = new System.Drawing.Point(-2, -1);
            this.pigetherPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pigetherPanel.Name = "pigetherPanel";
            this.pigetherPanel.Size = new System.Drawing.Size(424, 439);
            this.pigetherPanel.TabIndex = 7;
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Location = new System.Drawing.Point(34, 213);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.Size = new System.Drawing.Size(278, 156);
            this.peopleDataGridView.TabIndex = 10;
            // 
            // savePigetherButton
            // 
            this.savePigetherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.savePigetherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePigetherButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePigetherButton.Location = new System.Drawing.Point(34, 385);
            this.savePigetherButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePigetherButton.Name = "savePigetherButton";
            this.savePigetherButton.Size = new System.Drawing.Size(369, 43);
            this.savePigetherButton.TabIndex = 9;
            this.savePigetherButton.Text = "Save";
            this.savePigetherButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(72, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(72, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pigether\'s Name";
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Location = new System.Drawing.Point(2, 2);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(422, 33);
            this.topPanel.TabIndex = 6;
            // 
            // closedButton
            // 
            this.closedButton.FlatAppearance.BorderSize = 0;
            this.closedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedButton.Image = global::Project_Vispro.Properties.Resources.close_icon;
            this.closedButton.Location = new System.Drawing.Point(391, 6);
            this.closedButton.Margin = new System.Windows.Forms.Padding(2);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(23, 19);
            this.closedButton.TabIndex = 0;
            this.closedButton.UseVisualStyleBackColor = true;
            // 
            // addPeoplePigetherButton
            // 
            this.addPeoplePigetherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPeoplePigetherButton.FlatAppearance.BorderSize = 0;
            this.addPeoplePigetherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPeoplePigetherButton.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addPeoplePigetherButton.Location = new System.Drawing.Point(330, 252);
            this.addPeoplePigetherButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPeoplePigetherButton.Name = "addPeoplePigetherButton";
            this.addPeoplePigetherButton.Size = new System.Drawing.Size(73, 72);
            this.addPeoplePigetherButton.TabIndex = 2;
            this.addPeoplePigetherButton.UseVisualStyleBackColor = true;
            // 
            // detailPigetherBindingSource
            // 
            this.detailPigetherBindingSource.DataMember = "DetailPigether";
            this.detailPigetherBindingSource.DataSource = this.budgetingManagementDataSet;
            // 
            // budgetingManagementDataSet
            // 
            this.budgetingManagementDataSet.DataSetName = "BudgetingManagementDataSet";
            this.budgetingManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailPigetherTableAdapter
            // 
            this.detailPigetherTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DetailPigetherTableAdapter = this.detailPigetherTableAdapter;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.PigetherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project_Vispro.BudgetingManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // AddPigetherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 438);
            this.Controls.Add(this.pigetherPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPigetherForm";
            this.Text = "AddPigetherForm";
            this.Load += new System.EventHandler(this.AddPigetherForm_Load);
            this.pigetherPanel.ResumeLayout(false);
            this.pigetherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailPigetherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetingManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addPeoplePigetherButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rpLabel;
        private System.Windows.Forms.Panel pigetherPanel;
        private BudgetingManagementDataSet budgetingManagementDataSet;
        private System.Windows.Forms.BindingSource detailPigetherBindingSource;
        private BudgetingManagementDataSetTableAdapters.DetailPigetherTableAdapter detailPigetherTableAdapter;
        private BudgetingManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savePigetherButton;
        public System.Windows.Forms.DataGridView peopleDataGridView;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox pigetterTextBox;
    }
}
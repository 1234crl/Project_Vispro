namespace Project_Vispro.View
{
    partial class AddExpenseForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoryExpenseComboBox = new System.Windows.Forms.ComboBox();
            this.addExpenseButon = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addEarningLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Location = new System.Drawing.Point(1, -1);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(457, 33);
            this.topPanel.TabIndex = 8;
            // 
            // closedButton
            // 
            this.closedButton.FlatAppearance.BorderSize = 0;
            this.closedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedButton.Image = global::Project_Vispro.Properties.Resources.close_icon;
            this.closedButton.Location = new System.Drawing.Point(423, 8);
            this.closedButton.Margin = new System.Windows.Forms.Padding(2);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(23, 19);
            this.closedButton.TabIndex = 0;
            this.closedButton.UseVisualStyleBackColor = true;
            // 
            // addPanel
            // 
            this.addPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPanel.Controls.Add(this.categoryLabel);
            this.addPanel.Controls.Add(this.amountNumericUpDown);
            this.addPanel.Controls.Add(this.categoryExpenseComboBox);
            this.addPanel.Controls.Add(this.addExpenseButon);
            this.addPanel.Controls.Add(this.amountLabel);
            this.addPanel.Controls.Add(this.addEarningLabel);
            this.addPanel.Location = new System.Drawing.Point(-1, 31);
            this.addPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(457, 427);
            this.addPanel.TabIndex = 9;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.categoryLabel.Location = new System.Drawing.Point(30, 71);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(107, 27);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.amountNumericUpDown.Location = new System.Drawing.Point(35, 185);
            this.amountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(385, 28);
            this.amountNumericUpDown.TabIndex = 7;
            // 
            // categoryExpenseComboBox
            // 
            this.categoryExpenseComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryExpenseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryExpenseComboBox.FormattingEnabled = true;
            this.categoryExpenseComboBox.Location = new System.Drawing.Point(35, 106);
            this.categoryExpenseComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryExpenseComboBox.Name = "categoryExpenseComboBox";
            this.categoryExpenseComboBox.Size = new System.Drawing.Size(387, 33);
            this.categoryExpenseComboBox.TabIndex = 6;
            // 
            // addExpenseButon
            // 
            this.addExpenseButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.addExpenseButon.FlatAppearance.BorderSize = 0;
            this.addExpenseButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseButon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseButon.Location = new System.Drawing.Point(35, 352);
            this.addExpenseButon.Margin = new System.Windows.Forms.Padding(2);
            this.addExpenseButon.Name = "addExpenseButon";
            this.addExpenseButon.Size = new System.Drawing.Size(76, 42);
            this.addExpenseButon.TabIndex = 5;
            this.addExpenseButon.Text = "Add";
            this.addExpenseButon.UseVisualStyleBackColor = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.amountLabel.Location = new System.Drawing.Point(30, 150);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(94, 27);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount:";
            // 
            // addEarningLabel
            // 
            this.addEarningLabel.AutoSize = true;
            this.addEarningLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEarningLabel.Location = new System.Drawing.Point(30, 20);
            this.addEarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addEarningLabel.Name = "addEarningLabel";
            this.addEarningLabel.Size = new System.Drawing.Size(137, 27);
            this.addEarningLabel.TabIndex = 2;
            this.addEarningLabel.Text = "Add Expense";
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 458);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddExpenseForm";
            this.Text = "Expense";
            this.topPanel.ResumeLayout(false);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addExpenseButon;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label addEarningLabel;
        public System.Windows.Forms.ComboBox categoryExpenseComboBox;
        public System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}
namespace Project_Vispro.View
{
    partial class AddSavingsForm
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
            this.savingPanel = new System.Windows.Forms.Panel();
            this.savingsTextBox = new System.Windows.Forms.TextBox();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.savinglabel = new System.Windows.Forms.Label();
            this.moneyPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addSavingsButon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.withdrawSavingsRadioButton = new System.Windows.Forms.RadioButton();
            this.depositSavingsRadioButton = new System.Windows.Forms.RadioButton();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.savingPanel.SuspendLayout();
            this.moneyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // savingPanel
            // 
            this.savingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingPanel.Controls.Add(this.savingsTextBox);
            this.savingPanel.Controls.Add(this.savingsLabel);
            this.savingPanel.Controls.Add(this.savinglabel);
            this.savingPanel.Location = new System.Drawing.Point(239, 51);
            this.savingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.savingPanel.Name = "savingPanel";
            this.savingPanel.Size = new System.Drawing.Size(207, 110);
            this.savingPanel.TabIndex = 7;
            // 
            // savingsTextBox
            // 
            this.savingsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.savingsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savingsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsTextBox.Location = new System.Drawing.Point(64, 40);
            this.savingsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.savingsTextBox.Name = "savingsTextBox";
            this.savingsTextBox.ReadOnly = true;
            this.savingsTextBox.Size = new System.Drawing.Size(102, 25);
            this.savingsTextBox.TabIndex = 10;
            this.savingsTextBox.Text = "AA";
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.Location = new System.Drawing.Point(10, 6);
            this.savingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(44, 13);
            this.savingsLabel.TabIndex = 4;
            this.savingsLabel.Text = "Savings";
            // 
            // savinglabel
            // 
            this.savinglabel.AutoSize = true;
            this.savinglabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savinglabel.Location = new System.Drawing.Point(29, 38);
            this.savinglabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savinglabel.Name = "savinglabel";
            this.savinglabel.Size = new System.Drawing.Size(38, 27);
            this.savinglabel.TabIndex = 2;
            this.savinglabel.Text = "Rp";
            // 
            // moneyPanel
            // 
            this.moneyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyPanel.Controls.Add(this.label1);
            this.moneyPanel.Controls.Add(this.accountTextBox);
            this.moneyPanel.Controls.Add(this.moneyLabel);
            this.moneyPanel.Location = new System.Drawing.Point(20, 51);
            this.moneyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.moneyPanel.Name = "moneyPanel";
            this.moneyPanel.Size = new System.Drawing.Size(207, 110);
            this.moneyPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Balance";
            // 
            // accountTextBox
            // 
            this.accountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.Location = new System.Drawing.Point(60, 40);
            this.accountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.ReadOnly = true;
            this.accountTextBox.Size = new System.Drawing.Size(102, 25);
            this.accountTextBox.TabIndex = 0;
            this.accountTextBox.Text = "..";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(25, 40);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(45, 27);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Rp ";
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
            this.amountNumericUpDown.Location = new System.Drawing.Point(23, 281);
            this.amountNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(423, 28);
            this.amountNumericUpDown.TabIndex = 9;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.amountLabel.Location = new System.Drawing.Point(18, 252);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(94, 27);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount:";
            // 
            // addSavingsButon
            // 
            this.addSavingsButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.addSavingsButon.FlatAppearance.BorderSize = 0;
            this.addSavingsButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSavingsButon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSavingsButon.Location = new System.Drawing.Point(20, 403);
            this.addSavingsButon.Margin = new System.Windows.Forms.Padding(2);
            this.addSavingsButon.Name = "addSavingsButon";
            this.addSavingsButon.Size = new System.Drawing.Size(426, 42);
            this.addSavingsButon.TabIndex = 10;
            this.addSavingsButon.Text = "Add";
            this.addSavingsButon.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.moneyPanel);
            this.panel1.Controls.Add(this.savingPanel);
            this.panel1.Controls.Add(this.amountNumericUpDown);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.addSavingsButon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 475);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.withdrawSavingsRadioButton);
            this.panel2.Controls.Add(this.depositSavingsRadioButton);
            this.panel2.Location = new System.Drawing.Point(12, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 61);
            this.panel2.TabIndex = 14;
            // 
            // withdrawSavingsRadioButton
            // 
            this.withdrawSavingsRadioButton.AutoSize = true;
            this.withdrawSavingsRadioButton.Checked = true;
            this.withdrawSavingsRadioButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.withdrawSavingsRadioButton.Location = new System.Drawing.Point(8, 15);
            this.withdrawSavingsRadioButton.Name = "withdrawSavingsRadioButton";
            this.withdrawSavingsRadioButton.Size = new System.Drawing.Size(203, 31);
            this.withdrawSavingsRadioButton.TabIndex = 11;
            this.withdrawSavingsRadioButton.TabStop = true;
            this.withdrawSavingsRadioButton.Text = "Withdraw Savings";
            this.withdrawSavingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // depositSavingsRadioButton
            // 
            this.depositSavingsRadioButton.AutoSize = true;
            this.depositSavingsRadioButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.depositSavingsRadioButton.Location = new System.Drawing.Point(227, 15);
            this.depositSavingsRadioButton.Name = "depositSavingsRadioButton";
            this.depositSavingsRadioButton.Size = new System.Drawing.Size(184, 31);
            this.depositSavingsRadioButton.TabIndex = 12;
            this.depositSavingsRadioButton.Text = "Deposit Savings";
            this.depositSavingsRadioButton.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(465, 33);
            this.topPanel.TabIndex = 12;
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
            // AddSavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 475);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddSavingsForm";
            this.Text = "AddSavings";
            this.savingPanel.ResumeLayout(false);
            this.savingPanel.PerformLayout();
            this.moneyPanel.ResumeLayout(false);
            this.moneyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel savingPanel;
        public System.Windows.Forms.TextBox savingsTextBox;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label savinglabel;
        private System.Windows.Forms.Panel moneyPanel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addSavingsButon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton depositSavingsRadioButton;
        public System.Windows.Forms.RadioButton withdrawSavingsRadioButton;
        public System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}
namespace Project_Vispro.View
{
    partial class HomeForm
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
            this.homePanel = new System.Windows.Forms.Panel();
            this.expenseButton = new System.Windows.Forms.Button();
            this.earningsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pengeluaranPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pengeluaranLabel1 = new System.Windows.Forms.Label();
            this.pengeluaranlabel = new System.Windows.Forms.Label();
            this.pendapatanPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pendapatanLabel1 = new System.Windows.Forms.Label();
            this.pendapatanLabel = new System.Windows.Forms.Label();
            this.moneyPanel = new System.Windows.Forms.Panel();
            this.akunSaldoTb = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.homePanel.SuspendLayout();
            this.pengeluaranPanel.SuspendLayout();
            this.pendapatanPanel.SuspendLayout();
            this.moneyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePanel.BackColor = System.Drawing.SystemColors.Control;
            this.homePanel.Controls.Add(this.expenseButton);
            this.homePanel.Controls.Add(this.earningsButton);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.pengeluaranPanel);
            this.homePanel.Controls.Add(this.pendapatanPanel);
            this.homePanel.Controls.Add(this.moneyPanel);
            this.homePanel.Controls.Add(this.accountLabel);
            this.homePanel.Controls.Add(this.addButton);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(988, 829);
            this.homePanel.TabIndex = 0;
            // 
            // expenseButton
            // 
            this.expenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.expenseButton.Enabled = false;
            this.expenseButton.FlatAppearance.BorderSize = 0;
            this.expenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseButton.Location = new System.Drawing.Point(678, 583);
            this.expenseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expenseButton.Name = "expenseButton";
            this.expenseButton.Size = new System.Drawing.Size(154, 45);
            this.expenseButton.TabIndex = 9;
            this.expenseButton.Text = "Expense";
            this.expenseButton.UseMnemonic = false;
            this.expenseButton.UseVisualStyleBackColor = false;
            this.expenseButton.Visible = false;
            // 
            // earningsButton
            // 
            this.earningsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.earningsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.earningsButton.Enabled = false;
            this.earningsButton.FlatAppearance.BorderSize = 0;
            this.earningsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.earningsButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsButton.Location = new System.Drawing.Point(678, 538);
            this.earningsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.earningsButton.Name = "earningsButton";
            this.earningsButton.Size = new System.Drawing.Size(154, 45);
            this.earningsButton.TabIndex = 8;
            this.earningsButton.Text = "Earnings";
            this.earningsButton.UseVisualStyleBackColor = false;
            this.earningsButton.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "This Month";
            // 
            // pengeluaranPanel
            // 
            this.pengeluaranPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pengeluaranPanel.Controls.Add(this.label3);
            this.pengeluaranPanel.Controls.Add(this.pengeluaranLabel1);
            this.pengeluaranPanel.Controls.Add(this.pengeluaranlabel);
            this.pengeluaranPanel.Location = new System.Drawing.Point(502, 389);
            this.pengeluaranPanel.Name = "pengeluaranPanel";
            this.pengeluaranPanel.Size = new System.Drawing.Size(310, 168);
            this.pengeluaranPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rp";
            // 
            // pengeluaranLabel1
            // 
            this.pengeluaranLabel1.AutoSize = true;
            this.pengeluaranLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaranLabel1.Location = new System.Drawing.Point(18, 15);
            this.pengeluaranLabel1.Name = "pengeluaranLabel1";
            this.pengeluaranLabel1.Size = new System.Drawing.Size(74, 19);
            this.pengeluaranLabel1.TabIndex = 4;
            this.pengeluaranLabel1.Text = "Expenses";
            // 
            // pengeluaranlabel
            // 
            this.pengeluaranlabel.AutoSize = true;
            this.pengeluaranlabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaranlabel.Location = new System.Drawing.Point(93, 62);
            this.pengeluaranlabel.Name = "pengeluaranlabel";
            this.pengeluaranlabel.Size = new System.Drawing.Size(112, 39);
            this.pengeluaranlabel.TabIndex = 2;
            this.pengeluaranlabel.Text = "00.000";
            // 
            // pendapatanPanel
            // 
            this.pendapatanPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendapatanPanel.Controls.Add(this.label2);
            this.pendapatanPanel.Controls.Add(this.pendapatanLabel1);
            this.pendapatanPanel.Controls.Add(this.pendapatanLabel);
            this.pendapatanPanel.Location = new System.Drawing.Point(66, 389);
            this.pendapatanPanel.Name = "pendapatanPanel";
            this.pendapatanPanel.Size = new System.Drawing.Size(310, 168);
            this.pendapatanPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rp";
            // 
            // pendapatanLabel1
            // 
            this.pendapatanLabel1.AutoSize = true;
            this.pendapatanLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendapatanLabel1.Location = new System.Drawing.Point(16, 15);
            this.pendapatanLabel1.Name = "pendapatanLabel1";
            this.pendapatanLabel1.Size = new System.Drawing.Size(70, 19);
            this.pendapatanLabel1.TabIndex = 3;
            this.pendapatanLabel1.Text = "Earnings";
            // 
            // pendapatanLabel
            // 
            this.pendapatanLabel.AutoSize = true;
            this.pendapatanLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendapatanLabel.Location = new System.Drawing.Point(88, 62);
            this.pendapatanLabel.Name = "pendapatanLabel";
            this.pendapatanLabel.Size = new System.Drawing.Size(112, 39);
            this.pendapatanLabel.TabIndex = 2;
            this.pendapatanLabel.Text = "00.000";
            // 
            // moneyPanel
            // 
            this.moneyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyPanel.Controls.Add(this.akunSaldoTb);
            this.moneyPanel.Controls.Add(this.showButton);
            this.moneyPanel.Controls.Add(this.moneyLabel);
            this.moneyPanel.Location = new System.Drawing.Point(66, 94);
            this.moneyPanel.Name = "moneyPanel";
            this.moneyPanel.Size = new System.Drawing.Size(310, 168);
            this.moneyPanel.TabIndex = 3;
            // 
            // akunSaldoTb
            // 
            this.akunSaldoTb.BackColor = System.Drawing.SystemColors.Control;
            this.akunSaldoTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.akunSaldoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akunSaldoTb.Location = new System.Drawing.Point(100, 62);
            this.akunSaldoTb.Name = "akunSaldoTb";
            this.akunSaldoTb.ReadOnly = true;
            this.akunSaldoTb.Size = new System.Drawing.Size(146, 37);
            this.akunSaldoTb.TabIndex = 4;
            this.akunSaldoTb.Text = "..";
            this.akunSaldoTb.UseSystemPasswordChar = true;
            // 
            // showButton
            // 
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Image = global::Project_Vispro.Properties.Resources.show_icon1;
            this.showButton.Location = new System.Drawing.Point(260, 122);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(27, 28);
            this.showButton.TabIndex = 3;
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(38, 62);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(55, 39);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Rp";
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(58, 43);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(130, 39);
            this.accountLabel.TabIndex = 1;
            this.accountLabel.Text = "Account";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addButton.Location = new System.Drawing.Point(824, 591);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 95);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 788);
            this.Controls.Add(this.homePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.pengeluaranPanel.ResumeLayout(false);
            this.pengeluaranPanel.PerformLayout();
            this.pendapatanPanel.ResumeLayout(false);
            this.pendapatanPanel.PerformLayout();
            this.moneyPanel.ResumeLayout(false);
            this.moneyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel moneyPanel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Panel pendapatanPanel;
        private System.Windows.Forms.Panel pengeluaranPanel;
        private System.Windows.Forms.Label pendapatanLabel1;
        private System.Windows.Forms.Label pengeluaranLabel1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button expenseButton;
        public System.Windows.Forms.Button earningsButton;
        public System.Windows.Forms.TextBox akunSaldoTb;
        public System.Windows.Forms.Label pendapatanLabel;
        public System.Windows.Forms.Label pengeluaranlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
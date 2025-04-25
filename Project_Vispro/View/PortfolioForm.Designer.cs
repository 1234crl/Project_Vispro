namespace Project_Vispro.View
{
    partial class PortfolioForm
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
            this.accountLabel = new System.Windows.Forms.Label();
            this.moneyPanel = new System.Windows.Forms.Panel();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.showAccountButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moreLabel = new System.Windows.Forms.Label();
            this.savingPanel = new System.Windows.Forms.Panel();
            this.editSavings = new System.Windows.Forms.Button();
            this.savingsTextBox = new System.Windows.Forms.TextBox();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.showSavingsButton = new System.Windows.Forms.Button();
            this.savinglabel = new System.Windows.Forms.Label();
            this.totalpanel = new System.Windows.Forms.Panel();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.showTotalButton = new System.Windows.Forms.Button();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.piGetingButton = new System.Windows.Forms.Button();
            this.piGetherButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.moneyPanel.SuspendLayout();
            this.savingPanel.SuspendLayout();
            this.totalpanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(58, 43);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(130, 39);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Account";
            // 
            // moneyPanel
            // 
            this.moneyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyPanel.Controls.Add(this.accountTextBox);
            this.moneyPanel.Controls.Add(this.showAccountButton);
            this.moneyPanel.Controls.Add(this.moneyLabel);
            this.moneyPanel.Location = new System.Drawing.Point(66, 94);
            this.moneyPanel.Name = "moneyPanel";
            this.moneyPanel.Size = new System.Drawing.Size(310, 168);
            this.moneyPanel.TabIndex = 4;
            // 
            // accountTextBox
            // 
            this.accountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.Location = new System.Drawing.Point(90, 65);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.ReadOnly = true;
            this.accountTextBox.Size = new System.Drawing.Size(153, 37);
            this.accountTextBox.TabIndex = 0;
            this.accountTextBox.Text = "..";
            this.accountTextBox.UseSystemPasswordChar = true;
            // 
            // showAccountButton
            // 
            this.showAccountButton.FlatAppearance.BorderSize = 0;
            this.showAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAccountButton.Image = global::Project_Vispro.Properties.Resources.show_icon1;
            this.showAccountButton.Location = new System.Drawing.Point(260, 122);
            this.showAccountButton.Name = "showAccountButton";
            this.showAccountButton.Size = new System.Drawing.Size(27, 28);
            this.showAccountButton.TabIndex = 3;
            this.showAccountButton.UseVisualStyleBackColor = true;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(38, 62);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(65, 39);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Rp ";
            // 
            // moreLabel
            // 
            this.moreLabel.AutoSize = true;
            this.moreLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreLabel.Location = new System.Drawing.Point(58, 297);
            this.moreLabel.Name = "moreLabel";
            this.moreLabel.Size = new System.Drawing.Size(88, 39);
            this.moreLabel.TabIndex = 5;
            this.moreLabel.Text = "More";
            // 
            // savingPanel
            // 
            this.savingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingPanel.Controls.Add(this.editSavings);
            this.savingPanel.Controls.Add(this.savingsTextBox);
            this.savingPanel.Controls.Add(this.savingsLabel);
            this.savingPanel.Controls.Add(this.showSavingsButton);
            this.savingPanel.Controls.Add(this.savinglabel);
            this.savingPanel.Location = new System.Drawing.Point(66, 355);
            this.savingPanel.Name = "savingPanel";
            this.savingPanel.Size = new System.Drawing.Size(310, 127);
            this.savingPanel.TabIndex = 5;
            // 
            // editSavings
            // 
            this.editSavings.FlatAppearance.BorderSize = 0;
            this.editSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSavings.Image = global::Project_Vispro.Properties.Resources.Edit;
            this.editSavings.Location = new System.Drawing.Point(260, 25);
            this.editSavings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editSavings.Name = "editSavings";
            this.editSavings.Size = new System.Drawing.Size(30, 31);
            this.editSavings.TabIndex = 9;
            this.editSavings.UseVisualStyleBackColor = true;
            // 
            // savingsTextBox
            // 
            this.savingsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.savingsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savingsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsTextBox.Location = new System.Drawing.Point(90, 67);
            this.savingsTextBox.Name = "savingsTextBox";
            this.savingsTextBox.ReadOnly = true;
            this.savingsTextBox.Size = new System.Drawing.Size(153, 37);
            this.savingsTextBox.TabIndex = 10;
            this.savingsTextBox.Text = "AA";
            this.savingsTextBox.UseSystemPasswordChar = true;
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsLabel.Location = new System.Drawing.Point(15, 9);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(63, 19);
            this.savingsLabel.TabIndex = 4;
            this.savingsLabel.Text = "Savings";
            // 
            // showSavingsButton
            // 
            this.showSavingsButton.FlatAppearance.BorderSize = 0;
            this.showSavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSavingsButton.Image = global::Project_Vispro.Properties.Resources.show_icon1;
            this.showSavingsButton.Location = new System.Drawing.Point(260, 77);
            this.showSavingsButton.Name = "showSavingsButton";
            this.showSavingsButton.Size = new System.Drawing.Size(27, 28);
            this.showSavingsButton.TabIndex = 3;
            this.showSavingsButton.UseVisualStyleBackColor = true;
            // 
            // savinglabel
            // 
            this.savinglabel.AutoSize = true;
            this.savinglabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savinglabel.Location = new System.Drawing.Point(38, 63);
            this.savinglabel.Name = "savinglabel";
            this.savinglabel.Size = new System.Drawing.Size(55, 39);
            this.savinglabel.TabIndex = 2;
            this.savinglabel.Text = "Rp";
            // 
            // totalpanel
            // 
            this.totalpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalpanel.Controls.Add(this.totalTextBox);
            this.totalpanel.Controls.Add(this.totalLabel);
            this.totalpanel.Controls.Add(this.showTotalButton);
            this.totalpanel.Controls.Add(this.totalsLabel);
            this.totalpanel.Location = new System.Drawing.Point(423, 355);
            this.totalpanel.Name = "totalpanel";
            this.totalpanel.Size = new System.Drawing.Size(310, 127);
            this.totalpanel.TabIndex = 6;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(88, 66);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(153, 37);
            this.totalTextBox.TabIndex = 10;
            this.totalTextBox.Text = "..";
            this.totalTextBox.UseSystemPasswordChar = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(15, 9);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(45, 19);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total";
            // 
            // showTotalButton
            // 
            this.showTotalButton.FlatAppearance.BorderSize = 0;
            this.showTotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTotalButton.Image = global::Project_Vispro.Properties.Resources.show_icon1;
            this.showTotalButton.Location = new System.Drawing.Point(264, 77);
            this.showTotalButton.Name = "showTotalButton";
            this.showTotalButton.Size = new System.Drawing.Size(27, 28);
            this.showTotalButton.TabIndex = 3;
            this.showTotalButton.UseVisualStyleBackColor = true;
            // 
            // totalsLabel
            // 
            this.totalsLabel.AutoSize = true;
            this.totalsLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(36, 63);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(65, 39);
            this.totalsLabel.TabIndex = 2;
            this.totalsLabel.Text = "Rp ";
            // 
            // piGetingButton
            // 
            this.piGetingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.piGetingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.piGetingButton.FlatAppearance.BorderSize = 0;
            this.piGetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piGetingButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piGetingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.piGetingButton.Location = new System.Drawing.Point(68, 543);
            this.piGetingButton.Name = "piGetingButton";
            this.piGetingButton.Size = new System.Drawing.Size(814, 60);
            this.piGetingButton.TabIndex = 7;
            this.piGetingButton.Text = "PiGeting";
            this.piGetingButton.UseVisualStyleBackColor = false;
            // 
            // piGetherButton
            // 
            this.piGetherButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.piGetherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.piGetherButton.FlatAppearance.BorderSize = 0;
            this.piGetherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piGetherButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piGetherButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.piGetherButton.Location = new System.Drawing.Point(68, 635);
            this.piGetherButton.Name = "piGetherButton";
            this.piGetherButton.Size = new System.Drawing.Size(814, 60);
            this.piGetherButton.TabIndex = 8;
            this.piGetherButton.Text = "PiGether";
            this.piGetherButton.UseVisualStyleBackColor = false;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.panel1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(956, 780);
            this.homePanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 780);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.piGetherButton);
            this.panel2.Controls.Add(this.totalpanel);
            this.panel2.Controls.Add(this.piGetingButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 780);
            this.panel2.TabIndex = 11;
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 780);
            this.Controls.Add(this.savingPanel);
            this.Controls.Add(this.moreLabel);
            this.Controls.Add(this.moneyPanel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.homePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PortfolioForm";
            this.Text = "Portfolio";
            this.moneyPanel.ResumeLayout(false);
            this.moneyPanel.PerformLayout();
            this.savingPanel.ResumeLayout(false);
            this.savingPanel.PerformLayout();
            this.totalpanel.ResumeLayout(false);
            this.totalpanel.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Panel moneyPanel;
        private System.Windows.Forms.Button showAccountButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label moreLabel;
        private System.Windows.Forms.Panel savingPanel;
        private System.Windows.Forms.Button showSavingsButton;
        private System.Windows.Forms.Label savinglabel;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Panel totalpanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button showTotalButton;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Button piGetingButton;
        private System.Windows.Forms.Button piGetherButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox accountTextBox;
        public System.Windows.Forms.TextBox savingsTextBox;
        public System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button editSavings;
    }
}
namespace Project_Vispro.View
{
    partial class AddEarningForm
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoryEarningCb = new System.Windows.Forms.ComboBox();
            this.addEarningButon = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addEarningLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.categoryLabel);
            this.addPanel.Controls.Add(this.amountNumericUpDown);
            this.addPanel.Controls.Add(this.categoryEarningCb);
            this.addPanel.Controls.Add(this.addEarningButon);
            this.addPanel.Controls.Add(this.amountLabel);
            this.addPanel.Controls.Add(this.addEarningLabel);
            this.addPanel.Location = new System.Drawing.Point(2, 49);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(686, 657);
            this.addPanel.TabIndex = 8;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.categoryLabel.Location = new System.Drawing.Point(45, 109);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(155, 39);
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
            this.amountNumericUpDown.Location = new System.Drawing.Point(52, 285);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(578, 40);
            this.amountNumericUpDown.TabIndex = 7;
            // 
            // categoryEarningCb
            // 
            this.categoryEarningCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryEarningCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryEarningCb.FormattingEnabled = true;
            this.categoryEarningCb.Location = new System.Drawing.Point(52, 163);
            this.categoryEarningCb.Name = "categoryEarningCb";
            this.categoryEarningCb.Size = new System.Drawing.Size(578, 45);
            this.categoryEarningCb.TabIndex = 6;
            // 
            // addEarningButon
            // 
            this.addEarningButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.addEarningButon.FlatAppearance.BorderSize = 0;
            this.addEarningButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEarningButon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEarningButon.Location = new System.Drawing.Point(52, 542);
            this.addEarningButon.Name = "addEarningButon";
            this.addEarningButon.Size = new System.Drawing.Size(114, 65);
            this.addEarningButon.TabIndex = 5;
            this.addEarningButon.Text = "Add";
            this.addEarningButon.UseVisualStyleBackColor = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.amountLabel.Location = new System.Drawing.Point(45, 231);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(138, 39);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount:";
            // 
            // addEarningLabel
            // 
            this.addEarningLabel.AutoSize = true;
            this.addEarningLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEarningLabel.Location = new System.Drawing.Point(45, 31);
            this.addEarningLabel.Name = "addEarningLabel";
            this.addEarningLabel.Size = new System.Drawing.Size(190, 39);
            this.addEarningLabel.TabIndex = 2;
            this.addEarningLabel.Text = "Add Earning";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(686, 51);
            this.topPanel.TabIndex = 9;
            // 
            // closedButton
            // 
            this.closedButton.FlatAppearance.BorderSize = 0;
            this.closedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedButton.Image = global::Project_Vispro.Properties.Resources.close_icon;
            this.closedButton.Location = new System.Drawing.Point(634, 12);
            this.closedButton.Name = "closedButton";
            this.closedButton.Size = new System.Drawing.Size(34, 29);
            this.closedButton.TabIndex = 0;
            this.closedButton.UseVisualStyleBackColor = true;
            // 
            // AddEarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 705);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEarningForm";
            this.Text = "Earning";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addEarningButon;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label addEarningLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.Label categoryLabel;
        public System.Windows.Forms.ComboBox categoryEarningCb;
        public System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}
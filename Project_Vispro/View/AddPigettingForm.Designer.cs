namespace Project_Vispro.View
{
    partial class AddPigettingForm
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
            this.pigettingComboBox = new System.Windows.Forms.ComboBox();
            this.addPigettingButon = new System.Windows.Forms.Button();
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
            this.addPanel.Controls.Add(this.pigettingComboBox);
            this.addPanel.Controls.Add(this.addPigettingButon);
            this.addPanel.Controls.Add(this.amountLabel);
            this.addPanel.Controls.Add(this.addEarningLabel);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(0, 51);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(684, 641);
            this.addPanel.TabIndex = 9;
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
            // pigettingComboBox
            // 
            this.pigettingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pigettingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pigettingComboBox.FormattingEnabled = true;
            this.pigettingComboBox.Location = new System.Drawing.Point(52, 163);
            this.pigettingComboBox.Name = "pigettingComboBox";
            this.pigettingComboBox.Size = new System.Drawing.Size(578, 45);
            this.pigettingComboBox.TabIndex = 6;
            // 
            // addPigettingButon
            // 
            this.addPigettingButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.addPigettingButon.FlatAppearance.BorderSize = 0;
            this.addPigettingButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPigettingButon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPigettingButon.Location = new System.Drawing.Point(52, 542);
            this.addPigettingButon.Name = "addPigettingButon";
            this.addPigettingButon.Size = new System.Drawing.Size(114, 65);
            this.addPigettingButon.TabIndex = 5;
            this.addPigettingButon.Text = "Add";
            this.addPigettingButon.UseVisualStyleBackColor = false;
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
            this.addEarningLabel.Size = new System.Drawing.Size(196, 39);
            this.addEarningLabel.TabIndex = 2;
            this.addEarningLabel.Text = "Add Pigeting";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(684, 51);
            this.topPanel.TabIndex = 8;
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
            // AddPigettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 692);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPigettingForm";
            this.Text = "AddPigettingForm";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addPigettingButon;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label addEarningLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        public System.Windows.Forms.ComboBox pigettingComboBox;
        public System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}
namespace Project_Vispro.View
{
    partial class DetailPigetherForm
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
            this.detailPanel = new System.Windows.Forms.Panel();
            this.addPeoplePigetherButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closedButton = new System.Windows.Forms.Button();
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.detailPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.addPeoplePigetherButton);
            this.detailPanel.Controls.Add(this.topPanel);
            this.detailPanel.Controls.Add(this.peopleDataGridView);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Location = new System.Drawing.Point(0, 0);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(2);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(465, 475);
            this.detailPanel.TabIndex = 0;
            // 
            // addPeoplePigetherButton
            // 
            this.addPeoplePigetherButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPeoplePigetherButton.FlatAppearance.BorderSize = 0;
            this.addPeoplePigetherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPeoplePigetherButton.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addPeoplePigetherButton.Location = new System.Drawing.Point(352, 370);
            this.addPeoplePigetherButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPeoplePigetherButton.Name = "addPeoplePigetherButton";
            this.addPeoplePigetherButton.Size = new System.Drawing.Size(73, 72);
            this.addPeoplePigetherButton.TabIndex = 10;
            this.addPeoplePigetherButton.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.closedButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(465, 33);
            this.topPanel.TabIndex = 9;
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
            // peopleDataGridView
            // 
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Location = new System.Drawing.Point(8, 59);
            this.peopleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.RowHeadersWidth = 62;
            this.peopleDataGridView.RowTemplate.Height = 28;
            this.peopleDataGridView.Size = new System.Drawing.Size(449, 291);
            this.peopleDataGridView.TabIndex = 0;
            // 
            // DetailPigetherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 475);
            this.Controls.Add(this.detailPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetailPigetherForm";
            this.Text = "DetailPigetherForm";
            this.detailPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closedButton;
        private System.Windows.Forms.Button addPeoplePigetherButton;
        public System.Windows.Forms.DataGridView peopleDataGridView;
    }
}
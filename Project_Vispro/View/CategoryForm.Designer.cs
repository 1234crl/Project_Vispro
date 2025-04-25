namespace Project_Vispro.View
{
    partial class CategoryForm
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
            this.penghasilanPanel = new System.Windows.Forms.Panel();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.addButonPanel = new System.Windows.Forms.Panel();
            this.addCategoryButon = new System.Windows.Forms.Button();
            this.butonPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.pengeluaranButton = new System.Windows.Forms.Button();
            this.Penghasilanbutton = new System.Windows.Forms.Button();
            this.penghasilanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.addButonPanel.SuspendLayout();
            this.butonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // penghasilanPanel
            // 
            this.penghasilanPanel.Controls.Add(this.categoryDataGridView);
            this.penghasilanPanel.Controls.Add(this.addButonPanel);
            this.penghasilanPanel.Controls.Add(this.butonPanel);
            this.penghasilanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penghasilanPanel.Location = new System.Drawing.Point(0, 0);
            this.penghasilanPanel.Name = "penghasilanPanel";
            this.penghasilanPanel.Size = new System.Drawing.Size(956, 780);
            this.penghasilanPanel.TabIndex = 0;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Location = new System.Drawing.Point(24, 134);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowHeadersWidth = 62;
            this.categoryDataGridView.RowTemplate.Height = 28;
            this.categoryDataGridView.Size = new System.Drawing.Size(909, 406);
            this.categoryDataGridView.TabIndex = 2;
            this.categoryDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.categoryDataGridView_RowsAdded);
            // 
            // addButonPanel
            // 
            this.addButonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButonPanel.Controls.Add(this.addCategoryButon);
            this.addButonPanel.Location = new System.Drawing.Point(0, 546);
            this.addButonPanel.Name = "addButonPanel";
            this.addButonPanel.Size = new System.Drawing.Size(956, 234);
            this.addButonPanel.TabIndex = 1;
            // 
            // addCategoryButon
            // 
            this.addCategoryButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCategoryButon.FlatAppearance.BorderSize = 0;
            this.addCategoryButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButon.Image = global::Project_Vispro.Properties.Resources.add_icon_;
            this.addCategoryButon.Location = new System.Drawing.Point(774, 22);
            this.addCategoryButon.Name = "addCategoryButon";
            this.addCategoryButon.Size = new System.Drawing.Size(135, 102);
            this.addCategoryButon.TabIndex = 0;
            this.addCategoryButon.UseVisualStyleBackColor = true;
            // 
            // butonPanel
            // 
            this.butonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butonPanel.Controls.Add(this.linePanel);
            this.butonPanel.Controls.Add(this.pengeluaranButton);
            this.butonPanel.Controls.Add(this.Penghasilanbutton);
            this.butonPanel.Location = new System.Drawing.Point(0, 0);
            this.butonPanel.Name = "butonPanel";
            this.butonPanel.Size = new System.Drawing.Size(956, 128);
            this.butonPanel.TabIndex = 0;
            // 
            // linePanel
            // 
            this.linePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linePanel.Location = new System.Drawing.Point(0, 123);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(956, 0);
            this.linePanel.TabIndex = 11;
            // 
            // pengeluaranButton
            // 
            this.pengeluaranButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pengeluaranButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.pengeluaranButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pengeluaranButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaranButton.Location = new System.Drawing.Point(699, 32);
            this.pengeluaranButton.Name = "pengeluaranButton";
            this.pengeluaranButton.Size = new System.Drawing.Size(234, 66);
            this.pengeluaranButton.TabIndex = 1;
            this.pengeluaranButton.Text = "Expenses";
            this.pengeluaranButton.UseVisualStyleBackColor = false;
            // 
            // Penghasilanbutton
            // 
            this.Penghasilanbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.Penghasilanbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Penghasilanbutton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penghasilanbutton.Location = new System.Drawing.Point(32, 32);
            this.Penghasilanbutton.Name = "Penghasilanbutton";
            this.Penghasilanbutton.Size = new System.Drawing.Size(234, 66);
            this.Penghasilanbutton.TabIndex = 0;
            this.Penghasilanbutton.Text = "Earnings";
            this.Penghasilanbutton.UseVisualStyleBackColor = false;
            this.Penghasilanbutton.Click += new System.EventHandler(this.Penghasilanbutton_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 780);
            this.Controls.Add(this.penghasilanPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "PenghasilanForm";
            this.penghasilanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.addButonPanel.ResumeLayout(false);
            this.butonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel penghasilanPanel;
        private System.Windows.Forms.Panel butonPanel;
        private System.Windows.Forms.Button Penghasilanbutton;
        private System.Windows.Forms.Panel addButonPanel;
        private System.Windows.Forms.Button addCategoryButon;
        private System.Windows.Forms.Button pengeluaranButton;
        private System.Windows.Forms.Panel linePanel;
        public System.Windows.Forms.DataGridView categoryDataGridView;
    }
}
namespace Project_Vispro.View
{
    partial class MoreForm
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
            this.morePanel = new System.Windows.Forms.Panel();
            this.peopleButton = new System.Windows.Forms.Button();
            this.kategoriButton = new System.Windows.Forms.Button();
            this.morePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // morePanel
            // 
            this.morePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.morePanel.BackColor = System.Drawing.SystemColors.Control;
            this.morePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.morePanel.Controls.Add(this.peopleButton);
            this.morePanel.Controls.Add(this.kategoriButton);
            this.morePanel.Location = new System.Drawing.Point(0, 0);
            this.morePanel.Name = "morePanel";
            this.morePanel.Size = new System.Drawing.Size(956, 780);
            this.morePanel.TabIndex = 0;
            // 
            // peopleButton
            // 
            this.peopleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.peopleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.peopleButton.FlatAppearance.BorderSize = 0;
            this.peopleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peopleButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleButton.Location = new System.Drawing.Point(3, 107);
            this.peopleButton.Name = "peopleButton";
            this.peopleButton.Size = new System.Drawing.Size(956, 92);
            this.peopleButton.TabIndex = 3;
            this.peopleButton.Text = "People";
            this.peopleButton.UseVisualStyleBackColor = false;
            // 
            // kategoriButton
            // 
            this.kategoriButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kategoriButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(203)))), ((int)(((byte)(217)))));
            this.kategoriButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kategoriButton.FlatAppearance.BorderSize = 0;
            this.kategoriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriButton.Location = new System.Drawing.Point(3, -1);
            this.kategoriButton.Name = "kategoriButton";
            this.kategoriButton.Size = new System.Drawing.Size(956, 92);
            this.kategoriButton.TabIndex = 0;
            this.kategoriButton.Text = "Category";
            this.kategoriButton.UseVisualStyleBackColor = false;
            // 
            // MoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 780);
            this.Controls.Add(this.morePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoreForm";
            this.Text = "More";
            this.morePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel morePanel;
        private System.Windows.Forms.Button kategoriButton;
        private System.Windows.Forms.Button peopleButton;
    }
}
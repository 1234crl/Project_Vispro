namespace Project_Vispro
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.moreButton = new System.Windows.Forms.Button();
            this.statisticButton = new System.Windows.Forms.Button();
            this.portfolioButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(222, 31);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(662, 539);
            this.mainPanel.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.usernameLabel.Location = new System.Drawing.Point(101, 43);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 27);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(203)))), ((int)(((byte)(240)))));
            this.accountPanel.Controls.Add(this.usernameLabel);
            this.accountPanel.Controls.Add(this.userPictureBox);
            this.accountPanel.Location = new System.Drawing.Point(-3, 31);
            this.accountPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(227, 117);
            this.accountPanel.TabIndex = 2;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = global::Project_Vispro.Properties.Resources.user_icon1;
            this.userPictureBox.Location = new System.Drawing.Point(19, 21);
            this.userPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(70, 68);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(203)))), ((int)(((byte)(240)))));
            this.sidePanel.Controls.Add(this.moreButton);
            this.sidePanel.Controls.Add(this.statisticButton);
            this.sidePanel.Controls.Add(this.portfolioButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Location = new System.Drawing.Point(-8, 143);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(232, 426);
            this.sidePanel.TabIndex = 3;
            // 
            // moreButton
            // 
            this.moreButton.BackColor = System.Drawing.Color.Transparent;
            this.moreButton.FlatAppearance.BorderSize = 0;
            this.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreButton.Image = global::Project_Vispro.Properties.Resources.more_icon;
            this.moreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moreButton.Location = new System.Drawing.Point(7, 239);
            this.moreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moreButton.Name = "moreButton";
            this.moreButton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.moreButton.Size = new System.Drawing.Size(225, 57);
            this.moreButton.TabIndex = 3;
            this.moreButton.Text = "        More";
            this.moreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moreButton.UseVisualStyleBackColor = false;
            // 
            // statisticButton
            // 
            this.statisticButton.BackColor = System.Drawing.Color.Transparent;
            this.statisticButton.FlatAppearance.BorderSize = 0;
            this.statisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticButton.Image = global::Project_Vispro.Properties.Resources.statistic_icon;
            this.statisticButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticButton.Location = new System.Drawing.Point(7, 178);
            this.statisticButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.statisticButton.Size = new System.Drawing.Size(225, 57);
            this.statisticButton.TabIndex = 2;
            this.statisticButton.Text = "        Report";
            this.statisticButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticButton.UseVisualStyleBackColor = false;
            // 
            // portfolioButton
            // 
            this.portfolioButton.BackColor = System.Drawing.Color.Transparent;
            this.portfolioButton.FlatAppearance.BorderSize = 0;
            this.portfolioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portfolioButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portfolioButton.Image = global::Project_Vispro.Properties.Resources.portfolio_icon;
            this.portfolioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.portfolioButton.Location = new System.Drawing.Point(7, 117);
            this.portfolioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portfolioButton.Name = "portfolioButton";
            this.portfolioButton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.portfolioButton.Size = new System.Drawing.Size(225, 57);
            this.portfolioButton.TabIndex = 1;
            this.portfolioButton.Text = "        Portfolio";
            this.portfolioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.portfolioButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Image = global::Project_Vispro.Properties.Resources.home_icon2;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(7, 55);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.homeButton.Size = new System.Drawing.Size(225, 57);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "        Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(203)))), ((int)(((byte)(240)))));
            this.topPanel.Controls.Add(this.minimizeButton);
            this.topPanel.Controls.Add(this.maximizeButton);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(884, 33);
            this.topPanel.TabIndex = 6;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(203)))), ((int)(((byte)(240)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::Project_Vispro.Properties.Resources.minimize_icon;
            this.minimizeButton.Location = new System.Drawing.Point(787, 8);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(15, 15);
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(203)))), ((int)(((byte)(240)))));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Image = global::Project_Vispro.Properties.Resources.maximize_icon;
            this.maximizeButton.Location = new System.Drawing.Point(815, 8);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(15, 15);
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(203)))), ((int)(((byte)(240)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Project_Vispro.Properties.Resources.close_icon;
            this.closeButton.Location = new System.Drawing.Point(845, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(15, 15);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(884, 525);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button portfolioButton;
        private System.Windows.Forms.Button statisticButton;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Label usernameLabel;
    }
}


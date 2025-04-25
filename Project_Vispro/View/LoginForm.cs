using Project_Vispro.BudgetingManagementDataSetTableAdapters;
using Project_Vispro.Controller;
using Project_Vispro.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Vispro
{
    public partial class LoginForm : Form
    {
        FormController controller;
        MainForm mainForm;
        public LoginForm(FormController control, MainForm mainForm)
        {
            InitializeComponent();
            this.controller = control;
            backgroundPanel.BackgroundImageLayout = ImageLayout.Stretch;
            hookEvents();
            this.mainForm = mainForm;
        }
        private void hookEvents()
        {
            this.closedButton.Click += new System.EventHandler(controller.loginClosedButton_Click);
            this.registerLinkLabel.DoubleClick += new System.EventHandler(controller.registerLinkLabel_DoubleClick);
            this.loginButton.Click += new System.EventHandler(controller.loginButton_Click);
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            mainForm.Enabled = false;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}

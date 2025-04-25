using Project_Vispro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Vispro.View
{
    public partial class HomeForm : Form
    {
        FormController controller;
        public HomeForm(FormController control)
        {
            InitializeComponent();
            this.controller = control;
            hookEvents();
        }

        private void hookEvents()
        {
            this.addButton.Click += new System.EventHandler(controller.addButton_Click);
            this.homePanel.Click += new System.EventHandler(controller.homePanel_Click);
            this.earningsButton.Click += new System.EventHandler(controller.earningsButton_Click);
            this.expenseButton.Click += new System.EventHandler(controller.expenseButton_Click);
            this.showButton.Click += new System.EventHandler(controller.showButton_Click);
            this.Load += new System.EventHandler(controller.HomeForm_Load);
        }
    }
}

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
    public partial class PortfolioForm : Form
    {
        FormController controller;
        public PortfolioForm(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;
            hookEvents();
        }

        private void hookEvents()
        {
            this.showSavingsButton.Click += new System.EventHandler(controller.showSavingsButton_Click);
            this.showTotalButton.Click += new System.EventHandler(controller.showTotalButton_Click);
            this.showAccountButton.Click += new System.EventHandler(controller.showAccountButton_Click);
            this.piGetingButton.Click += new System.EventHandler(controller.piGetingButton_Click);
            this.piGetherButton.Click += new System.EventHandler(controller.piGetherButton_Click);
            this.Load += new System.EventHandler(controller.PortfolioForm_Shown);
            this.editSavings.Click += new System.EventHandler(controller.editSavings_Click);
        }
    }
}

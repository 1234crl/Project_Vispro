using MainForm;
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
    public partial class MainForm : Form
    {
        public Controller.FormController controller;

        public MainForm()
        {
            InitializeComponent();
            controller = new Controller.FormController(this);
            controller.showHomeScreen();
            hookEvents();
        }

        private void hookEvents()
        {
            this.Shown += new System.EventHandler(controller.MainForm_Shown);
            this.homeButton.Click += new System.EventHandler(controller.HomeButton_Click);
            this.portfolioButton.Click += new System.EventHandler(controller.PortfolioButton_Click);
            this.statisticButton.Click += new System.EventHandler(controller.StatisticButton_Click);
            this.moreButton.Click += new System.EventHandler(controller.MoreButton_Click);
            this.closeButton.Click += new System.EventHandler(controller.closeButton_Click);
            this.minimizeButton.Click += new System.EventHandler(controller.minimizeButton_Click);
            this.maximizeButton.Click += new System.EventHandler(controller.maximizeButton_Click);
            
        }
        
    }
}

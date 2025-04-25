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
    public partial class AddSavingsForm : Form
    {
        Controller.FormController controller;
        public AddSavingsForm(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;   
            hookEvents();
        }
        public void hookEvents()
        {
            this.closedButton.Click += new System.EventHandler(controller.closedButton_Click);
            this.Shown += new System.EventHandler(controller.AddSavingsForm_Shown);
            this.addSavingsButon.Click += new System.EventHandler(controller.addSavingsButon_Click);
        }

        
    }
}

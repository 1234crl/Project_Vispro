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
    public partial class RegisterForm : Form
    {
        FormController controller;
        public RegisterForm(FormController control)
        {
            InitializeComponent();
            this.controller = control;
            hookEvents();
            
        }

        private void hookEvents()
        {
            this.closeButton.Click += new System.EventHandler(controller.closedButton_Click);
            this.registerButton.Click += new System.EventHandler(controller.registerButton_Click);
        }
    }
}

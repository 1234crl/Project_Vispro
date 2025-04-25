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
    public partial class MoreForm : Form
    {
        FormController controller;
        public MoreForm(FormController control)
        {
            this.controller = control;
            InitializeComponent();
            hookEvents();
        }

        private void hookEvents()
        {
            this.kategoriButton.Click += new System.EventHandler(controller.kategoriButton_Click);
            this.peopleButton.Click += new System.EventHandler(controller.peopleButton_Click);
        }


    }
}

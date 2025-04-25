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
    public partial class AddCategories : Form
    {
        FormController controller;
        public AddCategories(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.closedButton.Click += new System.EventHandler(this.controller.closedButton_Click);
            this.addBudgetButon.Click += new System.EventHandler(this.controller.addBudgetButon_Click);
        }
    }
}

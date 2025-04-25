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
    public partial class AddExpenseForm : Form
    {
        FormController controller;
        public AddExpenseForm(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.controller.PopulateCategoryExpenseComboBox(categoryExpenseComboBox);
            this.closedButton.Click += new System.EventHandler(this.controller.closedButton_Click);
            this.addExpenseButon.Click += new System.EventHandler(this.controller.addExpenseButon_Click);
        }
    }
}

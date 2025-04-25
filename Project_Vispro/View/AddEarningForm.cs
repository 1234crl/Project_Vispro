using MainForm;
using Project_Vispro.BudgetingManagementDataSetTableAdapters;
using Project_Vispro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Vispro.View
{
    public partial class AddEarningForm : Form
    {
        FormController controller;
        public AddEarningForm(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.controller.PopulateCategoryEarningComboBox(categoryEarningCb);
            this.closedButton.Click += new System.EventHandler(this.controller.closedButton_Click);
            this.addEarningButon.Click += new System.EventHandler(this.controller.addEarningButon_Click);
        }

    }
}

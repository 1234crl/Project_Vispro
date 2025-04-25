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
    public partial class AddPigetherForm : Form
    {
        FormController controller;
        public AddPigetherForm(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.closedButton.Click += new System.EventHandler(this.controller.closedButton_Click);
            this.addPeoplePigetherButton.Click += new System.EventHandler(this.controller.addPeoplePigetherButton_Click);
            this.savePigetherButton.Click += new System.EventHandler(controller.savePigetherButton_Click);
        }
        private void AddPigetherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetingManagementDataSet.DetailPigether' table. You can move, or remove it, as needed.
            this.detailPigetherTableAdapter.Fill(this.budgetingManagementDataSet.DetailPigether);

        }

        
    }
}

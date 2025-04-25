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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetingManagementDataSet.viewAllExpense' table. You can move, or remove it, as needed.
            this.viewAllExpenseTableAdapter.Fill(this.budgetingManagementDataSet.viewAllExpense);
            // TODO: This line of code loads data into the 'budgetingManagementDataSet.viewAllEarning' table. You can move, or remove it, as needed.
            this.viewAllEarningTableAdapter.Fill(this.budgetingManagementDataSet.viewAllEarning);
            // TODO: This line of code loads data into the 'budgetingManagementDataSet1.viewAllExpense' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'budgetingManagementDataSet.viewAllEarning' table. You can move, or remove it, as needed.
            this.viewAllEarningTableAdapter.Fill(this.budgetingManagementDataSet.viewAllEarning);
            // TODO: This line of code loads data into the 'budgetingManagementDataSet.viewAllExpense' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

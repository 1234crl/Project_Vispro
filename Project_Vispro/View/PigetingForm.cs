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
    public partial class PigetingForm : Form
    {

        #region CONST
        public const string COLUMN_EXCategory = "Expense Category";
        public const string Data_Category = "Category";
        public const string COLUMN_Budget = "Budget";
        public const string COLUMN_Expense = "Expense";
        #endregion CONST


        FormController controller;
        public PigetingForm(FormController controller)
        {
            this.controller = controller;
            InitializeComponent();

            SetUpDataGridView();
            this.addBudgetButton.Click += new System.EventHandler(this.controller.addBudgetButton_Click);
            //this.Load += new System.EventHandler(controller.PigetingForm_Load);
            PopulateDgvFromLINQ();
        }
        
        private void SetUpDataGridView()
        {
            DataGridViewTextBoxColumn rowNumberColumn = new DataGridViewTextBoxColumn();
            this.budgetDataGridView.ColumnCount = 3;

            rowNumberColumn.HeaderText = "No";
            rowNumberColumn.Name = "No";
            rowNumberColumn.ReadOnly = true;
            this.budgetDataGridView.Columns.Insert(0, rowNumberColumn);
            this.budgetDataGridView.Columns[0].Width = 25;

            this.budgetDataGridView.Columns[1].Name = COLUMN_EXCategory;
            this.budgetDataGridView.Columns[1].DataPropertyName = Data_Category;
            this.budgetDataGridView.Columns[1].HeaderText = this.budgetDataGridView.Columns[1].Name;

            this.budgetDataGridView.Columns[2].Name = COLUMN_Budget;
            this.budgetDataGridView.Columns[2].DataPropertyName = this.budgetDataGridView.Columns[2].Name;
            this.budgetDataGridView.Columns[2].HeaderText = this.budgetDataGridView.Columns[2].Name;

            this.budgetDataGridView.Columns[3].Name = COLUMN_Expense;
            this.budgetDataGridView.Columns[3].DataPropertyName = this.budgetDataGridView.Columns[3].Name;
            this.budgetDataGridView.Columns[3].HeaderText = this.budgetDataGridView.Columns[3].Name;

            this.budgetDataGridView.EnableHeadersVisualStyles = false;
            this.budgetDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.budgetDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
            this.budgetDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
        }

        public void PopulateDgvFromLINQ()
        {
            this.budgetDataGridView.DataSource = null;
            this.budgetDataGridView.Rows.Clear();

            this.budgetDataGridView.DataSource = this.controller.GetDataFromDatabasePigeting();
        }

        private void budgetDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRowNumbers();
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < this.budgetDataGridView.Rows.Count; i++)
            {
                if (!this.budgetDataGridView.Rows[i].IsNewRow)
                {
                    this.budgetDataGridView.Rows[i].Cells["No"].Value = (i + 1).ToString();
                }
            }
        }
    }
}

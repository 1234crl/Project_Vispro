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
    public partial class CategoryForm : Form
    {
        #region CONST
        public const string COLUMN_Name = "Category Name";
        public const string Data_Name = "Name";
        #endregion CONST

        FormController controller;
        public CategoryForm(FormController controller)
        {
            this.controller = controller;
            InitializeComponent();

            SetUpDataGridView();
            hookEvents();
        }

        private void hookEvents()
        {
            this.addCategoryButon.Click += new System.EventHandler(this.controller.addCategoryButon_Click);
            this.Penghasilanbutton.Click += new System.EventHandler(this.controller.Penghasilanbutton_Click);
            this.pengeluaranButton.Click += new System.EventHandler(this.controller.pengeluaranButton_Click);
        }

        private void Penghasilanbutton_Click(object sender, EventArgs e)
        {
            //string query ="SELECT categoryIncome_id, categoryIncome_name from CategoryIncomes where user_"
        }

        private void SetUpDataGridView()
        {

            DataGridViewTextBoxColumn rowNumberColumn = new DataGridViewTextBoxColumn();
            this.categoryDataGridView.ColumnCount = 1;

            rowNumberColumn.HeaderText = "No";
            rowNumberColumn.Name = "No";
            rowNumberColumn.ReadOnly = true;
            this.categoryDataGridView.Columns.Insert(0, rowNumberColumn);
            this.categoryDataGridView.Columns[0].Width = 25;

            this.categoryDataGridView.Columns[1].Name = COLUMN_Name;
            this.categoryDataGridView.Columns[1].DataPropertyName = Data_Name;
            this.categoryDataGridView.Columns[1].HeaderText = this.categoryDataGridView.Columns[1].Name;

            this.categoryDataGridView.EnableHeadersVisualStyles = false;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
            this.categoryDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < this.categoryDataGridView.Rows.Count; i++)
            {
                if (!this.categoryDataGridView.Rows[i].IsNewRow)
                {
                    this.categoryDataGridView.Rows[i].Cells["No"].Value = (i + 1).ToString();
                }
            }
        }

        private void categoryDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRowNumbers();
        }
    }
}

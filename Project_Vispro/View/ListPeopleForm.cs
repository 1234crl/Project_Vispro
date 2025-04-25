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
    public partial class ListPeopleForm : Form
    {

        #region CONST
        public const string COLUMN_Name = "People Name";
        public const string Data_Name = "Name";
        #endregion CONST

        FormController controller;
        public ListPeopleForm(FormController controller)
        {
            this.controller = controller;
            InitializeComponent();
            SetUpDataGridView();

            this.closedButton.Click += new System.EventHandler(controller.closedButton_Click);
            this.Load += new System.EventHandler(controller.ListPeopleForm_Load);
            this.addPeopleListButton.Click += new System.EventHandler(controller.addPeopleListButton_Click);
        }

        private void SetUpDataGridView()
        {

            DataGridViewTextBoxColumn rowNumberColumn = new DataGridViewTextBoxColumn();
            this.categoryPeopleDataGridView.ColumnCount = 1;

            rowNumberColumn.HeaderText = "No";
            rowNumberColumn.Name = "No";
            rowNumberColumn.ReadOnly = true;
            this.categoryPeopleDataGridView.Columns.Insert(0, rowNumberColumn);
            this.categoryPeopleDataGridView.Columns[0].Width = 25;

            this.categoryPeopleDataGridView.Columns[1].Name = COLUMN_Name;
            this.categoryPeopleDataGridView.Columns[1].DataPropertyName = Data_Name;
            this.categoryPeopleDataGridView.Columns[1].HeaderText = this.categoryPeopleDataGridView.Columns[1].Name;

            this.categoryPeopleDataGridView.EnableHeadersVisualStyles = false;
            this.categoryPeopleDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.categoryPeopleDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
            this.categoryPeopleDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < this.categoryPeopleDataGridView.Rows.Count; i++)
            {
                if (!this.categoryPeopleDataGridView.Rows[i].IsNewRow)
                {
                    this.categoryPeopleDataGridView.Rows[i].Cells["No"].Value = (i + 1).ToString();
                }
            }
        }

        private void categoryPeopleDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRowNumbers();
        }
    }
}

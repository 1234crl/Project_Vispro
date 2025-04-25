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
    public partial class Pigether : Form
    {
        #region CONST
        public const string COLUMN_Name = "Pigether Name";
        public const string Data_Name = "Name";
        public const string COLUMN_Goal = "Goal";
        #endregion CONST


        FormController controller;
        public Pigether(FormController controller)
        {
            this.controller = controller;
            InitializeComponent();

            SetUpDataGridView();
            PopulateDgvFromLINQ();

            this.addPigetherButton.Click += new System.EventHandler(this.controller.addPigetherButton_Click);
            this.viewDetailButton.Click += new System.EventHandler(this.controller.viewDetailButton_Click);
        }

        private void SetUpDataGridView()
        {

            DataGridViewTextBoxColumn rowNumberColumn = new DataGridViewTextBoxColumn();
            this.pigetherDataGridView.ColumnCount = 2;

            rowNumberColumn.HeaderText = "No";
            rowNumberColumn.Name = "No";
            rowNumberColumn.ReadOnly = true;
            this.pigetherDataGridView.Columns.Insert(0, rowNumberColumn);
            this.pigetherDataGridView.Columns[0].Width = 25;

            this.pigetherDataGridView.Columns[1].Name = COLUMN_Name;
            this.pigetherDataGridView.Columns[1].DataPropertyName = Data_Name ;
            this.pigetherDataGridView.Columns[1].HeaderText = this.pigetherDataGridView.Columns[1].Name;

            this.pigetherDataGridView.Columns[2].Name = COLUMN_Goal;
            this.pigetherDataGridView.Columns[2].DataPropertyName = this.pigetherDataGridView.Columns[2].Name;
            this.pigetherDataGridView.Columns[2].HeaderText = this.pigetherDataGridView.Columns[2].Name;

            this.pigetherDataGridView.EnableHeadersVisualStyles = false;
            this.pigetherDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.pigetherDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
            this.pigetherDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(226, 203, 240);
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < this.pigetherDataGridView.Rows.Count; i++)
            {
                if (!this.pigetherDataGridView.Rows[i].IsNewRow)
                {
                    this.pigetherDataGridView.Rows[i].Cells["No"].Value = (i + 1).ToString();
                }
            }
        }

        public void PopulateDgvFromLINQ()
        {
            this.pigetherDataGridView.DataSource = null;
            this.pigetherDataGridView.Rows.Clear();

            this.pigetherDataGridView.DataSource = this.controller.GetDataFromDatabasePigether();
        }

        private void pigetherDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRowNumbers();
        }


    }
}

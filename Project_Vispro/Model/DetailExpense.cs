using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    internal class DetailExpense
    {
        private int detailExpense_ID;
        private int expense_ID;
        private DateTime addedDate;
        private float amount;

        public DetailExpense() { }

        public DetailExpense(int detailExpense_ID, int expense_ID, DateTime addedDate, float amount)
        {
            this.detailExpense_ID = detailExpense_ID;
            this.expense_ID = expense_ID;
            this.amount = amount;
            this.addedDate = addedDate;
        }

        public int DetailExpense_ID
        {
            get { return detailExpense_ID; }
            set { detailExpense_ID = value; }
        }
        public int Expense_ID
        {
            get { return expense_ID; }
            set { expense_ID = value; }
        }
        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime AddedDate
        {
            get { return addedDate; }
            set { addedDate = value; }
        }

    }
}

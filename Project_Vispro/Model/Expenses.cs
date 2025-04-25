using Project_Vispro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    internal class Expenses
    {
        private int expense_ID;
        private int user_ID;
        private int budget_ID;
        private int category_ID;

        public Expenses() { }

        public Expenses(int expense_ID, int user_ID, int budget_ID, int category_ID)
        {
            this.expense_ID = expense_ID;
            this.user_ID = user_ID;
            this.budget_ID = budget_ID;
            this.category_ID = category_ID;
        }

        public int ExpenseID
        {
            get { return expense_ID; }
            set { expense_ID = value; }
        }

        public int CategoryID
        {
            get { return category_ID; }
            set { category_ID = value; }
        }

        public int UserID
        {
            get { return user_ID; }
            set { user_ID = value; }
        }

        public int BudgetID
        {
            get { return budget_ID; }
            set { budget_ID = value; }
        }


    }
}

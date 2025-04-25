using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class Income
    {
        private int income_ID;
        private int user_ID;
        private int category_ID;

        public Income() { }

        public Income(int income_ID, int user_ID, int category_ID)
        {
            this.income_ID = income_ID;
            this.user_ID = user_ID;
            this.category_ID = category_ID;
        }

        public int ExpenseID
        {
            get { return income_ID; }
            set { income_ID = value; }
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

    }
}

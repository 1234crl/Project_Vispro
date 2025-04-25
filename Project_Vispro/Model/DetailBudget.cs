using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class DetailBudget
    {
        private int detailBudget_ID;
        private int budget_ID;
        private int category_ID;
        private float amount;
        private DateTime month;

        public DetailBudget() { }

        public DetailBudget(int detailBudget_ID, int budget_ID, int category_ID, DateTime month, float amount)
        {
            this.detailBudget_ID = detailBudget_ID;
            this.budget_ID = budget_ID;
            this.category_ID = category_ID;
            this.amount = amount;
            this.month = month;
        }

        public int DetailBudget_ID
        {
            get { return detailBudget_ID; }
            set { detailBudget_ID = value; }
        }
        public int Budget_ID
        {
            get { return budget_ID; }
            set { budget_ID = value; }
        }
        public int Category_ID
        {
            get { return category_ID; }
            set { category_ID = value; }
        }
        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public DateTime Month
        {
            get { return month; }
            set { month = value; }
        }

    }
}

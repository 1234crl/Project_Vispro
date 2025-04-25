using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class CategoryPeople
    {
        #region Category Properties
        private int categoryID;
        private string categoryName;
        private float amount;
        #endregion

        public CategoryPeople() { }

        public CategoryPeople(int categoryID, string categoryName,float amount)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.amount = amount;
        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}

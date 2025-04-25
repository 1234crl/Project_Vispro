using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class CategoryExpense
    {
        #region Category Properties
        private int categoryID;
        private string categoryName;
        #endregion

        public CategoryExpense() { }

        public CategoryExpense(int categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
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
    }

}

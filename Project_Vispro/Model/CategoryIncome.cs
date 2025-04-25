using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MainForm
{
    internal class CategoryIncome
    {
        #region Category Properties
        private int categoryID;
        private string categoryName;
        #endregion

        public CategoryIncome() { }

        public CategoryIncome(int categoryID, string categoryName) {  
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

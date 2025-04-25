using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class Budget
    {

        #region Category Properties
        private int budget_ID;
        private int user_ID;
        #endregion

        public Budget() { }

        public Budget(int budget_ID, int user_ID)
        {
            this.budget_ID = budget_ID;
            this.user_ID = user_ID;
        }

        public int Budget_ID
        {
            get { return budget_ID; }
            set { budget_ID = value; }
        }
        public int User_ID
        {
            get { return user_ID; }
            set { user_ID = value; }
        }
    }
}

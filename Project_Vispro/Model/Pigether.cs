using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class Pigether
    {
        #region Pigether Properties
        private int pigether_ID;
        private int user_ID;
        private string pigether_name;
        private float goal;
        #endregion

        public Pigether() { }

        public Pigether(int pigether_ID, int user_ID, string pigether_name, float goal)
        {
            this.pigether_ID = pigether_ID;
            this.user_ID = user_ID;
            this.pigether_name = pigether_name;
            this.goal = goal;
        }
        public int User_ID
        {
            get { return user_ID; }
            set { user_ID = value; }
        }
        public int Pigether_ID
        {
            get { return pigether_ID; }
            set { pigether_ID = value; }
        }
        public string Pigether_name
        {
            get { return pigether_name; }
            set { pigether_name = value; }
        }
        public float amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }

}

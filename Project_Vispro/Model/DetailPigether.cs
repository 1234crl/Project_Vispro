using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class DetailPigether
    {
        private int detailPigether_ID;
        private int pigether_ID;
        private int categoryPeople_ID;
        private float amount;

        public DetailPigether() { }

        public DetailPigether(int detailPigether_ID, int pigether_ID, int category_ID, float amount)
        {
            this.detailPigether_ID = detailPigether_ID;
            this.pigether_ID = pigether_ID;
            this.categoryPeople_ID = category_ID;
            this.amount = amount;
        }

        public int DetailPigether_ID
        {
            get { return detailPigether_ID; }
            set { detailPigether_ID = value; }
        }
        public int Pigether_ID
        {
            get { return pigether_ID; }
            set { pigether_ID = value; }
        }
        public int Category_ID
        {
            get { return categoryPeople_ID; }
            set { categoryPeople_ID = value; }
        }
        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    internal class DetailIncome
    {
        private int detailIncome_ID;
        private int income_ID;
        private float amount;
        private DateTime addedDate;


    public DetailIncome() { }

    public DetailIncome(int detailIncome_ID, int income_ID, DateTime addedDate, float amount)
    {
        this.detailIncome_ID = detailIncome_ID;
        this.income_ID = income_ID;
        this.amount = amount;
        this.addedDate = addedDate;
    }

    public int DetailIncome_ID
    {
        get { return detailIncome_ID; }
        set { detailIncome_ID = value; }
    }
    public int Income_ID
    {
        get { return income_ID; }
        set { income_ID = value; }
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

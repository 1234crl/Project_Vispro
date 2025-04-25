using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Vispro.Model
{
    public class ModelUser
    {
        #region User Properties
        private int user_id;
        private string name;
        private string email;
        private string password;
        private string phoneNumber;
        private double balance;
        private double savings;
        #endregion User Properties

        #region constructor
        public ModelUser()
        {
            this.user_id = 0;
            this.name = null;
            this.email = null;
            this.password = null;
            this.phoneNumber = null;
            this.balance = 0;
            this.savings = 0;
        }

        public ModelUser(int userID, string fullName, string email)
        {
            this.user_id = userID;
            this.name = fullName;
            this.email = email;
            this.phoneNumber = null;
            this.balance = 0;
            this.savings = 0;
        }

        public ModelUser(int userID, string fullName, string email, string phoneNumber, double balance, double savings)
        {
            this.user_id = userID;
            this.name = fullName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.balance = balance;
            this.savings = savings;
        }
        #endregion constructor

        public int User_ID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public double Savings
        {
            get { return savings; }
            set { savings = value; }
        }
    }
}

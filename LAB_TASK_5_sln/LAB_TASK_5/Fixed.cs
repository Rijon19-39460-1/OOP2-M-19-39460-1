using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_5
{
    class Fixed : Account
    {
        
        private int tenureYear;
        private int currrentYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        public int CurrrentYear
        {
            get { return currrentYear; }
            set { currrentYear = value; }
        }
        public Fixed(String accName, String acid, int balance, int tenureYear, int currrentYear)
        {
            this.AccName = accName;
            this.AccId = acid;
            this.Balance = balance;
            this.tenureYear = tenureYear;
            this.currrentYear = currrentYear;
        }
        public void Withdraw(int currrentYear, int tenureYear, int amount)
        {
            if (tenureYear < currrentYear)
            {
                if (amount < Balance)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Balance after withdrawing amount:" + this.Balance);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Currently this account is not enough matured");
            }

        }
    }
}

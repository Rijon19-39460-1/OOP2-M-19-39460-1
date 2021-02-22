using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_5
{
    class SpecialCurrent : Account
    {
        private int openingBalance;
        public int OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }
        public SpecialCurrent(String accName, String acid, int balance, int openingBalance)
        {
            this.AccName = accName;
            this.AccId = acid;
            this.Balance = balance;
            this.openingBalance = openingBalance;
        }
        public void Withdraw(int amount, int openingBalance)
        {
            if (amount > (openingBalance*0.1))
            {
                this.Balance -= amount;
                Console.WriteLine("Balance after withdrawing amount:" + this.Balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
    }
}

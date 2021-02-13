using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Account
    {
        private String accName;
        private String acid;
        private int balance;
        public String AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public String AccId
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Balance after depositing amount:" + this.balance);
            }

        }
        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                this.balance -= amount;
                Console.WriteLine("Balance after withdrawing amount:" + this.balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
    }
}

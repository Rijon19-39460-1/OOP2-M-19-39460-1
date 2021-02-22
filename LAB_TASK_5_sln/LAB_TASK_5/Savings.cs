using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_5
{
    class Savings : Account
    {
        private int minBalance;
        public int MinBalance
        {
            get { return minBalance; }
            set { minBalance = value; }
        }
        public Savings(String accName,String acid,int balance,int minBalance)
        {
            this.AccName = accName;
            this.AccId = acid;
            this.Balance = balance;
            this.minBalance = minBalance;
        }
         public void Withdraw(int amount,int minBalance)
        {
            if (amount > minBalance)
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


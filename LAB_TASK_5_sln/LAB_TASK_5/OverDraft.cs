using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_5
{
    class OverDraft : Account
    {
        
        private int limit;
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }
        public OverDraft(String accName, String acid, int balance, int limit)
        {
            this.AccName = accName;
            this.AccId = acid;
            this.Balance = balance;
            this.limit = limit;
        }
        public void Withdraw(int amount, int limit)
        {
            if (amount <= (limit + Balance))
            {
                if (amount < Balance)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Balance after withdrawing amount:" + this.Balance);
                }
                else
                {
                    int val = (Balance + limit) - amount;
                    Console.WriteLine("Your bank account have no Balance. You have only " + val + " additional limit left");
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
    }
}

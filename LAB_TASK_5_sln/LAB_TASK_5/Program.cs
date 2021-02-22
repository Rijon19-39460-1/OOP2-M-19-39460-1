using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Account a2 = new Account();
            a1.AccName = "RIJON";
            a1.AccId = "19391";
            a1.Balance = 7000;
            Console.WriteLine("Account 1 Name :" + a1.AccName);
            Console.WriteLine("Account 1 ID :" + a1.AccId);
            Console.WriteLine("Account 1 Balance :" + a1.Balance);
            a2.AccName = "Hossain";
            a2.AccId = "19601";
            a2.Balance = 5000;
            Console.WriteLine("Account 2 Name :" + a2.AccName);
            Console.WriteLine("Account 2 ID :" + a2.AccId);
            Console.WriteLine("Account 2 Balance :" + a2.Balance);
            a1.Deposit(1000);
            Console.WriteLine("Account 1 current Balance :" + a1.Balance);
            a1.Withdraw(500);
            Console.WriteLine("Account 1 current Balance :" + a1.Balance);
            a1.Transfer(300, a2);
            Console.WriteLine("Account 1 current Balance :" + a1.Balance);
            Console.WriteLine("Account 2 current Balance :" + a2.Balance);
            Savings s1 = new Savings(a1.AccName, a1.AccId, a1.Balance, 430);
            s1.Withdraw(7000, 430);
            Console.WriteLine("Savings account current Balance :" + s1.Balance);
            SpecialCurrent sp1 = new SpecialCurrent(a1.AccName, a1.AccId, a1.Balance, 2000);
            sp1.Withdraw(6000, 2000);
            Console.WriteLine("SpecialCurrent account current Balance :" + sp1.Balance);
            Fixed f1 = new Fixed(a1.AccName, a1.AccId, a1.Balance, 10,8);
            f1.Withdraw(8, 10,550);
            Console.WriteLine("Fixed account current Balance :" + f1.Balance);
            OverDraft o1 = new OverDraft(a1.AccName, a1.AccId, a1.Balance, 50000);
            o1.Withdraw(8000, 50000);
            
        }
    }
}

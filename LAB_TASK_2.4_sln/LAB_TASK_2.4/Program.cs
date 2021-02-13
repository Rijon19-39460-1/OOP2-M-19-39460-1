using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i ;
            int even = 0;
            int odd = 0;

            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    even = even + i;
            }
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    odd = odd + i;
            }
            Console.WriteLine("Sum of all even numbers :" + even);
            Console.WriteLine(" ");
            Console.WriteLine("Sum of all odd numbers :" + odd);
            Console.WriteLine(" ");
        }
    }
}

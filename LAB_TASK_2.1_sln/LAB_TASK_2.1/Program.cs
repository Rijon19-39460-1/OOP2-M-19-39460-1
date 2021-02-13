using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 50;

            Console.WriteLine("All even numbers printed from 1 to 50 are given below\n");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)

                    Console.Write("" + i + " ");

            }
            Console.WriteLine("\n");
        }
    }
}

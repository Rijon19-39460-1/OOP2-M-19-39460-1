using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            int i;
            Console.WriteLine(" Normal array value :");
            for (i = 0; i < n; i++)
            {
                arr[i] = i;
                Console.Write(" " + arr[i]);
               
            }
            Console.WriteLine("");

            Console.WriteLine(" Reverse array value :");
            for (i = n-1; i >= 0; i--)
            {
                arr[i] = i;
                Console.Write(" " + arr[i]);

            }
            Console.WriteLine("");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            int i;
            int sum = 0;
            Console.WriteLine(" Array value :");
            for (i = 0; i < n; i++)
            {
                arr[i] = i;
                Console.Write(" " + arr[i]);

            }
            Console.WriteLine("");
            for (i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(" Sum of all elements of the Array: " + sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = {1,1,4,5,6,6,7,9,9,9};           
            int i,j,count=0;
            Console.WriteLine("Array value: ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
           

            Console.WriteLine("\n");

              for (i = 0; i < arr.Length; i++)
                {
                   for (j = i+1; j < arr.Length; j++)
                   {
                       if(arr[i]==arr[j])
                       {
                           count++;
                           break;
                       }
                   }
              }
              Console.WriteLine("Total number of duplicate elements : " + count);
        }
    }
}

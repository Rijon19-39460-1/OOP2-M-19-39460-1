using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 4, 5, 6, 6, 7, 9, 9, 9 };
            int size = arr.Length;
            int i, j, k, count;

            Console.WriteLine("Array value: ");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");

            for (i = 0; i < size; i++)
            {
                count = 1;

                for (j = i + 1; j < size; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        for (k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        size--;
                        j--;
                        count = 0;
                    }
                }

                if (count != 1)
                {
                    for (j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    size--;
                    i--;
                }
            }

            Console.WriteLine("All unique elements : ");
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

    }
}


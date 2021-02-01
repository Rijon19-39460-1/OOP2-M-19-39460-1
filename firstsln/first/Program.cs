using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 3, w;
            Console.WriteLine("Hello world  {0} and {1}",x,y);
            Console.WriteLine("Addition of x & y is " + (x + y));
            Console.WriteLine("Substraction of x & y is " + (x - y));
            Console.WriteLine("multiplication of x & y is " + (x * y));
            Console.WriteLine("division of x & y is " + (x / y));
            string a = Console.ReadLine();
            w = Int32.Parse(a);
            Console.WriteLine("print= " + a);
        }
    }
}

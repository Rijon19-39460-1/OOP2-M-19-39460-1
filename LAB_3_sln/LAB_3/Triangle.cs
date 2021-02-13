using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("The length of X is " + x);
            Console.WriteLine("The length of Y is " + y);
            Console.WriteLine("The length of Z is " + z);
        }
        public void TestTriangle()
        {
            if (x == y && y == z && x == z)

                Console.WriteLine("The Triangle is Equilateral Triangle");

            else if (x == y || y == z || z == x)
                Console.WriteLine("The Triangle is Isosceles Triangle");

            else
                Console.WriteLine("The Triangle is Scalene Triangle");
        }
    }
}

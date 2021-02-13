using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double physics, chemistry, biology, mathematics, computer;
            double sum;
            double percentage;

            Console.WriteLine("Enter physics Mark : ");
            physics = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter chemistry Mark : ");
            chemistry = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter biology Mark : ");
            biology = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter mathematics Mark : ");
            mathematics = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter computer Mark : ");
            computer = Convert.ToDouble(Console.ReadLine());

            sum = physics + chemistry + biology + mathematics + computer;
            percentage = sum / 5;
            Console.WriteLine("Percentage is " +percentage);
            if(percentage >=90)
            {
                Console.WriteLine("Grade is A+");
            }
            if (percentage < 90 && percentage >= 85)
            {
                Console.WriteLine("Grade is A");
            }
            if (percentage < 85 && percentage >= 80)
            {
                Console.WriteLine("Grade is B+");
            }
            if (percentage < 80 && percentage >= 75)
            {
                Console.WriteLine("Grade is B");
            }
            if (percentage < 75 && percentage >= 70)
            {
                Console.WriteLine("Grade is C+");
            }
            if (percentage < 70 && percentage >= 65)
            {
                Console.WriteLine("Grade is C");
            }
            if (percentage < 65 && percentage >= 60)
            {
                Console.WriteLine("Grade is D+");
            }
            if (percentage < 60 && percentage >= 50)
            {
                Console.WriteLine("Grade is D");
            }
            if (percentage < 50 )
            {
                Console.WriteLine("Grade is F");
            }
            Console.WriteLine("");
        }
    }
}

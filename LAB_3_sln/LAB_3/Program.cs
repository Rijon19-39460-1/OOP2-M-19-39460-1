using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objs = new Student();
            objs.Name = "Rijon";
            objs.ID = "19-1";
            objs.Department = "CSE";
            objs.CGPA = 3.7F;
            objs.ShowInfo();
            Console.WriteLine("\n");

            Triangle objt = new Triangle();
            objt.X = 30;
            objt.Y = 30;
            objt.Z = 30;
            objt.ShowInfo();
            objt.TestTriangle();
            Console.WriteLine("\n");

            Account obja = new Account();
            obja.AccName = "Trixx";
            obja.AccId = "501";
            obja.Balance = 5000;
            obja.Deposit(3000);
            obja.Withdraw(2000);
            Console.WriteLine("\n");

            Course objc = new Course();
            objc.CourseName = "Physics 2";
            objc.CourseCode = "1101";
            objc.CourseCredit = 3;
            objc.ShowCourseInfo();
            Console.WriteLine("\n");

           
        }
    }
}

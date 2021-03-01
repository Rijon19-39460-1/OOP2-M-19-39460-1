using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Rijon", "19391", 3.7f);
            Student s2 = new Student("Rajon", "19392", 3.5f);
            Student s3 = new Student("Rion", "19393", 3.2f);
            Student s4 = new Student("Ripon", "19394", 3.0f);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Eng", "EEE");
            s1.Dept = d1;
            s2.Dept = d1;
            s3.Dept = d2;
            d1.AddStudent(s1, s2, s3);
            d2.AddStudent(s4);

            s1.ShowDepartmentInfo();
            s3.ShowDepartmentInfo();
            Console.WriteLine("__________________");
            d1.Name = "Computer Science & Eng";
            d1.Id = "CSE";
            s1.ShowDepartmentInfo();
            d1.PrintStudents();
            s4.Name = "Sipon";
            d2.PrintStudents();
        }
    }
}

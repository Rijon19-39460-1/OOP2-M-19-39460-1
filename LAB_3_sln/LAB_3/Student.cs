using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public string Name 
        {
            get { return name; }   
            set { name = value; }  
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public float CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:"  + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("cgpa: " + cgpa);
        }
    }
}

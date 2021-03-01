using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    class Department
    {
        private string name;
        private string id;
        private int studentcount;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private Student[] students;
        public void AddStudent(params Student[] stu)
        {
            foreach (Student s in stu)
            {
                students[studentcount++] = s;
                s.Dept = this;
            }
        }
        public void PrintStudents()
        {
            for(int i= 0; i<studentcount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Student GetStudent(string id)
        {
            return null;
        }
        public int Studentcount
        {
            get { return studentcount; }
            set { studentcount = value; }
        }
        public Department() {
            students = new Student[60];
        }

        public Department(string name,string id)
        {
            this.name = name;
            this.id = id;
            students = new Student[60];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
        }

    }
}

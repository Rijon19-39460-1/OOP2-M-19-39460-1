using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public String CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public String CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name = " + courseName);
            Console.WriteLine("Course Code = " + courseCode);
            Console.WriteLine("Course Credit = " + courseCredit);
        }
    }
}

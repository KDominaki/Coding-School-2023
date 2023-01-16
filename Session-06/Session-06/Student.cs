using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Course[] Course { get; set; }

        public Student()
        {

        }

        public Student(int regnum, Course[] course)
        {
            RegistrationNumber= regnum;
            Course = course;
        }

        public Student(int regnum)
        {
           RegistrationNumber= regnum;
        }

        public void Attend (Course course, DateTime datetime) { }
        public void WriteExam (Course course, DateTime datetime) { }
    }
}

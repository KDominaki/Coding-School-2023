using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public string Name { get; set; }      // I added name and surname to make it a little prettier
        public string Surname { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {

        }

        public Student(int regnum, List<Course>course)
        {
            Courses = course;
            RegistrationNumber= regnum;
        }

        public Student(int regnum, string name, string surname)
        {
           RegistrationNumber= regnum;
            Name = name;
            Surname = surname;
        }

        public void Attend (Course course, DateTime datetime) { }
        public void WriteExam (Course course, DateTime datetime) { }
    }
}

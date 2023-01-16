using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public Course[] Courses { get; set; }

        public Professor()
        {
            
        }
        public Professor(string rank)
        {
            Rank = rank;
        }
        public Professor(string rank, Course[] courses)
        {   Rank= rank;
            Courses = courses;
        }

        public void Teach(Course course, DateTime dateTime) { }
        public void SetGrade(Guid studentID, Guid courseID, Guid gradeID) { }
        public void GetName() { }
    }
}

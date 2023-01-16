using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class University
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get;set; }
        public Grade[] Grades { get; set; }
        public Scedule[] SceduledCourse { get; set; }

        public University()
        {

        }

        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime) { }
    }
}

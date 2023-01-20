using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class University
    {
        public List<Student> Students { get; set; }
        public List <Course> Courses { get;set; }
        public List<Grade> Grades { get; set; }
        public List<Scedule> SceduledCourse { get; set; }

        public University()
        {

        }

        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime) { }
    }
}

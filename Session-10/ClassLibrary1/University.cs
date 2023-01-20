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
        public List<Schedule> SceduledCourse { get; set; }

        public University()
        {

        }

        public void GetStudents() 
        {

            Student studentOne = new Student()
            {
                RegistrationNumber = 1
            };
            Students.Add(studentOne);
            
            Student studentTwo = new Student()
            {
                RegistrationNumber = 1,
            };
            Students.Add(studentTwo);
        }
        public void GetCourses() 
        {
            Course course = new Course("0001", "biology");
        }
        public void GetGrades() { }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime) { }
    }
}

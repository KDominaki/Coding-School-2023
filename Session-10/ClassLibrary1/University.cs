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
        public List<Schedule> ScheduledCourse { get; set; }

        public University()
        {

        }

        public void GetStudents() 
        {
            Students = new List<Student>();
            Student studentOne = new Student()
            {
                RegistrationNumber = 6,
            };
            Students.Add(studentOne);
            
            Student studentTwo = new Student()
            {
                RegistrationNumber = 9,
            };
            Students.Add(studentTwo);
        }
        public void GetCourses() 
        {
            Course course = new Course("0001", "biology");
        }
        public void GetGrades() 
        {
            Grades = new List<Grade>();

            Grade gradeOne = new Grade()
            {
                GradeNum = 90,
            };
            Grades.Add(gradeOne);
            Grade gradeTwo = new Grade()
            {
                GradeNum = 70,
            };
            Grades.Add(gradeTwo);
        }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime) { }
    }
}

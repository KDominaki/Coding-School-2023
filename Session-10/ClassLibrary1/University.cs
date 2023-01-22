using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void CreateStudentList()
        {
            Students = new List<Student>();
        }

        public void GetStudent(int registrationNum, string name, string surname)
        {
            Students.Add(new Student(registrationNum, name, surname));
        }

        public void GetCourses() 
        {
            Courses = new List<Course>();
            Course courseOne = new Course()
            {
                Subject = "Biology",
                Code = "00001"
            };
            Courses.Add(courseOne);
            Course courseTwo = new Course()
            {
                Subject = "Chemistry",
                Code = "00002"
            };
            Courses.Add(courseTwo);
        }
        public void GetGrades() 
        {
            Grades = new List<Grade>();

            Grade gradeOne = new Grade()
            {
                GradeNum = 90,
                StudentID = Guid.NewGuid(),
            };
            Grades.Add(gradeOne);
            Grade gradeTwo = new Grade()
            {
                GradeNum = 70,
                StudentID = Guid.NewGuid(),
            };
            Grades.Add(gradeTwo);
        }
        public void SetSchedule() 
        {
            ScheduledCourse = new List<Schedule>();

            Schedule schedOne = new Schedule() 
            {
                Callender= DateTime.Now,
                CourseID = Guid.NewGuid(),
                ProfessorID= Guid.NewGuid(),
                ID= Guid.NewGuid(),
            };
            ScheduledCourse.Add(schedOne);
            Schedule schedTwo = new Schedule()
            {
                Callender = DateTime.Now,
                CourseID = Guid.NewGuid(),
                ProfessorID= Guid.NewGuid(),
                ID= Guid.NewGuid(),
            };
            ScheduledCourse.Add(schedTwo);

        }
    }
}

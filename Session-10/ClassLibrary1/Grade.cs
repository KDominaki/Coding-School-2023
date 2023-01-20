using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    internal class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeNum { get; set; } /* Επειδή το 'Grade' που αναφέται στην άσκηση 'χτυπάει' του έδωσα αυτό το όνομα για
                                           * ξεχωρίζει απο το όνομα της κλάσης */
        public Grade()
        {

        }
        public Grade(Guid id, Guid studentId, Guid courseId, int gradeNum)
        {
            ID= id;
            StudentID= studentId;
            CourseID= courseId;
            GradeNum= gradeNum;
        }
    }
}

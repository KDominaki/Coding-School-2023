using Session30.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Web.Shared
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime HireDateStart = DateTime.Now;
        public DateTime HireDateEnd { get; set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}

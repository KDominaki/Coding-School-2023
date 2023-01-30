using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{                                       
    public enum EmployeeType {
        Manager,
        Staff
    }
    public class Employee : User
    {


        
        public EmployeeType EmpType { get; set;}
        public decimal SalaryPerMonth { get; set;}

        public Employee()
        {
            ID = Guid.NewGuid();   

        }




    }
}

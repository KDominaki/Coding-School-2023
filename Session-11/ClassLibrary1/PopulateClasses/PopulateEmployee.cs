using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Employee;

namespace ClassLibrary1.PopulateClasses {
    public class PopulateEmployee {
        public List<Employee> Employees { get; set; }
        public PopulateEmployee() { }
        //functions

        public List<Employee> PopulateEmployees() {
            //Employee(ID, Name, Surname, EmployeeType (enum), SallaryPerMonth)

            Employees = new List<Employee>();
            Guid id = Guid.Parse("{C903AB60-032B-4238-913E-624EB3B1FEED}");
            Employee employ1 = new Employee() {
                ID = id,
                Name = "Kwstantinos ",
                Surname = "Dimitropoulos",
                EmpType = EmployeeType.Manager,
                SalaryPerMonth = 1500
            };
            Employees.Add(employ1);
            id = Guid.Parse("{699F3547-EEEB-4534-A8A1-3120AFC946AF}");
            Employee employ2 = new Employee() {
                ID = id,
                Name = "Giannis ",
                Surname = "Dimitrakopoulopoulos",
                EmpType = EmployeeType.Manager,
                SalaryPerMonth = 1300
            };
            Employees.Add(employ2);
            id = Guid.Parse("{5EC26D15-A4B6-4A69-93DD-1C3470148A52}");
            Employee employ3 = new Employee() {
                ID = id,
                Name = "George ",
                Surname = "Paulidis",
                EmpType = EmployeeType.Staff,
                SalaryPerMonth = 800
            };
            Employees.Add(employ3);
            id = Guid.Parse("{E232C1A9-C759-408D-899D-EE74F3CFDD21}");
            Employee employ4 = new Employee() {
                ID = id,
                Name = "Panos ",
                Surname = "Kamenos",
                EmpType = EmployeeType.Staff,
                SalaryPerMonth = 900
            };
            Employees.Add(employ4);
            id = Guid.Parse("{53DFF695-8BBB-4341-8DE3-72FCA187F114}");
            Employee employ5 = new Employee() {
                ID = id,
                Name = "Telis ",
                Surname = "Praxitelis ",
                EmpType = EmployeeType.Staff,
                SalaryPerMonth = 600
            };
            Employees.Add(employ5);
            id = Guid.Parse("{AC892D3D-46BD-4348-A7B1-DD5280949A70}");
            Employee employ6 = new Employee() {
                ID = id,
                Name = "Alexandros ",
                Surname = "Alexandrou",
                EmpType = EmployeeType.Staff,
                SalaryPerMonth = 900
            };
            Employees.Add(employ6);
            //bsEmployees.DataSource = Employees;
            return Employees;

        }


    }
}

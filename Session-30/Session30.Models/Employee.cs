using Session30.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime HireDateEnd { get;set; }
        public int SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }


        public Employee(string name, string surname, int sallary)
        {
            Name = name;
            Surname = surname;
            SallaryPerMonth = sallary;
            HireDateStart = DateTime.Now;
            Transactions= new List<Transaction>();
        }

        // Relations
        public List<Transaction> Transactions { get; set; }

    }
}

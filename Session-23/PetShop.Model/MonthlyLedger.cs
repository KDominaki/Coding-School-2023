using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class MonthlyLedger
    {
        public decimal Expenses { get; set; }
        public decimal Income { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public IList<Employee> Employees { get; set; }

        public MonthlyLedger(IList<Transaction> transactions, IList<Employee> employees) 
        {
            Transactions = transactions;
            Employees = employees;
            Expenses= 2000;
            Date= DateTime.Now;
        }

        public void TotalCalc()
        {
            foreach(var transaction in Transactions)
            {
                if(transaction.Date.Month == Date.Month)
                {
                    Income += transaction.TotalPrice;
                }
                else { }
            }
            foreach(var employee in Employees)
            {
                Expenses += employee.SalaryPerMonth;
            }

            Total = Income - Expenses;
        }
    }
}

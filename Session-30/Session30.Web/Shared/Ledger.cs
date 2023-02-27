using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Web.Shared
{
    public class Ledger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public Rent Rent { get; set; }

        public Ledger(int month, int year)
        {
            Month = month;
            Year = year;
        }

        public void TotalCalc(IList<Transaction> transactions, IList<Employee> employees)
        {
            foreach (var transaction in transactions)
            {
                if (transaction.Date.Year == Year && transaction.Date.Month == Month)
                {
                    Income += transaction.TotalValue;
                }

            }
            foreach (var employee in employees)
            {
                if (employee.HireDateEnd.Year == 0001 && employee.HireDateStart.Year <= Year && employee.HireDateStart.Month <= Month)
                {
                    Expenses += employee.SallaryPerMonth;
                }

            }
            Expenses += Rent.Price;

            Total = Income - Expenses;
        }
    }
}

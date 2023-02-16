using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Model
{
    public class MonthlyLedger
    {
        public decimal Expenses { get; set; }
        public decimal Income { get; set; }
        public decimal Total { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public IList<Engineer> Engineers { get; set; }
        public IList<Manager> Managers{ get; set; }

        public MonthlyLedger( int year, int month, IList<Transaction> transactions, IList<Engineer> engineers, IList<Manager> managers)
        {
            Transactions = transactions;
            Engineers = engineers;
            Managers = managers;
            Year= year;
            Month= month;
            TotalCalc();
        }

        public void TotalCalc()
        {
            foreach (var transaction in Transactions)
            {
                if (transaction.Date.Month == Month & transaction.Date.Year == Year)
                {
                    Income += transaction.TotalPrice;
                }
                else { }
            }
            foreach (var employee in Engineers)
            {
                Expenses += employee.SalaryPerMonth;
            }
            foreach (var manager in Managers)
            {
                Expenses += manager.SalaryPerMonth;
            }

            Total = Income - Expenses;
        }
    }
}

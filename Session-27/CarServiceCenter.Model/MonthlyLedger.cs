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
        public DateTime Date { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public IList<Engineer> Engineers { get; set; }
        public IList<Manager> Managers{ get; set; }

        public MonthlyLedger(IList<Transaction> transactions, IList<Engineer> engineers, IList<Manager> managers)
        {
            Transactions = transactions;
            Engineers = engineers;
            Date = DateTime.Now;
            Managers = managers;
            TotalCalc();
        }

        public void TotalCalc()
        {
            foreach (var transaction in Transactions)
            {
                if (transaction.Date.Month == Date.Month)
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

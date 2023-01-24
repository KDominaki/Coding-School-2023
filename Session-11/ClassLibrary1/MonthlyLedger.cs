using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MonthlyLedger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? Incomee { get; set; }
        public decimal? Expense { get; set; } 
        public decimal? Total { get; set; }

        public List<Transaction> MonthlyTransactions = new List<Transaction>();

        public MonthlyLedger(int year, int month)
        {
            Year = year;
            Month = month;
            Expense += 2000;
        }

        public void IncomeCalc()
        {
            foreach (var item in MonthlyTransactions)
            {
                Incomee += item.TotalPrice;
            }
        }
        public void ExpenseCalc()
        {
            PetShop shop = new PetShop();
            foreach (var food in shop.Pets)
            {
                Expense += food.Cost;
            }
            foreach (var pet in shop.Foods)
            {
                Expense += pet.Cost;
            }
        }

        // TO DO
        public void GetMonthsTrans()
        {
            PetShop shop = new PetShop();
            foreach (var trans in shop.Transactions)
            {
                
            }
        }

        public void TotalCalc()
        {
            ExpenseCalc();
            IncomeCalc();
            Total = Incomee - Expense;
        }

    }
}

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

        public MonthlyLedger(int year, int month)
        {
            Year = year;
            Month = month;
            Expense += 2000;
        }

        public void IncomeCalc()
        {
            PetShop shop= new PetShop();
            foreach (var item in shop.Transactions)
            {
                Incomee += item.TotalPrice;
            }
        }
        public void ExpenseCalc()
        {
            PetShop shop = new PetShop();
            foreach (var food in shop.Foods)
            {
                Expense += food.Cost;
            }
            foreach (var pet in shop.Pets)
            {
                Expense += pet.Cost;
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

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
        public PetShop Petshop { get; set; }

        public List<Transaction> MonthlyTransactions = new List<Transaction>();

        public MonthlyLedger(int year, int month,PetShop petshop)
        {
            Petshop= petshop;
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
            
            foreach (var food in Petshop.MonthlyPets)
            {
                Expense += food.Cost;
            }
            foreach (var pet in Petshop.MonthlyFoods)
            {
                Expense += pet.Cost;
            }
        }

        public void GetMonthsTrans()
        {
            
            foreach (var trans in Petshop.Transactions)
            {
                if (trans.Date.Year == Year && trans.Date.Month == Month )
                {
                    MonthlyTransactions.Add( trans );
                }
                else { }

            }
        }

        public decimal? TotalCalc()
        {
            GetMonthsTrans();
            ExpenseCalc();
            IncomeCalc();
            Total = Incomee - Expense;
            return Total;
        }

    }
}

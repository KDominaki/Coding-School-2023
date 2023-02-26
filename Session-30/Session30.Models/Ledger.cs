﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Models
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
            Year= year;
        }

        public void TotalCalc(IList<Transaction> transactions, IList<Employee> employees)
        {
            foreach (Transaction transaction in transactions)
            {
                if(transaction.Date.Year == Year && transaction.Date.Month == Month)
                {
                    Income += transaction.TotalValue;
                }
                
            }
            foreach (Employee employee in employees)
            {
                if(employee.HireDateEnd.Year!= 0001)
                {
                    Expenses += employee.SallaryPerMonth;
                }

            }
            Expenses += Rent.Price;

            Total = Income - Expenses;
        }
    }
}

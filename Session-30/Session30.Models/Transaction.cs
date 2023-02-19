using Session30.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }

        public Transaction()
        {
            TransactionLines= new List<TransactionLine>();
        }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; }


        public void TotalValueCalc()
        {
            foreach (var line in TransactionLines)
            {
                TotalValue += line.TotalValue;
            }
       
        }

        public void PaymentMethodCheck()
        {
            if (TotalValue >= 50)
            {
                PaymentMethod = PaymentMethod.Cash;
            }

        }
    }
}

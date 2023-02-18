using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Models
{
    public class Customer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }


        public Customer()
        {

        }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }

   
}

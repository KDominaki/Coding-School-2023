using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            CardNumGenerator();
        }

        // Relations
        public List<Transaction> Transactions { get; set; }



        public void CardNumGenerator()
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8','9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'G', 'K','M','L','O','P'};
            string cardCode = "A";
            Random random= new Random();
            

            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(chars.Length);
                cardCode += chars[num];
            }

            CardNumber = cardCode;
        }
    }

   
}

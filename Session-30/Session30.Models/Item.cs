using Session30.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }


        public Item()
        {
            ItemCodeGenerator();
        }

        // Relations
        public List<TransactionLine> TransactionLines { get; set; }


        public void ItemCodeGenerator()
        {
            char[] chars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'G', 'K', 'M', 'L', 'O', 'P' };
            string cardCode = "";
            Random random = new Random();


            for (int i = 0; i < 19; i++)
            {
                int num = random.Next(chars.Length);
                cardCode += chars[num];
            }

            Code = cardCode;
        }
    }
}

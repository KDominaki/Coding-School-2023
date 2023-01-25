using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PetFood {
        public Guid ID { get; set; }
        public AnimalType Animaltype { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal? Qty { get; set; }
        public List<PetFoodTransaction> PetFoodTransactions = new List<PetFoodTransaction>();


        public PetFood() {
            Qty= 0;
        }

        public void SetQty() {

            foreach(var trans in PetFoodTransactions) {
                Qty += trans.Qty;
            }
        }

    }
}

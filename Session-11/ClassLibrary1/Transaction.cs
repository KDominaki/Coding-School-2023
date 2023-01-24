using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Transaction
    {
        public Guid? ID { get; set; }
        public DateTime? Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid? EmployeeID { get; set; }
        public Guid? PetID { get; set; }
        public decimal? PetPrice { get; set; }
        public Guid? PetFoodID { get; set; }
        public decimal? PetFoodQty { get; set; }
        public decimal? PetFoodPrice { get; set; }
        public decimal? TotalPrice { get; set; }

        public Transaction() {
            ID = Guid.NewGuid();
        }
        //public Transaction() { 
        //    ID = Guid.NewGuid();
        //    Date = DateTime.Now;
        //}


        public void SetTotalPrice(decimal petPrice, decimal petFoodQty, decimal petFoodPrice) {

            if(this.PetID != null) {
                this.TotalPrice = petPrice + (petFoodQty * petFoodPrice);
                this.PetFoodQty++;
            } else {
                this.TotalPrice = petPrice + (petFoodQty * petFoodPrice);
            }
        }
    }
}

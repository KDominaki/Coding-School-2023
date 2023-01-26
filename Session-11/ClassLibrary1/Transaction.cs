using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class Transaction {
        public Guid? ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid? EmployeeID { get; set; }
        public Guid? PetID { get; set; }
        public decimal? PetPrice { get; set; }
        public Guid? PetFoodID { get; set; }
        public decimal PetFoodQty { get; set; }
        public decimal? PetFoodPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        private bool _loaded = false;

        public Transaction() {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
            PetID = Guid.Empty;
            _loaded = false;
        }
        //public Transaction() { 
        //    ID = Guid.NewGuid();
        //    Date = DateTime.Now;
        //}




        public Transaction GetTransaction(List<Pet> pets, List<PetFood> foods) {
            try {
                if (_loaded == false) {
                    LoadTransaction(pets, foods);
                    _loaded = true;
                }
            }
            catch (Exception ex) {
                throw;
            }
            return this;

        }

        //load transaction
        public void LoadTransaction(List<Pet> pets, List<PetFood> foods) {

            PetFoodPrice = FindPetFoodPrice(foods);
            if (this.PetID != Guid.Empty) {
                PetPrice = FindPetPrice(pets);
                this.TotalPrice = PetPrice + (PetFoodQty * PetFoodPrice);
                this.PetFoodQty++;
            } else {
                this.TotalPrice = (PetFoodQty * PetFoodPrice);
            }

        }

        public decimal FindPetPrice(List<Pet> pets) {

            decimal price = 0;
            foreach (var pet in pets) {
                if (pet.ID == PetID) {
                    price = pet.Price;
                    break;
                }
            }
            return price;
        }

        public decimal FindPetFoodPrice(List<PetFood> foods) {
            decimal price = 0;
            foreach (var food in foods) {
                if (food.ID == PetFoodID) {
                    price = food.Price;
                    break;
                }
            }
            return price;
        }

        //public  GetTransaction(List<Pet> pets, List<PetFood> foods) {
        //    SetTotalPrice(pets,foods);
        //    return this;
        //}


    }
}

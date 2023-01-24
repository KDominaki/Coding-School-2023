using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class PetShop {

        //PROPERTIES
        public string Name { get; set; }
        public List<Transaction>? Transactions = new List<Transaction>();
        public List<PetFood>? Foods = new List<PetFood>();
        public List<Pet> Pets = new List<Pet>();
        public List<Employee> Employees = new List<Employee>();
        public List<Customer> Customers = new List<Customer>();

        public List<PetFood> MonthlyFoods = new List<PetFood>() { new PetFood(), new PetFood(), new PetFood() };
        public List<Pet> MonthlyPets = new List<Pet>();



        //CTOR
        public PetShop() {

        }

        public List<PetFood> GetPetFood() {

            foreach (var transaction in Transactions) {
                var foodID = transaction.PetFoodID;
                
                foreach(var food in Foods) {
                    if (food.ID == foodID) {
                       food.Qty -= transaction.PetFoodQty;
                    }
                }
            }
            return this.Foods;
        }



    }
}

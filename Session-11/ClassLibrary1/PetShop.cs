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

        public List<PetshopTransactions> PetshopTransactions= new List<PetshopTransactions>();


        //CTOR
        public PetShop() {

        }

        public List<PetFood> GetPetFood() {
            List<PetFood> petFoods = new List<PetFood>();

            foreach (var transaction in Transactions) {
                var foodID = transaction.PetFoodID;
                
                foreach(var food in Foods) {
                    if (food.ID == foodID) {
                        food.Qty -= transaction.PetFoodQty;
                    }
                }
            }
            return Foods;
        }



    }
}

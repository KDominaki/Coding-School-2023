using PopulateClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClassLibrary1.PopulateClasses {
    public class EngagePopulate {

        public EngagePopulate() { }

        
        public PetShop SetPopulation() {

            PopulatePetFood populatePetFood = new PopulatePetFood();
            PopulatePet populatePet = new PopulatePet();
            PopulateEmployee populateEmployees = new PopulateEmployee();
            PopulateCustomer populateCustomer = new PopulateCustomer();

            PetShop petshop = new PetShop() {
                Name = "Mr Pet",
                Foods = populatePetFood.PopulatePetFoods(),
                Pets = populatePet.PopulatePets(),
                Employees = populateEmployees.PopulateEmployees(),
                Customers = populateCustomer.PopulateCustomers()

            };
            

            PopulateTransaction populateTransaction = new PopulateTransaction();
            petshop.Transactions = populateTransaction.PopulateTransactions(petshop.Foods, petshop.Pets, petshop.Employees, petshop.Customers);
            SetBoughtDate(petshop.Pets, petshop.Transactions);
            //petShop.Transactions = new Populate
            return petshop;
        }

        
        public void SetBoughtDate(List<Pet> pets, List<Transaction> transactions) {

            foreach(var pet in pets) {
                foreach(var trans in transactions) {
                    if(pet.ID== trans.ID) {
                        pet.Bought = RandomDate(trans.Date);
                    }
                }
            }
        }
        public DateTime RandomDate(DateTime datebought) {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = ((TimeSpan)(datebought - start)).Days;
            return start.AddDays(gen.Next(range));
        }



    }
}

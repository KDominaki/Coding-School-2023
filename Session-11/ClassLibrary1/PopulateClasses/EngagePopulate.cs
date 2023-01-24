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
                Customers = populateCustomer.PopulateCustomers(),

            };

            PopulateTransaction populateTransaction = new PopulateTransaction();

            petshop.Transactions = populateTransaction.PopulateTransactions(petshop.Foods, petshop.Pets, petshop.Employees, petshop.Customers);

            //petShop.Transactions = new Populate





            return petshop;
        }



    }
}

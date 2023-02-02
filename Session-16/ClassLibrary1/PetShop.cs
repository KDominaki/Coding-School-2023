﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class PetShop {

        //PROPERTIES
        public string Name { get; set; }
        public List<PetFood> Foods = new List<PetFood>();
        public List<Pet> Pets = new List<Pet>();
        public List<Employee> Employees = new List<Employee>();
        public List<Customer> Customers = new List<Customer>();
        public List<Transaction> Transactions = new List<Transaction>();




        //CTOR
        public PetShop() {
        }

        public List<PetFood> GetPetFood() {

            foreach (var food in Foods) {
                foreach (var transaction in Transactions) {
                    var foodID = transaction.PetFoodID;
                    if (food.ID == foodID) {
                        food.Qty -= transaction.PetFoodQty;
                    }
                }
            }
            return Foods;
        }

        //ADD TRANSACTIONS
        public void AddTransactions(List<Transaction> transactions) {
            foreach (var transaction in transactions) {
                Transactions.Add(transaction.GetTransaction(Pets, Foods));
            }
        }



        //METHOD DELETE FUNCTION
        public void DeleteTransaction(Transaction input) { //or guid??

            foreach (var trans in Transactions) {
                if (trans.ID == input.ID) {
                    if (trans.PetID == Guid.Empty)
                        EnablePet(trans.PetID);
                    UpdatePetFoodQty(trans.PetFoodID, trans.PetFoodQty);
                    Transactions.Remove(trans);
                    break;
                }

            }
        }

        //RETRIEVE PETS
        public List<Pet> GetPets() {

            foreach(var trans in Transactions) {
                EnablePet(trans.PetID);

            }
            return Pets;
        }
        public void EnablePet(Guid? input) {
            foreach (var pet in Pets) {
                if (pet.ID == input) {
                    pet.Sold = true;
                    break;
                }
            }
        }



        public void UpdatePetFoodQty(Guid? input, decimal foodupdate) {
            foreach (var food in Foods) {
                if (food.ID == input) {
                    food.Qty += foodupdate;
                }
            }

        }

        //DELETE PET FOOD
        public void DeletePetFood(Guid? input) {
            foreach (var food in Foods) {
                if (food.ID == input) {
                    Foods.Remove(food);
                }
            }
        }

        //DELETE PET
        public void DeletePet(Guid? input) {
            foreach (var pet in Pets) {
                if (pet.ID == input) {
                    Pets.Remove(pet);
                }
            }
        }


        

    }
}

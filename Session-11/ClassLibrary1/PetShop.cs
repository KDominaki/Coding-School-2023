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
        public List<Customer> Customer = new List<Customer>();
        
        //CTOR
        public PetShop() {
            Name = "The Pet";
            Transactions.Add(new Transaction() {
                
            });
        }

        

    }
}

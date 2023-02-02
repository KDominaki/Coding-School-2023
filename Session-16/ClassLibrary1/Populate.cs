using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Populate
    {
        
        public List<string> names = new List<string>()
        {
            "Giannis",
            "Petros",
            "Anastasis",
            "Popos"
        };

        public List<string> surnames = new List<string>()
        {
            "Pordos",
            "Anastasiou",
            "Iordani",
            "Kokotas"
        };

        Random rnd = new Random();
        
        

        public void PopulateTrans(List<Transaction> transList)
        {
            Transaction trans1 = new Transaction()
            {
                TotalPrice= 1000,
            };
            transList.Add(trans1);
        }

        public void PopulateCustomers(List<Customer> customerList)
        {
            int randNameInt = rnd.Next(names.Count);
            int randSurnameInt = rnd.Next(surnames.Count);

            Customer customer1 = new Customer()
            {
                Name = names[randNameInt],
                Surname = surnames[randSurnameInt],
            };
            customerList.Add(customer1);
        }
    }
}

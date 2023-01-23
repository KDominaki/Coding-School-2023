using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pet
    {
        enum AnimalType
        {
            Dog,
            Cat,
            Parrot

        }
        enum PetStatus
        {
            Ok,
            Unhealthy,
            Recovering

        }
        public Guid ID { get; set; }

        public string? Breed { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

            
    }
}

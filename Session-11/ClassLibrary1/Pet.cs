using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pet
    {
        public enum AnimalType { }

        public enum PetStatus { }

        public Guid ID { get; set; }

        public string? Breed { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public Pet()
        {

        }

            
    }
}

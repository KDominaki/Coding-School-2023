using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 {
    public class Pet {
        public AnimalType Animaltype { get; set; }

        public PetStatus Petstatus { get; set; }

        public Guid ID { get; set; }

        public string? Breed { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public DateTime Bought { get; set; }

        public bool Sold { get; set; }

        public Pet() {
            DateTime dt = new DateTime(1990, 1, 1);
            Bought = dt;
            Sold = false;

        }


    }
}

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateClassLibrary {
    public class PopulatePet {

        public PopulatePet() {

        }

        public List<Pet> PopulatePets() {

            Pet pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.OK,
                ID = Guid.NewGuid(),
                Breed = "Labrador",
                Price = 1500,
                Cost = 1000,

            };




            return new List<Pet>();

        }


    }
}

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

            List <Pet> pets = new List <Pet>();

            Pet pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.OK,
                ID = Guid.NewGuid(),
                Breed = "Labrador",
                Price = 1500,
                Cost = 1000,

            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.OK,
                ID = Guid.NewGuid(),
                Breed = "Siamese",
                Price = 1300,
                Cost = 900,

            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.OK,
                ID = Guid.NewGuid(),
                Breed = "Siamese",
                Price = 1300,
                Cost = 900,

            };
            pets.Add(pet);
            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.Unhealthy,
                ID = Guid.NewGuid(),
                Breed = "Siamese",
                Price = 1300,
                Cost = 900,

            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.OK,
                ID = Guid.NewGuid(),
                Breed = "Himalayan",
                Price = 1400,
                Cost = 1000,

            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.Recovering,
                ID = Guid.NewGuid(),
                Breed = "Malinois",
                Price = 1300,
                Cost = 800,

            };
            pets.Add(pet); 
            
            pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.Recovering,
                ID = Guid.NewGuid(),
                Breed = "Malinois",
                Price = 1300,
                Cost = 800,

            };
            pets.Add(pet);





            return new List<Pet>();

        }


    }
}

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

            List<Pet> pets = new List<Pet>();

            Pet pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{BC9B4A5D-3663-46B4-8578-E94EE1E5D452}"),
                Breed = "Labrador",
                Price = 1500,
                Cost = 1000,

            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{055A7F84-1EA5-430D-AC88-72EE519EB5DE}"),
                Breed = "Siamese",
                Price = 1300,
                Cost = 900,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{A639ABBD-B2E0-45EA-967A-38681FDF22ED}"),
                Breed = "West Highland",
                Price = 1000,
                Cost = 700,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Parrot,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{57AF4991-7A8B-48CF-8BAF-3C9E7AA69855}"),
                Breed = "Parakeet",
                Price = 100,
                Cost = 20,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.Recovering,
                ID = Guid.Parse("{F44DA0A9-DE5D-4D49-AFFF-83E49B2B7CE0}"),
                Breed = "Siamese",
                Price = 1300,
                Cost = 900,
            };
            pets.Add(pet);
            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.Unhealthy,
                ID = Guid.Parse("{E563D602-2C83-4457-AD7E-9D7D90BCB974}"),
                Breed = "Sphynx",
                Price = 1300,
                Cost = 900,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Cat,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{B5F45E06-3AE4-4E17-9DBF-9A9F46B0B8B1}"),
                Breed = "Himalayan",
                Price = 1400,
                Cost = 1000,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Dog,
                Petstatus = PetStatus.Recovering,
                ID = Guid.Parse("{D833D529-8C94-451E-B4B2-83E55A9FAA6D}"),
                Breed = "Malinois",
                Price = 1300,
                Cost = 800,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Parrot,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{3ED3C244-D9E2-4D10-A963-7098FCEDEA28}"),
                Breed = "Macaw",
                Price = 2000,
                Cost = 1200,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Parrot,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{65689F6F-F4A9-4297-99A0-252702C6C7A2}"),
                Breed = "Macaw",
                Price = 2000,
                Cost = 1200,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Parrot,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{6A3C6516-3DFA-4341-A984-72B0C2EBE5FF}"),
                Breed = "African Grey",
                Price = 1400,
                Cost = 900,
            };
            pets.Add(pet);

            pet = new Pet() {
                Animaltype = AnimalType.Parrot,
                Petstatus = PetStatus.OK,
                ID = Guid.Parse("{84AE443B-869C-41FB-B5D8-2E38E2A77AA2}"),
                Breed = "Cockatiel",
                Price = 200,
                Cost = 80,
            };
            pets.Add(pet);

            //bsPet.DataSource = pets
            return pets;


        }

    }
}

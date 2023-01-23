using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateClassLibrary {
    public class PopulatePetFood {

        public PopulatePetFood() {

        }

        public List<PetFood> PopulatePetFoods() {

            List<PetFood> petFood = new List<PetFood>();

            PetFood pf = new PetFood() {
                ID = Guid.Parse("{9B32B5C2-12F5-467F-8D68-FAD67DD51127}"),
                Animaltype = AnimalType.Cat,
                Price = 10,
                Cost = 5,
                Description = "Package",
            };
            petFood.Add(pf);

            pf = new PetFood() {
                ID = Guid.Parse("{26445DFE-E16F-4617-B41E-F1CAC462DB74}"),
                Animaltype = AnimalType.Cat,
                Price = 7,
                Cost = 3,
                Description = "Bulk",
            };
            petFood.Add(pf);

            pf = new PetFood() {
                ID = Guid.Parse("{077D965F-7ECA-44CD-8DB1-70BB6CCF74A4}"),
                Animaltype = AnimalType.Dog,
                Price = 11,
                Cost = 6,
                Description = "Package",
            };
            petFood.Add(pf);

            pf = new PetFood() {
                ID = Guid.Parse("{FA3827F3-190B-4DE0-808E-A2C31E6018E0"),
                Animaltype = AnimalType.Dog,
                Price = 8,
                Cost = 4,
                Description = "Bulk",
            };
            petFood.Add(pf);

            pf = new PetFood() {
                ID = Guid.Parse("{6F7CF917-982E-47F4-98B0-C8445F094C8E}"),
                Animaltype = AnimalType.Parrot,
                Price = 4,
                Cost = 2,
                Description = "Package",
            };
            petFood.Add(pf);

            //bsPetFood.DataSource = petFood;            
            return petFood;
        }


    }
}

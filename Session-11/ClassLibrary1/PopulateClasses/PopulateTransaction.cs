using ClassLibrary1;
using ClassLibrary1.PopulateClasses;
using PopulateClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateClassLibrary {
    public class PopulateTransaction {

        public PopulateTransaction() {

        }

        public List<Transaction> PopulateTransactions(List<PetFood> foods, List<Pet> pets, List<Employee> employees, List<Customer> customers) {

            List<Transaction> transactions = new List<Transaction>();
            Transaction tr;

            /*1*/



            int petIndex = 0;
            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 1),
                CustomerID = customers[0].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetID = pets[petIndex].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);
            /*2*/
            petIndex = 1;
            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 2, 2),
                CustomerID = customers[1].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetID = pets[petIndex].ID,
                PetFoodID = foods[0].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            /*3*/
            petIndex = 3;
            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 3, 3),
                CustomerID = customers[2].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetID = pets[petIndex].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);
            /*4*/
            petIndex = 8;
            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 4, 4),
                CustomerID = customers[3].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetID = pets[petIndex].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            /*5*/
            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 5, 5),
                CustomerID = customers[4].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 6, 6),
                CustomerID = customers[5].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 7, 7),
                CustomerID = customers[6].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 8, 8),
                CustomerID = customers[7].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 9, 9),
                CustomerID = customers[8].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 10, 10),
                CustomerID = customers[9].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 11, 11),
                CustomerID = customers[10].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 12),
                CustomerID = customers[11].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 1, 2),
                CustomerID = customers[12].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 2, 3),
                CustomerID = customers[13].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 2, 4),
                CustomerID = customers[14].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2023, 1, 15),
                CustomerID = customers[15].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2023, 1, 13),
                CustomerID = customers[16].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2023, 1, 2),
                CustomerID = customers[16].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 5, 15),
                CustomerID = customers[17].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 8, 22),
                CustomerID = customers[18].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 6, 29),
                CustomerID = customers[19].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 4, 1),
                CustomerID = customers[20].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 6, 1),
                CustomerID = customers[3].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 7, 1),
                CustomerID = customers[1].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty(),
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 8, 1),
                CustomerID = customers[2].ID,
                EmployeeID = employees[RandomEmployee(employees)].ID,
                PetFoodQty = RandomQty()
            };

            tr = SetPetAndFood(tr, pets, foods, petIndex);
            transactions.Add(tr);
            
            return transactions;
        }


        public Transaction SetPetAndFood(Transaction tr, List<Pet> pets, List<PetFood> foods, int petIndex) {

            var newPet = pets[petIndex];
            if (tr.PetID != Guid.Empty) {
                //tr.PetPrice = tr.FindPetPrice(pets, tr.PetID);
                foreach (var food in foods) {
                    if (food.Animaltype == newPet.Animaltype) {
                        tr.PetFoodID = food.ID;
                        break;
                    }
                }
                // tr.PetFoodPrice = tr.FindPetFoodPrice(foods, tr.PetFoodID);

            } else {
                tr.PetFoodID = RandomPetFood(foods);

            }
            //tr.PetFoodPrice = tr.FindPetFoodPrice(foods, tr.PetFoodID);
            //tr.SetTotalPrice(tr.PetPrice, tr.PetFoodQty, tr.PetFoodPrice);
            return tr;
        }



        public int RandomEmployee(List<Employee> employees) {
            var random = new Random();
            int employee = random.Next(1, employees.Count);
            return employee;
        }

        public int RandomQty() {
            var random = new Random();
            int employee = random.Next(1, 20);
            return employee;
        }

        public Guid RandomPetFood(List<PetFood> foods) {
            var random = new Random();
            var pf = foods[random.Next(0, foods.Count)].ID;
            return pf;
        }

        public T RandomEnumValue<T>() {
            Random random = new Random();
            var v = Enum.GetValues(typeof(AnimalType));
            return (T)v.GetValue(random.Next(v.Length));
        }


    }







}

//customerIDS
//"{E02ACE2B-6B49-49B6-8BB4-D0CBE5ECA72A}"
//"{72074A45-1D3A-4652-B869-4215B6AFBC56}"
//"{B59FD327-D225-43BB-85D6-CDD074BF55D9}"
//"{7DDB6C5B-7782-4D49-A0A3-1BBFA033367A}"
//"{1E64FAA9-2F6E-412D-833F-896B4399B4F8}"
//"{03F5452B-FC74-4BB5-9E8B-172B6DA2074B}"
//"{CE74C7FC-10A5-45A8-BA36-64ED89430CDB}"
//"{FCC41A27-DB30-4C15-BB2C-42EBFF8876C9}"
//"{0E370B49-55E5-4E1F-A99D-7738031D2F4C}"
//"{0CE6DD87-F659-48F4-841A-A8AEDB948B40}"
//"{FD57B59F-5F0F-4F68-8ECF-9EEE6FFB7F3C}"
//"{8C10F01A-7E02-4D17-9CDA-FE8A730141C7}"
//"{D677722D-3F7E-41E6-970E-F8BF4DA3EF0C}"
//"{8718DDB0-242D-4DFB-A252-0E8EA2FBCA8A}"
//"{0E0DB8C6-C33B-442F-B833-247A6D5F76AD}"
//"{70EA19B5-D290-4D70-9AA8-F5A924391D02}"
//"{BB20D515-B903-4FC8-B3E0-7489C2D14106}"
//"{11B330F2-2CD7-472D-A094-D6B949FB747F}"
//"{6280792A-C308-43B6-A81B-D5814A84C49E}"
//"{6280792A-C308-43B6-A81B-D5814A84C49E}"
//"{6C0EB44A-1025-42A3-834A-A19AD382FBE7}"

//empoyeeIDS
//"{C903AB60-032B-4238-913E-624EB3B1FEED}"
//"{699F3547-EEEB-4534-A8A1-3120AFC946AF}"
//"{5EC26D15-A4B6-4A69-93DD-1C3470148A52}"
//"{E232C1A9-C759-408D-899D-EE74F3CFDD21}"
//"{53DFF695-8BBB-4341-8DE3-72FCA187F114}"
//"{AC892D3D-46BD-4348-A7B1-DD5280949A70}"

//PetIDs
//"{BC9B4A5D-3663-46B4-8578-E94EE1E5D452}"
//"{055A7F84-1EA5-430D-AC88-72EE519EB5DE}"
//"{A639ABBD-B2E0-45EA-967A-38681FDF22ED}"
//"{
//}"
//"{F44DA0A9-DE5D-4D49-AFFF-83E49B2B7CE0}"
//"{E563D602-2C83-4457-AD7E-9D7D90BCB974}"
//"{B5F45E06-3AE4-4E17-9DBF-9A9F46B0B8B1}"
//"{D833D529-8C94-451E-B4B2-83E55A9FAA6D}"
//"{3ED3C244-D9E2-4D10-A963-7098FCEDEA28}"
//"{65689F6F-F4A9-4297-99A0-252702C6C7A2}"
//"{6A3C6516-3DFA-4341-A984-72B0C2EBE5FF}"
//"{84AE443B-869C-41FB-B5D8-2E38E2A77AA2}"



//PetFoodID
//"{9B32B5C2-12F5-467F-8D68-FAD67DD51127}"
//"{26445DFE-E16F-4617-B41E-F1CAC462DB74}"
//"{077D965F-7ECA-44CD-8DB1-70BB6CCF74A4}"
//"{FA3827F3-190B-4DE0-808E-A2C31E6018E0}"
//"{6F7CF917-982E-47F4-98B0-C8445F094C8E}"
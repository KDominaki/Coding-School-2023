﻿using ClassLibrary1;
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
            //"{57AF4991-7A8B-48CF-8BAF-3C9E7AA69855}"
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

            tr = new Transaction() {
                ID = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 1),
                CustomerID = Guid.Parse("{E02ACE2B-6B49-49B6-8BB4-D0CBE5ECA72A}"),
                EmployeeID = Guid.Parse("{C903AB60-032B-4238-913E-624EB3B1FEED}"),
                PetID = Guid.Parse("{BC9B4A5D-3663-46B4-8578-E94EE1E5D452}"),
                PetFoodID = Guid.Parse("{9B32B5C2-12F5-467F-8D68-FAD67DD51127}"),
                //PetPrice = /* Pet.GetPetPrice()  !!!!!!!
                PetFoodQty = 3,
                //PetFoodPrice = /* PetFood.GetPetPrice()  !!!!!!!
                //TotalPrice = tr.GetTotalPrice();
            };

            decimal petprice = 0;
            //foreach(var pet in pets) {
            //    if(pet.ID == tr.PetID) {
            //        petprice = pet.Price;
            //    }
            //}



            transactions.Add(tr);

            return transactions;
        }












    }
}









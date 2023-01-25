using ClassLibrary1;
using System.Numerics;
using System.Xml.Linq;

namespace PopulateClassLibrary {
    public class PopulateCustomer {
        public List<Customer> Customers { get; set; }
        public PopulateCustomer() { }

        //Customer(ID, Name, Surname, Phone, TIN)

        public List<Customer> PopulateCustomers() {
            Customers = new List<Customer>();
            Guid id = Guid.Parse("{E02ACE2B-6B49-49B6-8BB4-D0CBE5ECA72A}");

            Customer customr1 = new Customer() {
                ID = id,
                Name = " John",
                Surname = "Papajohn ",
                Phone = " 555-555-55",
                TIN = 754973398

            };
            Customers.Add(customr1);
            id = Guid.Parse("{72074A45-1D3A-4652-B869-4215B6AFBC56}");
            Customer customr2 = new Customer() {
                ID = id,
                Name = " Charis",
                Surname = "Charoulis ",
                Phone = "175-124-56 ",
                TIN = 628922401

            };
            Customers.Add(customr2);
            id = Guid.Parse("{B59FD327-D225-43BB-85D6-CDD074BF55D9}");
            Customer customr3 = new Customer() {
                ID = id,
                Name = "Zisis  ",
                Surname = "Zisakos ",
                Phone = " 785-968-42",
                TIN = 446837191
            };
            Customers.Add(customr3);
            id = Guid.Parse("{7DDB6C5B-7782-4D49-A0A3-1BBFA033367A}");
            Customer customr4 = new Customer() {
                ID = id,
                Name = " Kostas",
                Surname = "Mitrogol ",
                Phone = " 697-333-22",
                TIN = 445288769

            };
            Customers.Add(customr4);
            id = Guid.Parse("{1E64FAA9-2F6E-412D-833F-896B4399B4F8}");
            Customer customr5 = new Customer() {
                ID = id,
                Name = " Panos",
                Surname = "Korgialas ",
                Phone = "547-231-56 ",
                TIN = 884731946

            };
            Customers.Add(customr5);
            id = Guid.Parse("{03F5452B-FC74-4BB5-9E8B-172B6DA2074B}");
            Customer customr6 = new Customer() {
                ID = id,
                Name = " Betty",
                Surname = " Tzanabetty",
                Phone = " 684-987-02",
                TIN = 306673273

            };
            Customers.Add(customr6);
            id = Guid.Parse("{CE74C7FC-10A5-45A8-BA36-64ED89430CDB}");
            Customer customr7 = new Customer() {
                ID = id,
                Name = "Kiki ",
                Surname = " Chainoglou",
                Phone = " 547-968-03",
                TIN = 283644501

            };
            Customers.Add(customr7);
            id = Guid.Parse("{FCC41A27-DB30-4C15-BB2C-42EBFF8876C9}");
            Customer customr8 = new Customer() {
                ID = id,
                Name = " Katerina",
                Surname = " Papoutsaki",
                Phone = "6975462741 ",
                TIN = 553492244

            };
            Customers.Add(customr8);
            id = Guid.Parse("{0E370B49-55E5-4E1F-A99D-7738031D2F4C}");
            Customer customr9 = new Customer() {
                ID = id,
                Name = " Margarita",
                Surname = " Margarw",
                Phone = "875-923-61 ",
                TIN = 953276482

            };
            Customers.Add(customr9);
            id = Guid.Parse("{0CE6DD87-F659-48F4-841A-A8AEDB948B40}");
            Customer customr10 = new Customer() {
                ID = id,
                Name = "Kostas ",
                Surname = " Prekas",
                Phone = "333-333-33",
                TIN = 815961484
            };
            Customers.Add(customr10);
            id = Guid.Parse("{FD57B59F-5F0F-4F68-8ECF-9EEE6FFB7F3C}");
            Customer customr11 = new Customer() {
                ID = id,
                Name = " Rita",
                Surname = " Ritaki",
                Phone = " 741-852-96",
                TIN = 502359064

            };
            Customers.Add(customr11);
            id = Guid.Parse("{8C10F01A-7E02-4D17-9CDA-FE8A730141C7}");
            Customer customr12 = new Customer() {
                ID = id,
                Name = " Petros",
                Surname = " Petran",
                Phone = "652-869-14 ",
                TIN = 509193280

            };
            Customers.Add(customr12);
            id = Guid.Parse("{D677722D-3F7E-41E6-970E-F8BF4DA3EF0C}");
            Customer customr13 = new Customer() {
                ID = id,
                Name = " Tasos",
                Surname = " Stotoglou",
                Phone = "452-864-21 ",
                TIN = 467293702

            };
            Customers.Add(customr13);
            id = Guid.Parse("{8718DDB0-242D-4DFB-A252-0E8EA2FBCA8A}");
            Customer customr14 = new Customer() {
                ID = id,
                Name = "Christos ",
                Surname = " Christakis",
                Phone = "745-632-28 ",
                TIN = 845869088

            };
            Customers.Add(customr14);
            id = Guid.Parse("{0E0DB8C6-C33B-442F-B833-247A6D5F76AD}");
            Customer customr15 = new Customer() {
                ID = id,
                Name = "Makis ",
                Surname = " Dimakis",
                Phone = "666-564-89 ",
                TIN = 864497747

            };
            Customers.Add(customr15);
            id = Guid.Parse("{70EA19B5-D290-4D70-9AA8-F5A924391D02}");
            Customer customr16 = new Customer() {
                ID = id,
                Name = "Nikitas ",
                Surname = "Avramopoulos ",
                Phone = " 754-698-25",
                TIN = 337176076
            };
            Customers.Add(customr16);
            id = Guid.Parse("{BB20D515-B903-4FC8-B3E0-7489C2D14106}");
            Customer customr17 = new Customer() {
                ID = id,
                Name = "Marina ",
                Surname = "Marteli ",
                Phone = "541-856-12 ",
                TIN = 810889396

            };
            Customers.Add(customr17);
            id = Guid.Parse("{11B330F2-2CD7-472D-A094-D6B949FB747F}");
            Customer customr18 = new Customer() {
                ID = id,
                Name = "Marios",
                Surname = " Marinos",
                Phone = " 547-868-20",
                TIN = 481785620

            };
            Customers.Add(customr18);
            id = Guid.Parse("{6280792A-C308-43B6-A81B-D5814A84C49E}");
            Customer customr19 = new Customer() {
                ID = id,
                Name = " Mitsos",
                Surname = " Karamanlis",
                Phone = " 745-862-31",
                TIN = 636173102

            };
            Customers.Add(customr19);
            id = Guid.Parse("{6280792A-C308-43B6-A81B-D5814A84C49E}");
            Customer customr20 = new Customer() {
                ID = id,
                Name = " Filos",
                Surname = " Filou",
                Phone = "666-666-66 ",
                TIN = 224332369

            };
            Customers.Add(customr20);
            id = Guid.Parse("{6C0EB44A-1025-42A3-834A-A19AD382FBE7}");
            Customer customr21 = new Customer() {
                ID = id,
                Name = "Paris ",
                Surname = " Pateras",
                Phone = " 444-444-44",
                TIN = 194530022

            };
            Customers.Add(customr21);


            //bsCustomer.DataSource = Customers;
            return Customers;
        }






    }
}
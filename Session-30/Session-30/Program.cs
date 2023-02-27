// See https://aka.ms/new-console-template for more information
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Models.Enums;
using System.Diagnostics;


//Item item = new Item(400, 600, ItemType.Fuel)
//{
//    Description = "bbbbbb"
//};
RentRepo repo = new RentRepo();
Rent rent = new Rent()
{
    Price = 5000
};

repo.Add(rent);



Console.WriteLine("In theory its done");

Console.ReadLine();

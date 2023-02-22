// See https://aka.ms/new-console-template for more information
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Models.Enums;
using System.Diagnostics;


//Item item = new Item(400, 600, ItemType.Fuel)
//{
//    Description = "bbbbbb"
//};

ItemRepo repo = new ItemRepo();

//repo.Add(item);

repo.Delete(1);
var list = repo.GetAll();

Console.WriteLine(list.Count);
Console.WriteLine("In theory its done");

Console.ReadLine();

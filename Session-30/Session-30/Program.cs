// See https://aka.ms/new-console-template for more information
using Session30.Models;
using Session30.Models.Enums;
using System.Diagnostics;

Item item= new Item()
{
    Price = 30,
    ItemType = ItemType.Fuel,
};


TransactionLine transl1 = new TransactionLine()
{
    Item = item,
    ItemPrice = item.Price,
    Quantity = 1,
    
};

TransactionLine transl2 = new TransactionLine()
{
    Item = item,
    ItemPrice = item.Price,
    Quantity = 1,
};

transl1.TotalValueCalc();
transl2.TotalValueCalc();

Transaction trans = new Transaction()
{
    PaymentMethod = PaymentMethod.CreditCard
};

trans.TransactionLines.Add(transl1);
trans.TransactionLines.Add(transl2);

trans.TotalValueCalc();
trans.PaymentMethodCheck();


Console.WriteLine(trans.TotalValue);
Console.WriteLine(trans.PaymentMethod);
Console.WriteLine(transl1.DiscountPercent);

Console.ReadLine();

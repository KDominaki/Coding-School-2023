﻿// See https://aka.ms/new-console-template for more information
using Session_05;
// Question 1

// Question 2
UsersNum numForCalc = new UsersNum();

Console.WriteLine("Please enter an intiger:");
int usersNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Would you like to sum all the numbers up to {usersNumber}, or to multiply them? (enter 'S' to sum or 'M' to multiply");
string calculation = Console.ReadLine();

if ( calculation == "S")
{
    Console.WriteLine(numForCalc.SumAll(usersNumber));
}
else if ( calculation == "M")
{
    Console.WriteLine(numForCalc.ProductAll(usersNumber));
}
else
{
    Console.WriteLine("I am sorry but this wasn't an acceptable asnwer");
}


// Question 3

// Question 4

// Question 5

Console.ReadLine();
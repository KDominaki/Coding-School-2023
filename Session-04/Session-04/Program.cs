// See https://aka.ms/new-console-template for more information

// 1. Write a C# program to print Hello and your name in the same line
string name = "Kostas";
Console.WriteLine("Hello " + name);

// 2. Write a C# program to print the sum of two numbers and the devision of those numbers
int num1 = 12;
int num2 = 6;
int sum = num1 + num2;
float division = num1 / num2;

Console.WriteLine(num1 + "+" + num2 + "=" + sum + " and " + num1 + "/" + num2 + "=" + division);

// 3.>> the result of the specified operstions

/* 4.Write a C# program that assigns an age (number) (for example 20) and 
 * a gender (string) (for example female) and displays something like: "You are female and look younger than 20."*/

string gender = "female";
short age = 20;

Console.WriteLine("You are "+gender+" and you are "+age);

Console.ReadLine();

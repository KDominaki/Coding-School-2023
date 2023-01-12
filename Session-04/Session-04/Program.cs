// See https://aka.ms/new-console-template for more information

// 1. Write a C# program to print Hello and your name in the same line
string name = "Kostas";
Console.WriteLine("Hello " + name);

// 2. Write a C# program to print the sum of two numbers and the devision of those numbers
int num1 = 12;
int num2 = 6;
int sum = num1 + num2;
float division = num1 / num2;

Console.WriteLine($"{num1}+{num2}={sum} and {num1}/{num2}={division}");

// 3.>> the result of the specified operstions

int firstOp = -1 + (5 * 6);
int secondOp = 38 + (5 % 7);
int thirdOp = 14 + ((-3 * 6) / 7);
double forthOp = 2 + ((13 / 6) * 6) + Math.Sqrt(7);
double fithOp = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);

Console.WriteLine($"1st operation= {firstOp}, 2nd= {secondOp}, 3rd= {thirdOp}, 4th={forthOp} and the 5th= {fithOp}" );

/* 4.Write a C# program that assigns an age (number) (for example 20) and 
 * a gender (string) (for example female) and displays something like: "You are female and look younger than 20."*/

string gender = "female";
ushort age = 20;

Console.WriteLine($"You are a {gender} and you are {age} years old");



//5. Write a C# program that takes an integer representing seconds (for example 45678) and converts it to : min, h, d, y

uint secs = 45678;
uint secsToMinutes = secs / 60;
uint secsToHours = secsToMinutes / 60;
uint secsToDays = secsToHours / 24;
uint secsToYears = secsToDays / 365;

Console.WriteLine($"{secs} seconds are {secsToMinutes} minutes, {secsToHours} hours, {secsToDays} days and {secsToYears} years");


//6. Rewrite Program #5 using .Net Libraries. 

TimeSpan seconds = TimeSpan.FromSeconds(secs);
int minutes = Convert.ToInt32(seconds.TotalMinutes);
int hours = Convert.ToInt32(seconds.TotalHours);
int days = Convert.ToInt32(seconds.TotalDays);
Console.WriteLine($"{secs} seconds are {minutes} minutes, {hours} hours {days} days and {days/365}");

//7. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

int celsius = 18;
int celciusToKelvin = celsius + 273;
int celciusToFahrenheit = celsius * (9 / 5) + 32;

Console.WriteLine($"{celsius} Celsius are {celciusToKelvin} Kelvin and {celciusToFahrenheit} Fahrenheit");

Console.ReadLine();
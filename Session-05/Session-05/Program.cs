// See https://aka.ms/new-console-template for more information
using Session_05;
// Question 1

// Question 2
UsersNum numForCalc = new UsersNum();

Console.WriteLine("Please enter an intiger:");
int usersNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Would you like to sum all the numbers up to {usersNumber}, or to multiply them? (enter 'S' to sum or 'M' to multiply)");
string calculation = Console.ReadLine().ToUpper();

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

Console.WriteLine("Give me a number and i will give you all the prime numbers up to this number:");
usersNumber= Convert.ToInt32(Console.ReadLine());

int[] primes = new int[usersNumber];

for (int i = 1; i < usersNumber; i++)
{
    if (i == 2)
    {
        primes[i-1] = i;
    }
    else if (i % 2 != 0) 
    {
        primes[i-1] = i;
    }
    else {}
}

foreach (int num in primes)
{
    if(num == 0) { }
    else { Console.WriteLine(num); }
    
}



// Question 4

// Question 5

Console.ReadLine();
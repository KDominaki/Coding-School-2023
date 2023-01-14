// See https://aka.ms/new-console-template for more information
using Session_05;


// Question 1
ReverseString revName= new ReverseString();
string name = "Kostas";

Console.WriteLine(revName.Reverse(name));


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
usersNumber = Convert.ToInt32(Console.ReadLine());

int[] primes = new int[usersNumber];

for (int i = 1; i <= usersNumber; i++)
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
Console.ReadLine();


// Question 4

int[] array1 = { 2, 4, 9, 12 };
int[] array2 = {1, 3, 7, 10};
int[] newArray = new int[array1.Length*array2.Length];

for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        newArray[i * array2.Length + j] = array1[i] * array2[j];
    }
}
foreach (int num in newArray) { Console.WriteLine(num); }


// Question 5

int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

for (int i = 0; i < array.Length; i++)
{
    for (int j = i; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            int temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        
    }   
}
foreach(int num in array) { Console.WriteLine(num); }

Console.ReadLine();
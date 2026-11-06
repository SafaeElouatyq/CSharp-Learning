
/* Console.WriteLine("-----------the happy birthday song--------------- ");

Console.WriteLine("enter your name : ");

String name = Console.ReadLine();

Console.WriteLine("enter your age :");

double age =Convert.ToDouble(Console.ReadLine());

BirthDaySong(name, age);


static void BirthDaySong (String n , double a)
{
    Console.WriteLine("Happy birthday to you");
    Console.WriteLine("Happy birthday to you");
    Console.WriteLine("Happy birthday dear " + n);
    Console.WriteLine("Happy birthday to you");
    Console.WriteLine("you are " + a + " years old ");

}

*/

//// params keyword is a method parameter that takes a variable numer of arguments 

//Console.Write("enter the numbers you want to sum : ");
//double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//sum(numbers);
//static double sum (params double[] numbers)
//{

//    return numbers.Sum();

//} 
//Console.WriteLine("the sum of the numbers is : " + numbers.Sum());

//-----------------------------------------------

//Exception is an error that occurs during the execution of a program.

/*double x;
double y;
double result;

try
{
Console.WriteLine("Enter number 1:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" Enter number 2: ");
y = Convert.ToDouble(Console.ReadLine());

    result = x / y;

}
catch (FormatException ex)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("you cannot divide by zero");
    return;
}catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
    return;
}
*/

//string FistName = "safae";
//string lastName = "wifey";

//Console.WriteLine($"{FistName} {lastName,10}.");

string[,] cars =
{
    {"bmw","mercedes" },
    {"audi","ferrari"},
    {"toyota","honda"}
};

for (int i =0; i< cars.GetLength(0); i++)
{
    for (int j = 0; j < cars.GetLength(1); j++)
    {
        Console.Write(cars[i, j] + " ");
    }
    Console.WriteLine();
}
















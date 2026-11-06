
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

// params keyword is a method parameter that takes a variable numer of arguments 

Console.Write("enter the numbers you want to sum : ");
double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

sum(numbers);
static double sum (params double[] numbers)
{

    return numbers.Sum();

} 
Console.WriteLine("the sum of the numbers is : " + numbers.Sum());









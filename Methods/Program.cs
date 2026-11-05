
Console.WriteLine("-----------the happy birthday song--------------- ");

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


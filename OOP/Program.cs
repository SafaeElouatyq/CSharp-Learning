

using OOP;

//Messages.Hello();
//Messages.bye();

Human person1 = new Human();

person1.name= "ousaf"; 
person1.age = 20;
person1.Introduce();


class Human
{
    public string name;
    public int age;

    public void Introduce()
    {
        Console.WriteLine("hello "+name+ " your age is " + age);
    }
}


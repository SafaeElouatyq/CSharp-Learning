

using OOP;

//Messages.Hello();
//Messages.bye();

Human person1 = new Human("ousaf",20);
person1.Introduce();



//person1.name = "ousaf";
//person1.age = 20; 

//persone1 is an object of class Human


class Human
{
    public string name;
    public int age;

    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Introduce()
    {
        Console.WriteLine("hello " + name + " your age is " + age);
    }
}


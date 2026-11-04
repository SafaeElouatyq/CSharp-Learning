Random r = new Random();
bool playAgain = true;
int min = 1;
int max = 100;

int guess;
int number;
int guesses;
String response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = r.Next(min, max + 1);



    while (guess != number)
    {
        Console.WriteLine("enter your guess : ");
        guess = Convert.ToInt32(Console.ReadLine());

        guesses++;

        if (number > guess)
        {
            Console.WriteLine(guess + " is low");

        }
        else if (number < guess)
        {
            Console.WriteLine(guess + " is high");

        }
        else
        {
            Console.WriteLine("CONGRATULATIONS !!! YOU WIN THE NUMBER IS " + guess);
            Console.WriteLine("YOU KNEW IT FROM " + guesses + " GUESSES !!");

        }
    }
    Console.WriteLine("would you like to play again ? (Y/N)");
    response = Console.ReadLine().ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }

}

Console.WriteLine("thanks for playing !");

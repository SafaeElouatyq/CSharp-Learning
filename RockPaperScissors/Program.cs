
Random r = new Random();
bool playAgain = true;
String player;
String computer;
string answer;

while (playAgain)
{
    answer = "";
    player = "";
    computer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.WriteLine("Enter ROCK, PAPER, or SCISSORS : ");
        player = Console.ReadLine().ToUpper();

    }
    //Console.WriteLine("You chose " + player);
    switch (r.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;

        case 2:
            computer = "PAPER";
            break;

        case 3:
            computer = "SCISSORS";
            break;

        default:
            break;

    }

    Console.WriteLine("player chose " + player);
    Console.WriteLine("computer chose " + computer);

    switch (player)
    {
        case "ROCK":
           if (computer == "ROCK")
            {
                Console.WriteLine("it is a draw");

            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("you lose");
                
            }else if (computer == "SCISSORS")
            {
                Console.WriteLine("you win");

            }

            break;

        case "PAPER":
            if ( computer == "ROCK")
            {
                Console.WriteLine("you win");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("it is a draw");
            }
            else if (computer == "SCISSORS")
            {
                Console.WriteLine("you lose");
            }

            break;

        case "SCISSORS":
            if (computer == "ROCK")
            {
                Console.WriteLine("you lose");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("you win");
            }
            {
                Console.WriteLine("it is a draw");
            }
            break;

            break;

    }
    Console.WriteLine("would you like to play again ? (Y/N)");

    answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }




}

// See https://sehs.io/ for more information
int wins = 0;
int looses = 0;
int rounds = 0;
bool playing = true;
Random random = new();

Console.WriteLine("--- Heads or Tails ---");

while (playing)
{

    Console.WriteLine($"Wins: {wins} Losses: {looses}");
    Console.Write("heads, or tails -> ");
    string input = Console.ReadLine();

    int randomAnswer = random.Next(1, 3);
    string computer;

    if (randomAnswer == 1)
    {
        computer = "heads";
    }
    else
    {
        computer = "tails";
    }


    if (input == "heads" && computer == "tails")
    {
        Console.WriteLine("WRONG, it was tails!");
        looses++;
    }
    else if (input == "tails" && computer == "heads")
    {
        Console.WriteLine("WRONG, it was heads.");
        looses++;
    }
    else if (input == "tails" && computer == "tails")
    {
        Console.WriteLine("CORRECT!! The answer was tails!");
        wins++;
    }
    else if (input == "heads" && computer == "heads")
    {
        Console.WriteLine("CORRECT!! The answer was heads!");
        wins++;
    }
    else
    {
        Console.WriteLine("You input the wrong answer, nerd.");
    }

    Console.WriteLine("\nDo you want to play again?");
    Console.Write("(yes, no) -> ");
    input = Console.ReadLine();

    if (input == "no")
    {
        playing = false;
    }
    else
    {
        rounds++;
    }



}

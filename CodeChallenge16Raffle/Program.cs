// See https://sehs.io/ for more information

List<string> raffleAttendants = new List<string>();
bool raffleManager = true;
Random random = new Random();

Console.WriteLine("--- Raffle ---");

while (raffleManager)
{
    Console.Write("Enter a contestant name: ");
    string unput = Console.ReadLine();
    raffle.Add(unput);

    Console.Write("\nAdd another? (y/n) -> ");
    string input = Console.ReadLine();

    if (input == "n" || input == "no")
    {
        raffleManager = false;
    }
    else
    {

    }
}

int raffleWinner = random.Next(0, raffleAttendants.Count);


Console.WriteLine("The winner is...");
Thread.Sleep(5000);

Console.WriteLine($"{raffleAttendants(raffleWinner)}!");

// Console.WriteLine($"{GetraffleWinner(raffleWinner)}!");

Console.ReadLine();
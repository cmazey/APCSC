bool IsEven(int number)
{
    return number % 2 == 0;
}

bool IsOdd(int number)
{
    return (number % 2 == 1);
}

int rOLLdIE(int numberOfSides)
{
    Random random = new Random();
    return random.Next(1, numberOfSides + 1);
}


double GetWattage(double volts, double amps)
{
    return volts * amps;
}

Console.WriteLine("1) IsEven()");
Console.WriteLine("2) IsEven()");
Console.WriteLine("3) RollDie()");
Console.WriteLine("4) GetWattage()");

Console.Write("Choose method (1-4): ");
string input = Console.ReadLine();

if (input == "1")
{
    Console.Write("Enter integer: ");
    int n = Convert.ToInt32(Console.ReadLine());
    bool result = IsEven(n);
    Console.WriteLine($"Is {n} even? {result}");
}
else if (input == "2")
{
    Console.Write("Enter integer: ");
    int n = Convert.ToInt32(Console.ReadLine());
    bool result = IsOdd(n);
    Console.WriteLine($"Is {n} odd? {result}");
}
else if (input == "3")
{
    Console.Write("How many sides is the die? ");
    int sides Convert.ToInt32(Console.ReadLine());
    // Line: 59SSSS
}
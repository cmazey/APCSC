using System.Globalization;

Console.WriteLine("FUNCTION CHALLENGE: #1\n");

double GetCircleArea(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}
Console.Write("Enter a radius -> ");
double input = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetCircleArea(input));

Console.ReadLine();

Console.WriteLine("\nFUNCTION CHALLENGE: #2\n");

double FahrToCel(double fahreheitTemp)
{
    return 5 / 9 * (fahreheitTemp - 32);
}

Console.Write("Fahrenheit: ");
input = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Celsius: {FahrToCel(input)}");

Console.ReadLine();

Console.WriteLine("\nFUNCTION CHALLENGE #3\n");


List<int> grades = new List<int>()
{
    5,
    11,
    21,
    55,
    87,
    32,
    16,
    17,
    1
};


double Average(List<int> numbers)
{
    int sum = 0;


    foreach (int num in numbers)
    {
        sum = sum + num;
    }

    return sum / numbers.Count;
}

double answer = Average(grades);

Console.WriteLine($"The average is {answer}");


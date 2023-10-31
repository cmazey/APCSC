Console.WriteLine("FUNCTION CHALLENGE: #1\n");

double GetCircleArea(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}
Console.Write("Enter a radius -> ");
double input = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetCircleArea(input));

Console.ReadLine();


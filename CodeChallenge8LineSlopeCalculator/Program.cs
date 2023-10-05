// See https://sehs.io/ for more information
Console.WriteLine("--- Line Slope Calculator ---\n");

Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double slope = (y2 - y1) / (x2 - x1);

Console.WriteLine($"\nThe slope of the through points ({x1}, {y1}), amd ({x2}, {y2}) is {slope}!");
Console.ReadLine();


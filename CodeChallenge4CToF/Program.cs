// See https://sehs.io/ for more information
Console.WriteLine("--- Celsius To Fahrenheit ---");
Console.Write("Enter Celsius value: ");
double Celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = Celsius * 9 / 5 + 32;
Console.WriteLine($"\n{Celsius}°C = {fahrenheit}°F.");
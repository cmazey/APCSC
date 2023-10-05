// See https://sehs.io/ for more information
Console.WriteLine("--- Miles to Kilometers Calculator ---");
Console.Write("Enter miles value: ");
double miles = Convert.ToDouble(Console.ReadLine());
double kilometers = miles * 1.6;
Console.WriteLine($"\n{miles} miles = {kilometers} Kilometers");
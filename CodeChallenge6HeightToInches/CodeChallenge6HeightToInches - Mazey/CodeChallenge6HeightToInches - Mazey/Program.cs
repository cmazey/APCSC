// See https://sehs.io/ for more information
Console.Write("Enter your height in inches: ");
double height = Convert.ToDouble(Console.ReadLine());
double num = 12;

double foot = height / num; //Dividing the height in inches by 12
double inches = height % num;

Console.WriteLine($"You are {foot}ft, {inches}in.");

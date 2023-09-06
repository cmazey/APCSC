// See https://sehs.io/ for more information
Console.WriteLine("--- Tip Calculator ---");
Console.Write("Enter bill: $");
double bill = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter tip percentage: %");
double tip = Convert.ToDouble(Console.ReadLine());

double tipAnswer = tip / 100;
double tipTotal = bill * tipAnswer;

double finalBill = bill + tipTotal;
Console.WriteLine($"\nTip: ${tipTotal}, Total: ${finalBill}");

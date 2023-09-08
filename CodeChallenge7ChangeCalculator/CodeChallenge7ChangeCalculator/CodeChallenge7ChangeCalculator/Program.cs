// See https://sehs.io/ for more information
Console.Write("Enter change to give back (1c - 99c): ");
int change = Convert.ToInt32(Console.ReadLine());

int Quarters = (change / 25); // Multiply the change value by 25
int Dimes = (change - (Quarters * 25)) / 10; // Multiply the quarter by 25, then subtract the change, and divide it by 10.
int Nickels = (change - (Quarters * 25 + Dimes * 10)) / 5; // Multiply the Quarter, and dime. Then add it altogether, and subtract it by the change value, and then divide it by 5.
int Pennies = (change - (Quarters * 25 + Dimes * 10 + Nickels * 5)) / 1; // Multiply the quarter, Dime, and Nickel, and add it all together, then subtract it by the change, and divide it by 1.

Console.WriteLine($"\nQuarters: {Quarters}");
Console.WriteLine($"Dimes: {Dimes}");
Console.WriteLine($"Nickels: {Nickels}");
Console.WriteLine($"Pennies: {Pennies}");

Console.ReadLine();

// I only did this code challenge because I like extra credit! :D

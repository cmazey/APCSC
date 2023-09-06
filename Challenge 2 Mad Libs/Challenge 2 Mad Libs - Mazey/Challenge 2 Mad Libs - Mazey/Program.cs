// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- MAD LIB ---\n");

Console.Write("Enter an item: ");
string item = Console.ReadLine();
Console.Write("Enter a plural noun: ");
string pluralNoun = Console.ReadLine();
Console.Write("Enter a number: ");
string number = Console.ReadLine();
Console.Write("Enter another number: ");
string anotherNumber = Console.ReadLine();

Console.WriteLine($"\nI went to the store to buy a {item}, but I only had {number}.");
Console.WriteLine($"Luckily, I found a sale on {pluralNoun}.");
Console.WriteLine($"So, I purchased {anotherNumber} of them! Great success!");
// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

bool wolfpackEnding = false;
bool dragonEnding = false;
int gold = 0;
int twinkies = 0;

Console.WriteLine("Your car crashes into a tree during a thunderstorm in the woods.");
Console.WriteLine("As the storm intensifies, you run into a nby cave to seek shelter.");
Console.WriteLine("Upon entering the cave, you see two diverging paths...\n");

Console.Write("Which path do you take? (left or right) -> ");
string path = Console.ReadLine().ToLower();

Console.WriteLine("\nAs you leave, you see a delicious Hostess Twinkie.");
Console.WriteLine("Do you eat the Twinkie for sustenance, or will you save it for later?");

Console.Write("(take of eat_ -> ");
string choice = Console.ReadLine();

if (choice == "take")
{
    Console.WriteLine("You never know when a Twinkie will come in handy...\n");
    twinkies++;
}
else if (choice == "eat")
{

    Console.WriteLine("It's going to be a long night, so you ecided to eat it.\n");

}
else
{

    Console.WriteLine("You leave the twinkie alone.\n");
}

if (path == "left")
{
    Console.WriteLine("You decide to take the left path.");
    Console.WriteLine("You stumble into a pack of wolves lying together.");
    Console.WriteLine("The pack leader slowly approaches...\n");
    Console.Write("Do you pet the pack leader? (yes or no) -> ");

    choice = Console.ReadLine().ToLower;

    if (choice == "yes" && twinkies >= 1)
    {

        Console.WriteLine("As you approach, the wolves smell a delicious snake cake..");
        Console.WriteLine("In a fit of hungry rage, they rip you to shreds!\n");

    }
    else if (choice == "yes")
    {

        Console.WriteLine("The pack leader respects and accepts you.");
        Console.WriteLine("You are given a golden satchel by the pack leader.");
        Console.WriteLine("You also cuddle with the wolf pack until the storm subsides...\n");
        gold = gold + 5;
        wolfpackEnding = true;

    }
    else
    {
        Console.WriteLine("The pack leader senses your fear.");
        Console.WriteLine("The entire pack crowds around you and devours you...\n");

    }

}
else if (path == "right")
{

    Console.WriteLine("You decide to take the right path.");
    Console.WriteLine("\nLater down the trail, you stumble upon an overweight,");
    Console.WriteLine("repulsive looking talking dragon named Mort the Pudgy.");
    Console.WriteLine("The dragon speaks: 'Did you bring me snack cakes??'");

    Console.Write("Do you have a treat to give this foul creature? (yes, no) -> ");

    choice = Console.ReadLine();

    if (choice == "yes" && twinkies >= 1)
    {

        Console.WriteLine("Me love Twinkie!!! Here take gold!");
        Console.WriteLine("The dragon grants you the gold he was guarding.\n");
        Console.Write("How much gold do you take? -> ");

        choice = Console.ReadLine();
        int goldAmount = Convert.ToInt32(choice);

        if (goldAmount > 0 && goldAmount <= 100)
        {

            Console.WriteLine("Mortimer the Pudgy grants you his gold...\n");
            gold = gold + goldAmount;

        }
        else if (goldAmount > 100)
        {

            Console.WriteLine("'gREEDY! no gold for you!'"\n);

        }
        else
        {

            Console.WriteLine("Mortimer the pudgy respects youe piety!");
            Console.WriteLine("You are granted all the gold!\n");
            gold = gold + 100000;

        }

        dragonEnding = true;
    }
    else
    {

        Console.WriteLine("'Fool!!!'");
        Console.WriteLine("The dragon devours you whole.");
        Console.WriteLine("He desired a delicious Hostess treat, settling for you instead...\n");

    }

}
else
{

    Console.WriteLine("You decide not to enter. You receive a thunderstock and lie in the strom...\n");

}

// ENDGAME

// Nephi Allen Homework 9
// Manticore! (the Boss Battle)

Console.Clear();

Console.WriteLine("'Manticore!!!!!!!!'\nScreamed the man.\n");
Console.WriteLine(@"You are Player one.
You will set the position of the Manticore, who is attacking the city.
It must be set at a position between 1 and 100.
");
Console.Write("Set Manticore position to : ");
int Position = int.Parse(Console.ReadLine());
Console.WriteLine("The Manticore's Position is set to : " + Position + @"
Press any key to make it player two's turn.");
Console.CursorVisible = false; Console.ReadKey();
Console.Clear();
Console.CursorVisible = true;

int MHealth = 10;
int CHealth = 15;
int Round = 1;

Console.WriteLine(@"
You are about to face a fierce Manticore.
The Manticore has begun an attack on the Emerald City, and must be destroyed, or the city will fall.
Here is what you need to know to save the city:

You are player two. It is your turn. 
Player one has already set the Manticore's position between 1 and 100.
You will input a number to guess the Manticore's position.

Press any key to begin the game!");
Console.ReadKey();
Console.Clear();

bool running = true;
while (running)
{
    Console.WriteLine("\nRound : " + Round + "\n");
    if (MHealth <= 0)
    {
        Console.Clear();
        Console.WriteLine("You WIN!!!!!!!!! You saved the city!!!!");
        break;
    }
    else if (CHealth <= 0)
    {
        Console.Clear();
        Console.WriteLine("You lose! the city wat destroyed by the Manticoe");
        break;
    }
    else
    {
        Console.WriteLine("The Manticore's health is " + MHealth + ".");
        Console.WriteLine("The city's health is " + CHealth + ".");
        Console.Write("Where do you think the manticore is : ");
        int guess = int.Parse(Console.ReadLine());
        if (guess == Position)
        {
            if (Round == 1 || Round == 2 || Round == 4 || Round == 7 || Round == 8 || Round == 11 || Round == 13 || Round == 14)
            {
                MHealth = MHealth - 1;
                Console.WriteLine("\nDirect hit! damage 1!");
            }
            else if (Round == 3 || Round == 5 || Round == 6 || Round == 9 || Round == 10)
            {
                MHealth = MHealth - 3;
                Console.WriteLine("\nDirect hit! Damage 3!");
            }
            else if (Round == 15)
            {
                MHealth = MHealth - 10;
                Console.WriteLine("\nDirect hit! Damage 10!");
            }
        }
        else if (guess < Position)
        {
            Console.WriteLine("\nToo low. You missed!");
        }
        else if (guess > Position)
        {
            Console.WriteLine("\nToo high. You missed!");
        }
    }
    CHealth--;
    Round++;
}

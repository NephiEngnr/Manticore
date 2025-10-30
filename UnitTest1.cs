// Nephi Allen Homework 9
// Manticore! (the Boss Battle)

Console.Clear();
// Print Instructions

Console.WriteLine("'Manticore!!!!!!!!'\nScreamed the man.\n");
Console.WriteLine(@"You are Player one.
You will set the position of the Manticore, who is attacking the city.
It must be set at a position between 1 and 100.
");
Console.Write("Manticore position : ");
int Position = int.Parse(Console.ReadLine());
Console.WriteLine("The Manticore's Position is set to : " + Position + @"
Press any key to make it player two's turn.");
Console.CursorVisible = false; Console.ReadKey();
Console.Clear();
Console.CursorVisible = true;

int MHealth = 10;
int CHealth = 15;

Console.WriteLine(@"
You are about to face a fierce Manticore.
The Manticore has begun an attack on the uncoded's ship, and must be destroyed, or the city will fall.
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
    if (MHealth >= 1 || CHealth >= 1)
    {
        Console.WriteLine("The Manticore's health is " + MHealth + ".");
        Console.WriteLine("The city's health is " + CHealth + ".");
        int guess = int.Parse(Console.ReadLine());
        if (guess == Position) { MHealth = MHealth - 3; }
        CHealth--;
    }
    else if (MHealth <= 0)
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
        Console.WriteLine("something went wrong, I will have to fix it.");
        break;
    }
}









public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}
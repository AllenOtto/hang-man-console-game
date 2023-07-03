//using System;
//using System.Collections.Generic;
//using static System.Random;
//using System.Text;

static void PrintHangMan(int wrongGuesses)
{
    if(wrongGuesses == 1)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O  |");
        Console.WriteLine("    |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if(wrongGuesses == 2)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O  |");
        Console.WriteLine(" |  |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if(wrongGuesses == 3)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O  |");
        Console.WriteLine("/|  |");
        Console.WriteLine("    |");
        Console.WriteLine("   ===");
    }
    else if(wrongGuesses == 4)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O   |");
        Console.WriteLine("/|\\ |");
        Console.WriteLine("     |");
        Console.WriteLine("   ===");
    }
    else if(wrongGuesses == 5)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O   |");
        Console.WriteLine("/|\\ |");
        Console.WriteLine("/    |");
        Console.WriteLine("   ===");
    }
    else if(wrongGuesses == 6)
    {
        Console.WriteLine("\n+---+");
        Console.WriteLine(" O   |");
        Console.WriteLine("/|\\ |");
        Console.WriteLine("/ \\ |");
        Console.WriteLine("   ===");
    }
}


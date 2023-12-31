﻿//using System;
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

// Method that prints out correctly guessed letters to the console
static int PrintWord(List<char> guessedLetters, string randomWord)
{
    int counter = 0;
    int rightLetters = 0;
    Console.Write("\r\n");

    foreach(char c in randomWord)
    {
        if(guessedLetters.Contains(c))
        {
            Console.WriteLine(c + " ");
            rightLetters++;
        }
        else
        {
            Console.WriteLine(" ");
        }

        counter++; 
    }

    return rightLetters;
}

// Method that prints a line under each letter of the secret word
static void printLines(string randomWord)
{
    Console.Write("\r");
    foreach(char c in randomWord)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("\u0305");
    }
}
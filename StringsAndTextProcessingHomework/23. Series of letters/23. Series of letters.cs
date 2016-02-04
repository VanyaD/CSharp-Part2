using System;
using System.Collections.Generic;
using System.Linq;

class SeriesOfLetters
{
    static void Main()
    {
        //•	Write a program that reads a string from the console and replaces all series 
        //  of consecutive identical letters with a single one.

        Console.WriteLine("Please enter some text: ");
        string input = Console.ReadLine();
        int currIndex = 0;
        Console.Write(input[0]);

        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i] == input[currIndex])
            {
                i++;
            }
            else
            {
                Console.Write(input[i]);
                currIndex = i;
            }
        }
        
        Console.WriteLine();
    }
}


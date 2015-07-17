using System;
using System.Collections.Generic;
using System.Linq;

class SeriesOfLetters
{
    static void Main()
    {
        //•	Write a program that reads a string from the console and replaces all series 
        //  of consecutive identical letters with a single one.

        Console.WriteLine("Please enter a string: ");
        string input = Console.ReadLine();
        
        var uniqueValues = new HashSet<char>();
        

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                uniqueValues.Add(input[i]);
                foreach (char uniqueValue in uniqueValues)
                {
                    Console.Write(uniqueValue);
                }
                if (input[i + 1] != input[i + 2])
                {
                    uniqueValues.Remove(input[i]);
                }
                
            }
        }

        
        Console.WriteLine();

        //Console.WriteLine(count);
        //var uniqueValues = new HashSet<char>();

        //for (int i = 0; i < input.Length; i++)
        //{
        //    uniqueValues.Add(input[i]);           
        //}

        //foreach (char uniqueValue in uniqueValues)
        //{
        //    Console.Write(uniqueValue);
        //}
        //Console.WriteLine();
    }
}


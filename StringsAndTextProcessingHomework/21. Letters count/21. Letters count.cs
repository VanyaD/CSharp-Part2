using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        //•	Write a program that reads a string from the console and prints all different letters in the 
        //  string along with information how many times each letter is found.

        Console.WriteLine("Please enter some text: ");
        string text = Console.ReadLine();
        string textSmallLetters = text.ToLower();
        int[] results = new int[26];

        for (int i = 0; i < textSmallLetters.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (textSmallLetters[i] == j + 97)
                {
                    results[j]++;
                }
            }
        }

        for (int i = 0; i < 26; i++)
        {
            if (results[i] != 0)
            {               
                Console.WriteLine("{0} --> {1} times", (char)(i + 97), results[i]);
            }            
        }           
    }
}


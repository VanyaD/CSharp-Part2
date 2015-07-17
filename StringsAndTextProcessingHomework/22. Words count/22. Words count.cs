using System;
using System.Linq;
using System.Collections.Generic;
class WordsCount
{
    static void Main()
    {
        //•	Write a program that reads a string from the console and lists all different words in the 
        //  string along with information how many times each word is found.

        Console.WriteLine("Please enter some text: ");
        string text = Console.ReadLine();

        string textSmallLetters = text.ToLower();
        string[] words = textSmallLetters.Split(' ');

        int wordsCount = 0;
        var uniqueItems = new HashSet<string>();

        for (int i = 0; i < words.Length; i++)
        {
            uniqueItems.Add(words[i]);
        }

        foreach (string uniqueItem in uniqueItems)
        {
            wordsCount = words.Count(c => c == uniqueItem);

            Console.WriteLine("{0} --> {1} times", uniqueItem, wordsCount);
        }
    }
}


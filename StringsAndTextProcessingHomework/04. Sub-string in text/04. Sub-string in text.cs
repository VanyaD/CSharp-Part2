using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

class SubStringInText
{
    static void Main()
    {
       //• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

        Console.WriteLine("Please enter some text: ");
        string originalText = Console.ReadLine();
        string text = originalText.ToLower();

        Console.WriteLine("Please enter a sub-string: ");
        string originalSearched = Console.ReadLine();
        string searched = originalSearched.ToLower();
        
        
        int start = 0;
        int count = 0;
        int index;
        for (int i = 0; i < text.Length; i++)
        {
            index = text.IndexOf(searched, start);
            if (index >= 0)
            {
                count++;
                start = searched.Length + index;
            }
        }     
        Console.WriteLine(count);
    }
}


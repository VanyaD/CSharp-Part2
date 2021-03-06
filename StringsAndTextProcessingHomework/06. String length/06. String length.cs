﻿using System;

class StringLength
{
    static void Main()
    {
        /*•	Write a program that reads from the console a string of maximum 20 characters. If the 
         * length of the string is less than 20, the rest of the characters should be filled with *.
          •	Print the result string into the console.*/

        Console.WriteLine("Please enter some text (max 20 characters long: ");
        string text = Console.ReadLine();
        if (text.Length == 20)
        {
            Console.WriteLine(text);
        }

        if (text.Length < 20)
        {
            Console.WriteLine("{0}", text.PadRight(20, '*'));
        }
    }
}

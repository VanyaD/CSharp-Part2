using System;

// Problem 12. Index of letters
// • Write a program that creates an array containing all letters from the alphabet ( A-Z ).
// • Read a word from the console and print the index of each of its letters in the array.


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a word: ");
        string word = Console.ReadLine();

        char[] letters = new char[26];

        for (int i = 0; i < 26; i++)
        {
            letters[i] = (char)(i + 97);
        }

        for (int i = 0; i < word.Length; i++)
        {
            int index = Array.IndexOf(letters, word[i]);
            Console.WriteLine(index);
        }
    }
}

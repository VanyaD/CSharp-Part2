using System;

class WordDictionary
{
    static void Main()
    {
        /*•	A dictionary is stored as a sequence of text lines containing words and 
         * their explanations.
          •	Write a program that enters a word and translates it by using the dictionary.*/

        string[,] dict = {
        { ".NET", "platform for applications from Microsoft" },
        { "CLR", "managed execution environment for .NET" },
        { "namespace", "hierarchical organization of classes" }
                         };
        Console.WriteLine("Please enter a word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < dict.GetLength(0); i++)
        {
            if (word == dict[i, 0])
            {
                Console.WriteLine(dict[i, 1]);
                return;
            }
        }

        Console.WriteLine("The given word is not present in the dictionary");
    }
}

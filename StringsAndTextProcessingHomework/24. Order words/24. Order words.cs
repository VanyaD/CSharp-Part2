using System;

class OrderWords
{
    static void Main()
    {
        //•	Write a program that reads a list of words, separated by spaces 
        //  and prints the list in an alphabetical order.

        Console.WriteLine("Please enter some text: ");
        string text = Console.ReadLine();

        string[] words = text.Split(' ');
        Array.Sort(words);

        int index = 0;
        string temp = string.Empty;

        for (int i = 0; i < words.Length - 1; i++)
        {
            index = string.Compare(words[i], words[i + 1], false);

            if (index > 0)
            {
                temp = words[i];
                words[i] = words[i + 1];
                words[i + 1] = temp;
            }
        }

        Console.Write(string.Join(", ", words));
        Console.WriteLine();
    }
}

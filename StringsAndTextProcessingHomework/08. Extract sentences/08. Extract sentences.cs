using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        //•	Write a program that extracts from a given text all sentences containing given word.

        // Example:

        // The word is: in
        // The text is: We are living in a yellow submarine. We don't have anything else. 
        // Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
        // The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
        // Consider that the sentences are separated by  .  and the words – by non-letter symbols.

        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string searched = " in ";

        var countOfDots = text.Count(c => c == '.');

        string[] inputStr = text.Split('.');
        string[] sentences = new string[countOfDots];

        for (int i = 0; i < countOfDots; i++)
        {
            sentences[i] = inputStr[i];

            if (sentences[i].Contains(searched))
            {
                Console.Write("{0}. ", sentences[i]);
            }
        }

        Console.WriteLine();
    }
}


using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
       //•	Write a program that converts a string to a sequence of C# Unicode character literals.
       //•	Use format strings.

        Console.WriteLine("Please enter some text: ");
        string input = Console.ReadLine();

        string result = ConvertToUnicode(input);
        Console.WriteLine(result);
    }

    private static string ConvertToUnicode(string input)
    {
        StringBuilder result = new StringBuilder();

        foreach(char letter in input)
        {
            result.Append(string.Format("\\u{0:X4}", (int)letter));
        }       
        return result.ToString();
    }
}


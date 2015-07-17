//•	Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseStringProblem
{
    static void Main()
    {
        Console.WriteLine("Please enter some text: ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }

    static string ReverseString(string input)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        return sb.ToString();
    }
}

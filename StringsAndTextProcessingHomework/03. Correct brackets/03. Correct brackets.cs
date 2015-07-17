using System;
using System.Linq;

class CorrectBrackets
{
    static void Main()
    {
        //•	Write a program to check if in a given expression the brackets are put correctly.
        // Example of correct expression: ((a + b) / 5 - d). Example of incorrect expression:  )(a+b)).

        Console.WriteLine("Please enter an expression: ");
        string expression = Console.ReadLine();

        var openingBracketsCount = expression.Count(c => c == '(');
        var closingBracketsCount = expression.Count(c => c == ')');

        int startOpenBr = expression.IndexOf('(');
        int startClosingBr = expression.IndexOf(')');
        int endOpenBr = expression.LastIndexOf('(');
        int endClosingBr = expression.LastIndexOf(')');

        if ((openingBracketsCount == closingBracketsCount) && (startOpenBr < startClosingBr) && (endClosingBr > endOpenBr))
        {
            Console.WriteLine("Valid expression!");
        } 
        else
        {
            Console.WriteLine("Invalid expression!");
        }
    }
}


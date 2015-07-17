//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Please, enter number");
        string number = Console.ReadLine();

        try
        {
            int.Parse(number);
            if (int.Parse(number) < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            Console.WriteLine(Math.Sqrt(int.Parse(number)));

        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }

        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
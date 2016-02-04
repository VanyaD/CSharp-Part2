using System;

// Problem 3. Compare char arrays
// • Write a program that compares two  char  arrays lexicographically (letter by letter).

public class CompareCharArrays
{
    public static void Main()
    {
        Console.WriteLine("Please enter the elements of the first array: ");
        string inputFirst = Console.ReadLine();
        char[] inputChrFirst = new char[inputFirst.Length];

        for (int i = 0; i < inputFirst.Length; i++)
        {
            inputChrFirst[i] = inputFirst[i];
        }

        Console.WriteLine("Please enter the elements of the second array: ");
        string inputSecond = Console.ReadLine();
        char[] inputChrSecond = new char[inputSecond.Length];

        for (int i = 0; i < inputSecond.Length; i++)
        {
            inputChrSecond[i] = inputSecond[i];
        }

        int smallerLength = 0;

        if (inputChrFirst.Length < inputChrSecond.Length)
        {
            smallerLength = inputChrFirst.Length;
        }
        else if (inputChrFirst.Length > inputChrSecond.Length)
        {
            smallerLength = inputChrSecond.Length;
        }
        else
        {
            smallerLength = inputChrFirst.Length;
        }

        bool areEqual = false;

        for (int i = 0; i < smallerLength; i++)
        {
            if (inputChrFirst[i] > inputChrSecond[i])
            {
                Console.WriteLine("Array B is first lexicographically.");
                return;
            }

            if (inputChrSecond[i] > inputChrFirst[i])
            {
                Console.WriteLine("Array A is first lexicographically.");
                return;
            }

            if (inputChrFirst[i] == inputChrSecond[i])
                areEqual = true;
        }

        if ((areEqual == true) && (inputChrFirst.Length == inputChrSecond.Length))
        {
            Console.WriteLine("Both arrays are equal.");
        }

        if ((areEqual == true) && (inputChrFirst.Length < inputChrSecond.Length))
        {
            Console.WriteLine("Array A is first lexicographically.");
        }

        if ((areEqual == true) && (inputChrFirst.Length > inputChrSecond.Length))
        {
            Console.WriteLine("Array B is first lexicographically.");
        }
    }
}

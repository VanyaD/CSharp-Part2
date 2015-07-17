using System;

class SumIntegers
{
    static void Main()
    {
        //•	You are given a sequence of positive integer values written into a string, separated by spaces.
        //•	Write a function that reads these values from given string and calculates their sum.

        Console.WriteLine("Please enter a sequence of numbers separated by space: ");
        string input = Console.ReadLine();

        string[] inputArr = input.Split(' ');

        int[] nums = new int[inputArr.Length];
        int sum = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            sum = sum + int.Parse(inputArr[i]);
        }

        Console.WriteLine(sum);
    }
}


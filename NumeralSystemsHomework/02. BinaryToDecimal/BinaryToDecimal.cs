using System;

// Problem 2. Binary to decimal
// • Write a program to convert binary numbers to their decimal representation.

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number: ");
        string binary = Console.ReadLine();
        int[] nums = new int[binary.Length];

        for (int i = 0; i < binary.Length; i++)
        {
            nums[i] = binary[i] - 48;
        }

        double dec = 0;

        for (int i = binary.Length - 1, j = 0; i >= 0 && j < binary.Length; i--, j++)
        {
            dec = dec + nums[i] * Math.Pow(2, j);
        }

        Console.WriteLine(dec);
    }
}

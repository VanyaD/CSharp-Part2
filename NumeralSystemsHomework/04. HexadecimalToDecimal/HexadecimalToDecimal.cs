using System;

// Problem 4. Hexadecimal to decimal
// • Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a hexadecimal number: ");
        string hex = Console.ReadLine();

        int[] nums = new int[hex.Length];

        for (int i = 0; i < hex.Length; i++)
        {
            if (char.IsLetter(hex[i]))
            {
                nums[i] = hex[i] - 55;
            }

            else
            {
                nums[i] = hex[i] - 48;
            }
        }

        double dec = 0;

        for (int i = hex.Length - 1, j = 0; i >= 0 && j < hex.Length; i--, j++)
        {
            dec = dec + nums[i] * Math.Pow(16, j);
        }

        Console.WriteLine(dec);
    }
}

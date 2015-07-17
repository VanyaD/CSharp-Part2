using System;

// Problem 1. Decimal to binary
// • Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());

        int lastDigit = number % 2;
        int remainder;
        string binary = String.Empty;

        while (number > 1)
        {
            number = number / 2;
            remainder = number % 2;
            binary = remainder + "" + binary;
        }

        for (int i = 0; i < binary.Length; i++)
        {
            Console.Write(binary[i]);
        }

        Console.WriteLine(lastDigit);
    }
}

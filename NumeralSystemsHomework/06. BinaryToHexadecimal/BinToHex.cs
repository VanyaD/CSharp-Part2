using System;

// Problem 6. binary to hexadecimal
// • Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinToHex
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number: ");
        string binary = Console.ReadLine();

        int remainder = binary.Length % 4;
        string binaryPadded = string.Empty;

        if (remainder != 0)
        {
            binaryPadded = binary.PadLeft(binary.Length + (4 - remainder), '0');
        }

        else
            binaryPadded = binary;

        int[] nums = new int[binaryPadded.Length];

        for (int i = 0; i < binaryPadded.Length; i++)
        {
            nums[i] = binaryPadded[i] - 48;
        }

        double hex = 0;
        char hexAsChar = ' ';

        for (int i = 0, j = 0; i < binaryPadded.Length; i++, j++)
        {
            hex = hex + nums[i] * Math.Pow(2, 3 - j);

            if (i % 4 == 3)
            {
                if (hex < 10)
                {
                    Console.Write(hex);
                    hex = 0;
                    j = -1;
                }

                if (hex == 10)
                {
                    hexAsChar = 'A';
                }

                if (hex == 11)
                {
                    hexAsChar = 'B';
                }

                if (hex == 12)
                {
                    hexAsChar = 'C';
                }

                if (hex == 13)
                {
                    hexAsChar = 'D';
                }

                if (hex == 14)
                {
                    hexAsChar = 'E';
                }

                if (hex == 15)
                {
                    hexAsChar = 'F';
                }

                if (hex > 10)
                {
                    Console.Write(hexAsChar);
                    hex = 0;
                    j = -1;
                }
            }
        }

        Console.WriteLine();
    }
}

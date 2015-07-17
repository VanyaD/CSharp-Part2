using System;

// Problem 3. Decimal to hexadecimal
// • Write a program to convert decimal numbers to their hexadecimal representation.


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());

        int lastDigit = number % 16;
        int remainder;
        char remainderAsChar = ' ';
        char lastDigitAsChar = ' ';
        string hex = String.Empty;

        while (number > 15)
        {
            number = number / 16;
            remainder = number % 16;
            if (remainder == 10)
            {
                remainderAsChar = 'A';
            }

            if (remainder == 11)
            {
                remainderAsChar = 'B';
            }

            if (remainder == 12)
            {
                remainderAsChar = 'C';
            }

            if (remainder == 13)
            {
                remainderAsChar = 'D';
            }

            if (remainder == 14)
            {
                remainderAsChar = 'E';
            }

            if (remainder == 15)
            {
                remainderAsChar = 'F';
            }

            if (remainder >= 10)
            {
                hex = remainderAsChar + "" + hex;
            }

            if (remainder < 10)
            {
                hex = remainder + "" + hex;
            }
        }

        for (int i = 0; i < hex.Length; i++)
        {
            Console.Write(hex[i]);
        }

        if (lastDigit == 10)
        {
            lastDigitAsChar = 'A';
        }

        if (lastDigit == 11)
        {
            lastDigitAsChar = 'B';
        }

        if (lastDigit == 12)
        {
            lastDigitAsChar = 'C';
        }

        if (lastDigit == 13)
        {
            lastDigitAsChar = 'D';
        }

        if (lastDigit == 14)
        {
            lastDigitAsChar = 'E';
        }

        if (lastDigit == 15)
        {
            lastDigitAsChar = 'F';
        }

        if (lastDigit < 10)
        {
            Console.WriteLine(lastDigit);
        }

        if (lastDigit >= 10)
        {
            Console.WriteLine(lastDigitAsChar);
        }
    }
}

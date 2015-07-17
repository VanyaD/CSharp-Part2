using System;

class FormatNumber
{
    static void Main()
    {
        /*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
         * percentage and in scientific notation.
          •	Format the output aligned right in 15 symbols.*/

        Console.WriteLine("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:F2}", num);
        Console.WriteLine("{0,15:X}", num);
        Console.WriteLine("{0,15:p}", num);
        Console.WriteLine("{0,15:E}", num);

    }
}


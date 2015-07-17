//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
    static void Main()
    {
        int startNumber = 1;
        int endNumber = 100;
        Console.WriteLine("Enter numbers");
        ReadNumber(startNumber, endNumber);
    }

    private static void ReadNumber(int start, int end)
    {
        int previousNumber = 0;
        for (int i = 0; i < 10; i++)
        {
            try
            {
                int current = int.Parse(Console.ReadLine());

                if (current < start || current > end || current <= previousNumber)
                {
                    throw new ArgumentOutOfRangeException();
                }

                previousNumber = current;

            }

            catch (FormatException)
            {
                Console.WriteLine("Non-number text is entered");
                i--;
            }

            catch (ArgumentOutOfRangeException)
            {
                i--;
                Console.WriteLine("Invalid number");
            }
        }
    }
}
using System;

// Problem 5. Larger than neighbours
// • Write a method that checks if the element at given position in given 
// array of integers is larger than its two neighbours (when such exist).


class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Please enter the position of the element (from 0 to 8): ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Sample array = 5, 6, 9, 12, 8, 52, 3, 100");

        int[] nums = { 5, 6, 9, 12, 8, 52, 3, 100 };

        CompareNeighbours(nums, position);
    }

    static void CompareNeighbours(int[] numbers, int a)
    {
        bool isBigger = true;

        if ((a == numbers.Length) || (a == 0))
        {
            Console.WriteLine("The element on this position does not have two neighbours.");
            return;
        }

        if ((numbers[a] > numbers[a + 1]) && (numbers[a] > numbers[a - 1]))
        {
            isBigger = true;
            Console.WriteLine("number[{0}] > number [{1}] and number[{2}] --> {3}", a, a + 1, a - 1, isBigger);
        }
        else
        {
            isBigger = false;
            Console.WriteLine("number[{0}] > number [{1}] and number[{2}] --> {3}", a, a + 1, a - 1, isBigger);
        }
    }
}


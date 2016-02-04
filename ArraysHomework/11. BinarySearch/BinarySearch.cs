using System;

// Problem 11. Binary search
// • Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

public class BinarySearch
{
    public static void Main()
    {
        Console.WriteLine("Please enter the elements of the array, separated by space: ");

        string input = Console.ReadLine();
        string[] inputArr = input.Split(' ');
        int[] nums = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            nums[i] = int.Parse(inputArr[i]);
        }

        Console.WriteLine("Please enter the element which index needs to be found: ");
        int number = int.Parse(Console.ReadLine());

        Array.Sort(nums);
        Console.Write("The sorted array is:");

        for (int i = 0; i < inputArr.Length; i++)
        {
            Console.Write(" {0} ", nums[i]);
        }

        Console.WriteLine();

        int result = Array.BinarySearch(nums, number);
        Console.WriteLine("Index of {0} = {1}", number, result);
    }
}

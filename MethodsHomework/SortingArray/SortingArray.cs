using System;

// Problem 9. Sorting array
// • Write a method that returns the maximal element in a portion of array of integers starting at given index.
// • Using it write another method that sorts an array in ascending / descending order.

class SortingArray
{
    static void Main()
    {
        int[] nums = { 5, 100, 13, 100, 9, 7, 51 };
        int startIndex = 4;
        Console.WriteLine("Sample array = 5, 100, 13, 100, 9, 7, 51");
        Console.WriteLine("Start index = {0}", startIndex);
        Console.WriteLine("Max element = {0}", MaxElement(nums, startIndex));

        SortDescending(nums);
    }

    static void SortDescending(int[] nums)
    {
        int maxValue = int.MinValue;
        int temp = 0;
        int index = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            maxValue = MaxElement(nums, i);
            index = Array.LastIndexOf(nums, maxValue);
            temp = nums[i];
            nums[i] = maxValue;
            nums[index] = temp;

            Console.Write("{0} ", maxValue);
        }

        Console.WriteLine();
    }

    static int MaxElement(int[] nums, int startIndex)
    {
        int max = nums[startIndex];

        for (int i = startIndex; i < nums.Length - 1; i++)
        {
            if (max < nums[i + 1])
            {
                max = nums[i + 1];
            }
        }

        return max;
    }
}


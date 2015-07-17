using System;

// Problem 14. Integer calculations
// • Write methods to calculate  minimum ,  maximum ,  average ,  sum  and  product  of given set of integer numbers.
// • Use variable number of arguments.

class IntegerCalculations
{
    static void Main()
    {
        //int[] nums = { 5, 9, 22, -5, 8 };
        //int[] nums = { 13, 0, 0, 9, 3, -5, 8 };
        Console.WriteLine("Sample set of integer numbers = 3, 5, 8");
        FindMin(3, 5, 8);
        FindMax(3, 5, 8);
        CalculateAverage(3, 5, 8);
        CalculateSum(3, 5, 8);
    }

    static void CalculateSum(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
        }

        Console.WriteLine("Sum = {0}", sum);
    }

    static void CalculateAverage(params int[] nums)
    {
        decimal count = nums.Length;
        int sum = 0;
        decimal average = 0m;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
        }

        average = sum / count;

        Console.WriteLine("Average = {0:0.00}", average);
    }

    static void FindMax(params int[] nums)
    {
        int max = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }

        Console.WriteLine("Max number = {0}", max);
    }

    static void FindMin(params int[] nums)
    {
        int min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        Console.WriteLine("Min number = {0}", min);
    }
}

using System;

// Problem 8. Maximal sum
// • Write a program that finds the sequence of maximal sum in given array.
// Can you do it with only one loop (with single scan through the elements of the array)? 

class MaxSum
{
    static void Main()
    {
        //string input = Console.ReadLine();
        string input = "2, 3, -6, -1, 2, -1, 6, 4, -8, 8";
        //string input = "5, 7, 10, 11, 12";
        //string input = "-1, -2, -3, 5";

        string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] nums = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            nums[i] = int.Parse(inputArr[i]);
        }

        int currentSum = 0;
        int currentSumIndex = -1;
        int currentSumCount = 0;
        int maxSum = int.MinValue;
        int maxSumIndex = -1;
        int maxSumCount = 0;


        for (int i = 0; i < inputArr.Length; i++)
        {
            currentSum = currentSum + nums[i];
            currentSumIndex = i;
            currentSumCount++;

            if (currentSum <= 0)
            {
                currentSum = 0;
                currentSumIndex = -1;
                currentSumCount = 0;
            }

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
                maxSumIndex = currentSumIndex;
                maxSumCount = currentSumCount;
            }
        }

        for (int i = 0; i < maxSumCount; i++)
        {
            Console.Write("{0}", nums[maxSumIndex - maxSumCount + i + 1]);
            if (i != maxSumCount - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}

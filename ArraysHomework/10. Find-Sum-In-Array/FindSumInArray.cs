using System;

// Problem 10. Find sum in array
// • Write a program that finds in given array of integers a sequence of given sum  S  (if present).

public class FindSumInArray
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

        Console.WriteLine("Please enter the sum S: ");
        int targetSum = int.Parse(Console.ReadLine());
        int currentSum = 0;
        string result = string.Empty;
        int position = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            currentSum = currentSum + nums[i];

            result = result + nums[i] + " ";

            if (currentSum == targetSum)
            {
                Console.WriteLine(result);
            }

            if (currentSum > targetSum)
            {
                position++;
                i = position - 1;
                currentSum = 0;
                result = string.Empty;
            }

            if ((position == inputArr.Length) && (currentSum != targetSum))
            {
                Console.WriteLine("No matching numbers");
            }
        }
    }
}

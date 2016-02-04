using System;

// Problem 4. Binary search
// • Write a program, that reads from the console an array of  N  integers 
// and an integer  K , sorts the array and using the method  Array.BinSearch()  finds 
// the largest number in the array which is ≤  K . 

public class BinarySearch
{
    public static void Main()
    {
        int[] nums = { -21, 5, 1, 9, 2, 13, 17, 2, 59, 100, 21 };

        Console.WriteLine("Please enter K: ");
        int targetValue = int.Parse(Console.ReadLine());
        int k = targetValue;

        Array.Sort(nums);

        if (nums[0] > k)
        {
            Console.WriteLine("All elements in the array are larger than {0}.", targetValue);
            return;
        }

        while (k >= nums[0])
        {
            int index = Array.BinarySearch(nums, k);

            if (index < 0)
            {
                k--;
            }

            if (index >= 0)
            {
                Console.WriteLine("The largest number in the array which is <= {0} is at position [{1}] and is equal to {2}.", targetValue, index, nums[index]);
                return;
            }
        }
    }
}

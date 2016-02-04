using System;

// Problem 4. Appearance count
// • Write a method that counts how many times given number appears in given array.
// • Write a test program to check if the method is workings correctly.

class AppearanceCount
{
    static void CountAppearance(int[] nums, int targetNum)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == targetNum)
            {
                count++;
            }
        }

        Console.WriteLine("{0} appears {1} times in the array.", targetNum, count);
    }

    static void Main()
    {
        Console.WriteLine("Please enter the number which count of appearance needs to be found: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the elements of the array: ");

        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array[{0}] = ", i);
            nums[i] = int.Parse(Console.ReadLine());
        }

        CountAppearance(nums, m);
    }
}

using System;

// Problem 4. Binary search
// • Write a program, that reads from the console an array of  N  integers 
// and an integer  K , sorts the array and using the method  Array.BinSearch()  finds 
// the largest number in the array which is ≤  K . 


class BinarySearch
{
    static void Main()
    {
        int[] nums = { -21, 5, 1, 9, 2, 13, 17, 2, 59, 100, 21 };
        // {2, 100, 79, 6, 10, 59, 14};
        // {33, 1, 77, 11, 15, 100};
        // {4, 59, 8, 12, 16};

        //Console.WriteLine("Please enter the values of the array, separated by comma: ");
        //string input = Console.ReadLine();
        //string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //int[] nums = new int[inputArr.Length];
        //for (int i = 0; i < inputArr.Length; i++)
        //{
        //    nums[i] = int.Parse(inputArr[i]);
        //}

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

using System;

// Problem 7. Selection sort
// • Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// • Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
// from the rest, move it at the second position, etc.


class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Please enter the elements of the array, separated by comma: ");
        string input = Console.ReadLine();

        string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            nums[i] = int.Parse(inputArr[i]);
        }

        int minValue = int.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < inputArr.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i; j < inputArr.Length; j++)
            {
                if (minValue > nums[j])
                {
                    minValue = nums[j];
                    minIndex = j;
                }
            }

            int temp = nums[i];
            nums[i] = minValue;
            nums[minIndex] = temp;
        }

        Console.Write(string.Join(", ", nums));
        Console.WriteLine();
    }
}

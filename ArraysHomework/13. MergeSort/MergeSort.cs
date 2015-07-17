using System;

// Problem 13.* Merge sort
// • Write a program that sorts an array of integers using the Merge sort algorithm.


    class MergeSort
    {
        static void Main()
        {
            //Console.WriteLine("Please enter the elements of the array, separated by comma: ");
            //string input = Console.ReadLine();
            string input = "5, 9, 15, 100, 36, 17";

            string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] nums = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++)
            {
                nums[i] = int.Parse(inputArr[i]);
            }




        }
    }

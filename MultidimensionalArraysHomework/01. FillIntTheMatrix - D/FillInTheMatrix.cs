// Problem 1. Fill the matrix
// • Write a program that fills and prints a matrix of size  (n, n)  as shown below:

//1 12 11 10 
//2 13 16  9 
//3 14 15  8 
//4  5  6  7 

using System;

public class FillInTheMatrix
{
    public static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] nums = new int[n, n];
        int lastValue = 0;

        for (int col = 0; col < 1; col++)
        {
            for (int row = 0; row < n; row++)
            {
                nums[row, col] = lastValue + 1;
                lastValue = nums[row, col];
            }
        }

        for (int row = n - 1; row < n; row++)
        {
            for (int col = 1; col < n; col++)
            {
                nums[row, col] = lastValue + 1;
                lastValue = nums[row, col];
            }
        }

        for (int col = n - 1; col < n; col++)
        {
            for (int row = n - 2; row >= 0; row--)
            {
                nums[row, col] = lastValue + 1;
                lastValue = nums[row, col];
            }
        }

        for (int row = 0; row < 1; row++)
        {
            for (int col = n - 2; col >= 0 + 1; col--)
            {
                nums[row, col] = lastValue + 1;
                lastValue = nums[row, col];
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0} ", nums[row, col]);
            }

            Console.WriteLine();
        }
    }
}

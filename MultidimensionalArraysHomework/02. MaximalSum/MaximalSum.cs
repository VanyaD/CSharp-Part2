using System;

// Problem 2. Maximal sum
// • Write a program that reads a rectangular matrix of size  N x M  and finds in 
// it the square  3 x 3  that has maximal sum of its elements.

public class MaximalSum
{
    public static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter M: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the elements of the matrix: ");

        long bestSum = long.MinValue;
        int bestCol = 0;
        int bestRow = 0;
        long sum = 0;

        int[,] nums = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Matrix [{0},{1}] = ", i, j);
                nums[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                sum = nums[i, j] + nums[i, j + 1] + nums[i, j + 2]
                    + nums[i + 1, j] + nums[i + 1, j + 1] + nums[i + 1, j + 2]
                    + nums[i + 2, j] + nums[i + 2, j + 1] + nums[i + 2, j + 2];

                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestCol = j;
                    bestRow = i;
                }
            }
        }

        Console.WriteLine("Best sum = {0}", bestSum);
        Console.Write("{0} ", nums[bestRow, bestCol]);
        Console.Write("{0} ", nums[bestRow, bestCol + 1]);
        Console.WriteLine("{0} ", nums[bestRow, bestCol + 2]);
        Console.Write("{0} ", nums[bestRow + 1, bestCol]);
        Console.Write("{0} ", nums[bestRow + 1, bestCol + 1]);
        Console.WriteLine("{0} ", nums[bestRow + 1, bestCol + 2]);
        Console.Write("{0} ", nums[bestRow + 2, bestCol]);
        Console.Write("{0} ", nums[bestRow + 2, bestCol + 1]);
        Console.WriteLine("{0} ", nums[bestRow + 2, bestCol + 2]);
    }
}

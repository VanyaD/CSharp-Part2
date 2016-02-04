using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] nums = new int[n, n];
        int lastVal = 1;

        //7 11 14 16    0 row
        //4  8 12 15    1 row
        //2  5  9 13    2 row
        //1  3  6 10    3 row

        nums[n - 1, 0] = 1;

        for (int row = n - 2; row >= 0; row--)
        {

            for (int col = 0; col < n - row; col++)
            {
                nums[row + col, col] = lastVal + 1;
                lastVal = nums[row + col, col];
            }

            if (row == 0)
            {
                for (int k = 0; k < n - 1; k++)
                {
                    nums[row, k + 1] = lastVal + 1;
                    lastVal = nums[row, k + 1];

                    for (int col = 1; col < n - 1 - k; col++)
                    {
                        nums[row + col, col + 1 + k] = lastVal + 1;
                        lastVal = nums[row + col, col + 1 + k];
                    }
                }
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


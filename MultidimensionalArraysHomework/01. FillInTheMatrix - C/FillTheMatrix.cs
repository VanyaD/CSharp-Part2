using System;

// Problem 1. Fill the matrix
// • Write a program that fills and prints a matrix of size  (n, n)  as shown below:

//  b)   1 8  9 16 
//       2 7 10 15 
//       3 6 11 14 
//       4 5 12 13 

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[,] nums = new int[n, n];
        int lastValue = 0;
        int firstRowValue = 0;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 != 0)
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    nums[row, col] = lastValue + n - row;

                    if (row == 0)
                    {
                        firstRowValue = nums[row, col];
                    }
                }
            }

            else
            {
                for (int row = 0; row < n; row++)
                {
                    nums[row, col] = row + 1 + firstRowValue;

                    if (row == n - 1)
                    {
                        lastValue = nums[row, col];
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

        Console.WriteLine();
    }
}
using System;

// Problem 1. Fill the matrix
// • Write a program that fills and prints a matrix of size  (n, n)  as shown below:

//        1 5  9 13 
//a)      2 6 10 14  
//        3 7 11 15 
//        4 8 12 16 

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] nums = new int[n, n];
        int lastRowValue = 0;

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                nums[row, col] = row + 1 + lastRowValue;

                if (row == n - 1)
                {
                    lastRowValue = nums[row, col];
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


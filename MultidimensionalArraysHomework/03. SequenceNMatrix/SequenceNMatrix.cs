using System;

// Problem 3. Sequence n matrix
// • We are given a matrix of strings of size  N x M . Sequences in the matrix we define 
// as sets of several neighbour elements located on the same line, column or diagonal.
// • Write a program that finds the longest sequence of equal strings in the matrix.

public class SequenceNMatrix
{
    public static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter M: ");
        int m = int.Parse(Console.ReadLine());

        int countRow = 1;
        int bestCountRow = 0;
        int countCol = 1;
        int bestCountCol = 0;
        int countDiagonal = 1;
        int bestCountDiagonal = 0;
        string bestStringRow = string.Empty;
        string bestStringCol = string.Empty;
        string bestStringDiagonal = string.Empty;

        Console.WriteLine("Please enter the elements of the array: ");

        string[,] elements = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Matrix [{0},{1}] = ", i, j);
                elements[i, j] = Console.ReadLine();
            }
        }

        for (int i = 0; i < n; i++)
        {
            countRow = 1;
            for (int j = 0; j < m - 1; j++)
            {
                if (elements[i, j] == elements[i, j + 1])
                {
                    countRow++;
                }
                if (bestCountRow < countRow)
                {
                    bestCountRow = countRow;
                    bestStringRow = elements[i, j];
                }
            }
        }

        for (int col = 0; col < m; col++)
        {
            countCol = 1;
            for (int row = 0; row < n - 1; row++)
            {
                if (elements[row, col] == elements[row + 1, col])
                {
                    countCol++;
                }
                if (bestCountCol < countCol)
                {
                    bestCountCol = countCol;
                    bestStringCol = elements[row, col];
                }
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {

                if (elements[row + col, col] == elements[row + col + 1, col + 1])
                {
                    countDiagonal++;
                }
                else
                {
                    countDiagonal = 1;
                }

                if (bestCountDiagonal < countDiagonal)
                {
                    bestCountDiagonal = countDiagonal;
                    bestStringDiagonal = elements[row, col];
                }

            }

            if (row == 0)
            {
                for (int k = 0; k < n - 1; k++)
                {
                    for (int col = 1; col < n - 1 - k; col++)
                    {
                        elements[row, k + 1] = elements[row + col, col + 1 + k];
                        countDiagonal++;

                        if (bestCountDiagonal < countDiagonal)
                        {
                            bestCountDiagonal = countDiagonal;
                            bestStringDiagonal = elements[row, col];
                        }
                    }
                }
            }
        }

        if ((bestCountCol > bestCountDiagonal) && (bestCountCol > bestCountRow))
        {
            Console.WriteLine("Longest Sequence = {0} x {1}", bestCountCol, bestStringCol);
        }

        if ((bestCountRow > bestCountDiagonal) && (bestCountRow > bestCountCol))
        {
            Console.WriteLine("Longest Sequence = {0} x {1}", bestCountRow, bestStringRow);
        }

        if ((bestCountDiagonal > bestCountRow) && (bestCountDiagonal > bestCountCol))
        {
            Console.WriteLine("Longest Sequence = {0} x {1}", bestCountDiagonal, bestStringDiagonal);
        }
    }
}

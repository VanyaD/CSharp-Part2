// Problem 6.* Matrix class
//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding,
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
using System.Collections.Generic;

class MatrixClass
{
    public class Matrix
    {
        private int[,] matrix;

        public Matrix(int height, int width)
        {
            this.matrix = new int[height, width];
        }

        public int Width
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public int Height
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Height, first.Width);
            for (int i = 0; i < first.Height; i++)
            {
                for (int j = 0; j < first.Width; j++)
                {
                    result[i, j] = first[i, j] + second[i, j];
                }
            }
            return result;
        }

        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }
    }

    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 1] = 2;
        matrix1[1, 1] = 24;

        Matrix matrix2 = new Matrix(2, 2);
        matrix1[0, 1] = 2;
        matrix1[1, 1] = 24;

        Matrix sum = matrix1 + matrix2;
        PrintMatrix(sum);
    }

    private static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.Height; i++)
        {
            for (int j = 0; j < matrix.Width; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}

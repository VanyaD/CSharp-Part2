// Problem 6.* Matrix class
//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding,
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
using System.Text;

public class MatrixClass
{
    public class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
            this.Rows = rows;
            this.Cols = cols;
        }

        public int Rows
        {
            get { return rows; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Rows count cannot be less than 1.");
                }

                rows = value;
            }
        }

        public int Cols
        {
            get { return cols; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Cols count cannot be less than 1.");
                }

                cols = value;
            }
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

        public static Matrix operator +(Matrix first, Matrix second)
        {
            if (first.Cols != second.Cols || first.Rows != second.Rows)
            {
                throw new Exception("Adding cannot be applied to matrices with different dimensions.");
            }

            Matrix result = new Matrix(first.Rows, first.Cols);

            for (int i = 0; i < first.Rows; i++)
            {
                for (int j = 0; j < first.Cols; j++)
                {
                    result[i, j] = first[i, j] + second[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            if (first.Cols != second.Cols || first.Rows != second.Rows)
            {
                throw new Exception("Substraction cannot be applied to matrices with different dimensions.");
            }

            Matrix result = new Matrix(first.Rows, first.Cols);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.Cols != second.Rows || first.Rows != second.Cols)
            {
                throw new Exception("Multiplication cannot be applied to matrices with these dimensions.");
            }

            Matrix result = new Matrix(first.Rows, first.Cols);
            int temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = 0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += first[matrixRow, index] * second[index, matrixCol];
                    }
                    result[matrixRow, matrixCol] = temp;
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

    public static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 2;
        matrix1[0, 1] = 24;
        matrix1[1, 0] = 2;
        matrix1[1, 1] = 24;
        Console.WriteLine(matrix1.ToString());

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 0] = 3;
        matrix2[0, 1] = 25;
        matrix2[1, 0] = 3;
        matrix2[1, 1] = 25;
        Console.WriteLine(matrix2.ToString());

        Console.WriteLine("---------------------");
        Matrix sum = matrix1 + matrix2;
        Console.WriteLine(sum.ToString());
    }
}

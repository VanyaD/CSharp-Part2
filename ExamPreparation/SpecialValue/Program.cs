using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int[] numsOnEntryRow;
    static int[] numsOnRow;
    static int[][] jagged;

    static void Main()
    {
        int numberOfRows = int.Parse(Console.ReadLine());
        string[] valuesOnRow = new string[numberOfRows];
        int allPossibleSteps = 0;
        int[][] jagged = new int[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            valuesOnRow[i] = Console.ReadLine();

            string[] valuesOnRowArr = valuesOnRow[i].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            jagged[i] = new int[valuesOnRowArr.Length];

            for (int j = 0; j < valuesOnRowArr.Length; j++)
            {
                jagged[i][j] = int.Parse(valuesOnRowArr[j]);
                allPossibleSteps++;
            }
        }

        jagged.Clone();
        long maxSpecialSum = 0;
        long currentSpecialSum = 0;

        for (int entry = 0; entry < jagged[0].Length; entry++)
        {
            currentSpecialSum = GetCurrentSpecialSum(entry, jagged, numberOfRows);

            if (maxSpecialSum < currentSpecialSum)
            {
                maxSpecialSum = currentSpecialSum;
                currentSpecialSum = 0;
            }
        }
        if (maxSpecialSum != 0)
        {
            Console.WriteLine(maxSpecialSum);
        }
    }

    private static long GetCurrentSpecialSum(int entry, int[][] jagged, int numberOfRows)
    {
        int index = entry;
        int newIndex;
        int steps = 1;
        long currentSpecialSum = 0;

        for (int i = 0; i < numberOfRows; i++)
        {
            if (jagged[i][index] < 0)
            {
                currentSpecialSum = steps - (jagged[i][index]);
                break;
            }

            if (jagged[i][index] == 1001)
            {
                break;
            }
            else
            {
                newIndex = jagged[i][index];
                jagged[i][index] = 1001;
                steps++;
                index = newIndex;
            }

            if (i == numberOfRows - 1)
            {
                i = -1;
            }
        }

        return currentSpecialSum;
    }
}


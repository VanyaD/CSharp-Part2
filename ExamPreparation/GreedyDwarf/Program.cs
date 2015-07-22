using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;


class GreedyDwarf
{
    static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\SampleInput.txt");
        //Console.SetIn(reader);

        string input = Console.ReadLine();
        string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] valley1 = new int[inputArr.Length];
        for (int i = 0; i < inputArr.Length; i++)
        {
            valley1[i] = int.Parse(inputArr[i]);
        }

        int countOfPatterns = int.Parse(Console.ReadLine());
        string[] allPatterns = new string[countOfPatterns];
        long maxNumberOfCoinsCollected = long.MinValue;
        long coinsCollected = 0;

        for (int i = 0; i < countOfPatterns; i++)
        {
            allPatterns[i] = Console.ReadLine();
        }

        int[] valley = new int[valley1.Length];

        for (int q = 0; q < countOfPatterns; q++)
        {
            string[] currentPattern = allPatterns[q].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] currentPatternAsNums = new int[currentPattern.Length];
            for (int j = 0; j < currentPattern.Length; j++)
            {
                currentPatternAsNums[j] = int.Parse(currentPattern[j]);
            }

            for (int i = 0; i < inputArr.Length; i++)
            {
                valley[i] = valley1[i];
            }

            coinsCollected = GetNumberOfCoinsCollected(valley, currentPatternAsNums);

            if (coinsCollected > maxNumberOfCoinsCollected)
            {
                maxNumberOfCoinsCollected = coinsCollected;
            }
        }
        Console.WriteLine(maxNumberOfCoinsCollected);
    }

    private static long GetNumberOfCoinsCollected(int[] valley, int[] currentPatternAsNums)
    {
        int index = 0;
        long coinsCollected = valley[0];

        for (int j = 0; j < currentPatternAsNums.Length; j++)
        {
            int newIndex = index + currentPatternAsNums[j];

            if (newIndex < valley.Length && newIndex > 0)
            {
                coinsCollected = coinsCollected + valley[newIndex];

                if (valley[newIndex] == 0)
                {
                    break;
                }
                valley[index] = 0;
                index = newIndex;
            }
            else
            {
                break;
            }

            if (j == currentPatternAsNums.Length - 1)
            {
                j = -1;
            }
        }

        return coinsCollected;
    }
}


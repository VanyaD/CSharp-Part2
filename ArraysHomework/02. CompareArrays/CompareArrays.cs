using System;

//Problem 2. Compare arrays
//• Write a program that reads two integer arrays from the console and compares them element by element.

public class CompareArrays
{
    public static void Main()
    {
        Console.WriteLine("Please enter the values of the first array separated by space:");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Please enter the values of the second array separated by space:");
        string secondInput = Console.ReadLine();

        string[] firstStringArr = firstInput.Split(' ');
        string[] secondStringArr = secondInput.Split(' ');

        bool areEqual = true;

        int[] firstNumsArray = new int[firstStringArr.Length];
        int[] secondNumsArray = new int[secondStringArr.Length];

        if (firstNumsArray.Length == secondNumsArray.Length)
        {
            for (int i = 0; i < firstStringArr.Length; i++)
            {
                firstNumsArray[i] = int.Parse(firstStringArr[i]);
                secondNumsArray[i] = int.Parse(secondStringArr[i]);
            }

            for (int i = 0; i < firstNumsArray.Length; i++)
            {
                if (firstNumsArray[i] != secondNumsArray[i])
                {
                    areEqual = false;
                    Console.WriteLine("The two arrays are not equal");
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine("The two arrays are equal");
            }
        }
        else
        {
            Console.WriteLine("The two arrays are not equal.");
        }
    }
}

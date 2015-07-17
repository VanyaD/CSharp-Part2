using System;

//Problem 2. Compare arrays
//• Write a program that reads two  integer  arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        // for convenience, below you can find a few arrays that you can copy-paste on the console:
        //5 15 32 7 19 100 87
        //7 19 3 15 100 75 9
        //2 9 8 6 100

        Console.WriteLine("Please enter the values of the first array separated by space:");
        string firstInput = Console.ReadLine();

        Console.WriteLine("Please enter the values of the second array separated by space:");
        string secondInput = Console.ReadLine();

        string[] firstStringArr = firstInput.Split(' ');
        string[] secondStringArr = secondInput.Split(' ');

        bool areEqual = false;

        int[] firstNumsArray = new int[firstStringArr.Length];
        int[] secondNumsArray = new int[secondStringArr.Length];

        for (int i = 0; i < firstStringArr.Length; i++)
        {
            firstNumsArray[i] = int.Parse(firstStringArr[i]);
        }

        for (int i = 0; i < secondStringArr.Length; i++)
        {
            secondNumsArray[i] = int.Parse(secondStringArr[i]);
        }

        if (firstNumsArray.Length == secondNumsArray.Length)
        {
            for (int i = 0; i < firstNumsArray.Length; i++)
            {
                if (firstNumsArray[i] == secondNumsArray[i])
                {
                    areEqual = true;
                    Console.WriteLine("A[{0}] is equal to B[{0}] --> {1}", i, areEqual);
                }
                else
                {
                    areEqual = false;
                    Console.WriteLine("A[{0}] is equal to B[{0}] --> {1}", i, areEqual);
                }
            }
        }
        else
        {
            Console.WriteLine("The two arrays are not equal.");
        }
    }
}

using System;

// Problem 8. Number as array
// • Write a method that adds two positive integer numbers represented as arrays 
// of digits (each array element  arr[i]  contains a digit; the last digit is kept in  arr[0] ).
// • Each of the numbers that will be added could have up to  10 000  digits.


class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        string firstNumberStr = Console.ReadLine();

        Console.WriteLine("Please enter the second number: ");
        string secondNumberStr = Console.ReadLine();

        char[] firstNumArr = new char[firstNumberStr.Length];

        for (int i = 0; i < firstNumberStr.Length; i++)
        {
            firstNumArr[firstNumberStr.Length - 1 - i] = firstNumberStr[i];
        }

        char[] secondNumArr = new char[secondNumberStr.Length];

        for (int i = 0; i < secondNumberStr.Length; i++)
        {
            secondNumArr[secondNumberStr.Length - 1 - i] = secondNumberStr[i];
        }

        SumNumbersAsArray(firstNumArr, secondNumArr);
    }

    static void SumNumbersAsArray(char[] firstNumArr, char[] secondNumArr)
    {

        int[] firstNum = new int[firstNumArr.Length];

        for (int i = 0; i < firstNumArr.Length; i++)
        {
            firstNum[i] = firstNumArr[i] - 48;
        }

        int[] secondNum = new int[secondNumArr.Length];

        for (int i = 0; i < secondNumArr.Length; i++)
        {
            secondNum[i] = secondNumArr[i] - 48;
        }

        int currentSum = 0;
        string result = string.Empty;
        int oneInMind = 0;

        if (firstNumArr.Length > secondNumArr.Length)
        {
            for (int i = 0; i < firstNumArr.Length - 1; i++)
            {
                currentSum = firstNum[i] + secondNum[i] + oneInMind;

                if ((currentSum >= 10) && (i != firstNum.Length - 1))
                {
                    currentSum = firstNum[i] + secondNum[i] - 10 + oneInMind;
                    oneInMind = 1;
                }
                else
                {
                    currentSum = firstNum[i] + secondNum[i];
                    oneInMind = 0;
                }

                result = result + currentSum;
            }

            if (firstNumArr.Length == secondNumArr.Length)
            {
                for (int i = 0; i < firstNumArr.Length - 1; i++)
                {
                    currentSum = firstNum[i] + secondNum[i] + oneInMind;

                    if ((currentSum >= 10) && (i != firstNum.Length - 1))
                    {
                        currentSum = firstNum[i] + secondNum[i] - 10 + oneInMind;
                        oneInMind = 1;
                    }
                    else
                    {
                        currentSum = firstNum[i] + secondNum[i];
                        oneInMind = 0;
                    }

                    result = result + currentSum;
                }
            }

            Console.Write("The sum of the numbers is ");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[result.Length - 1 - i]);
            }

            Console.WriteLine();
        }
    }
}

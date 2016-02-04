using System;

// Problem 8. Number as array
// • Write a method that adds two positive integer numbers represented as arrays 
// of digits (each array element  arr[i]  contains a digit; the last digit is kept in arr[0] ).
// • Each of the numbers that will be added could have up to  10 000  digits.

class NumberAsArray
{
    static void Main()
    {
        char[] firstCharArr = new char[] { '1', '2', '3' };
        char[] secondCharArr = new char[] { '4', '5', '6' };

        SumNumbersAsArray(firstCharArr, secondCharArr);
    }

    static void SumNumbersAsArray(char[] firstCharArr, char[] secondCharArr)
    {
        string firstNumberAsString = String.Empty;
        for (int i = 0; i < firstCharArr.Length; i++)
        {
            firstNumberAsString = firstNumberAsString + firstCharArr[i];
        }

        int firstNumber = 0;
        double multiplication = Math.Pow(10, firstNumberAsString.Length - 1);

        for (int i = 0; i < firstNumberAsString.Length; i++)
        {
            firstNumber = firstNumber + ((int)((firstNumberAsString[firstNumberAsString.Length - i - 1] - 48) * multiplication));
            multiplication /= 10;
        }

        string secondNumberAsString = String.Empty;
        for (int i = 0; i < secondCharArr.Length; i++)
        {
            secondNumberAsString = secondNumberAsString + secondCharArr[i];
        }

        int secondNumber = 0;
        double multiplication2 = Math.Pow(10, secondNumberAsString.Length - 1);

        for (int i = 0; i < secondNumberAsString.Length; i++)
        {
            secondNumber = secondNumber + ((int)((secondNumberAsString[secondNumberAsString.Length - i - 1] - 48) * multiplication2));
            multiplication2 /= 10;
        }

        int sum = firstNumber + secondNumber;
        Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, sum);
    }
}

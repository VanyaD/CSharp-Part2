using System;

// Problem 10. N Factorial
// • Write a program to calculate  n!  for each  n  in the range [ 1..100 ].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

class NFactorial
{
    static void Main()
    {
        Console.WriteLine("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        long factorial = CalculateNFactorial(n);
        Console.WriteLine("{0}! = {1}", n, factorial);
    }

    static long CalculateNFactorial(int n)
    {
        int[] nums = new int[n];
        long result = 1;
        for (int i = 0; i < n; i++)
        {
            nums[i] = i + 1;
            result = result * nums[i];
        }

        return result;
    }
}

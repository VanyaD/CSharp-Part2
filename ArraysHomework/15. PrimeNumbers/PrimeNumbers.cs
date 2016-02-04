using System;

// Problem 15. Prime numbers
// • Write a program that finds all prime numbers in the range [ 1...10 000 000 ]. Use the Sieve of Eratosthenes algorithm.

public class PrimeNumbers
{
    public static void Main()
    {
        bool[] аrr = new bool[10];

        for (int i = 2; i < Math.Sqrt(аrr.Length); i++)
        {
            if (аrr[i] == false)
            {
                for (int j = i * i; j < аrr.Length; j = j + i)
                {
                    аrr[j] = true;
                }
            }
        }

        for (int i = 2; i < аrr.Length; i++)
        {
            if (аrr[i] == false)
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}


using System;

// Problem 7. Reverse number
// • Write a method that reverses the digits of given decimal number.

// Example:
// input: 256
// output: 652

class ReverseNumber
{
    static void Main()
    {
        decimal num = 10256m;
        string nums = Convert.ToString(num);
        Console.WriteLine("Original number = {0}", num);

        ReverseNumberMethod(nums);
    }

    static void ReverseNumberMethod(string input)
    {
        Console.Write("Reversed number = ");

        for (int i = input.Length - 1; i >= 0; i--)
        {

            if (i == 0)
            {
                Console.WriteLine("{0}", input[i]);
            }
            else
            {
                Console.Write("{0}", input[i]);
            }
        }
    }
}

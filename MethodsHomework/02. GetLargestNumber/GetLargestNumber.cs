using System;

class GetLargestNumber
{
    static void GetMax(int a, int b)
    {
        if (a < b)
        {
            Console.WriteLine("The bigger number is {0}.", b);
        }
        else
        {
            Console.WriteLine("The bigger number is {0}.", a);
        }

        if (a == b)
        {
            Console.WriteLine("Both numbers are equal.");
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter two numbers (on different rows): ");
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());

        GetMax(input1, input2);
    }
}

using System;

// Problem 13. Solve tasks
// • Write a program that can solve these tasks: 
// ◦ Reverses the digits of a number
// ◦ Calculates the average of a sequence of integers
// ◦ Solves a linear equation  a * x + b = 0  

// • Provide a simple text-based menu for the user to choose which task to solve.
// • Validate the input data: 
// ◦ The decimal number should be non-negative
// ◦ The sequence should not be empty
// ◦  a  should not be equal to  0  

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Please choose one of the following options: ");
        Console.WriteLine();
        Console.WriteLine("1: Reverse the digits of a number");
        Console.WriteLine("2: Calculate the average of a sequence of integers");
        Console.WriteLine("3: Solve a linear equation  a * x + b = 0");
        Console.WriteLine();
        Console.Write("Your choice: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Please enter the number: ");
                string inputChoice1 = Console.ReadLine();
                ReverseNumberDigits(inputChoice1);
                break;
            case 2:
                Console.WriteLine();
                Console.WriteLine("Please enter the numbers, separated by comma: ");
                string inputChoice2 = Console.ReadLine();
                CalculateAverageOfIntegersSequence(inputChoice2);
                break;
            case 3:
                Console.WriteLine();
                Console.WriteLine("Please enter the linear equation: ");
                string inputChoice3 = Console.ReadLine();
                SolveLinearEquation(inputChoice3);
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Not a valid choice!");
                break;
        }
    }

    static void SolveLinearEquation(string input)
    {
        // 2 * x + 4 = 0
        double x;

        int digitsOfA = input.IndexOf('x') - 3;
        string a = string.Empty;
        double coeffA = 0;

        for (int i = 0; i < digitsOfA; i++)
        {
            coeffA = coeffA + (input[digitsOfA - 1 - i] - 48) * Math.Pow(10, i);
        }

        int digitsOfB = input.IndexOf('=') - input.IndexOf('+') - 3;
        string b = string.Empty;
        double coeffB = 0;

        for (int i = 0; i < digitsOfB; i++)
        {
            coeffB = coeffB + (input[input.IndexOf('=') - 2 - i] - 48) * Math.Pow(10, i);
        }

        if (coeffA != 0)
        {
            x = -(coeffB / coeffA);
            Console.WriteLine("x = {0:0.00}", x);
        }

        if ((coeffA == 0) && (coeffB != 0))
        {
            Console.WriteLine("The equation does not have any solution, as it is inconcistent.");
        }

        if ((coeffA == 0) && (coeffB == 0))
        {
            Console.WriteLine("Every number is a solution.");
        }
    }

    private static void CalculateAverageOfIntegersSequence(string input)
    {
        string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] nums = new int[inputArr.Length];
        int sum = 0;

        for (int i = 0; i < inputArr.Length; i++)
        {
            nums[i] = int.Parse(inputArr[i]);
            sum = sum + nums[i];
        }

        decimal average = (decimal)sum / inputArr.Length;
        Console.WriteLine("The average of these numbers is {0: 0.00}.", average);
    }

    static void ReverseNumberDigits(string input)
    {
        char[] output = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = input[input.Length - 1 - i];
        }

        Console.Write(string.Join("", output));
        Console.WriteLine();
    }
}

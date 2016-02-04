using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class BunnyFactory
{
    static void Main()
    {
        List<int> nums = new List<int>();
        bool notEnd = true;
        int count = 0;

        while (notEnd)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                notEnd = false;
            }
            else
            {
                nums.Add(int.Parse(input));
                count++;
            }
        }

        int initialSum = 0;
        BigInteger nextSum = 0;
        BigInteger product = 1;
        StringBuilder currentResult = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            currentResult.Append(nums[i]);
        }

        for (int i = 0; i <= count; i++) // nadolu
        {
            if (i >= count)
            {

                Console.Write(string.Join(" ", nums));
                Console.WriteLine();
                return;
            }

            for (int k = 0; k <= i; k++)
            {
                initialSum = initialSum + nums[k];
            }

            if (initialSum <= count - i)
            {
                currentResult.Clear();

                for (int j = 1; j < initialSum + 1; j++)
                {
                    nextSum = nextSum + nums[j + i];
                    product = product * nums[j + i];
                }

                currentResult.Append(nextSum);
                currentResult.Append(product);

                for (int m = 0; m < count - (i + 1 + initialSum); m++)
                {
                    currentResult.Append(nums[initialSum + 1 + i + m]);
                }

                if (i == count)
                {
                    Console.Write(string.Join(" ", nums));
                    Console.WriteLine();
                    return;
                }

                nextSum = 0;
                product = 1;
                initialSum = 0;

                for (int j = 0; j < currentResult.Length; j++)
                {
                    if (currentResult[j] == '0')
                    {
                        currentResult.Remove(j, 1);
                        j = j - 1;
                        if (j < 0)
                        {
                            j = 0;
                        }
                    }

                    if (currentResult[j] == '1')
                    {
                        currentResult.Remove(j, 1);
                        j = j - 1;
                        if (j < 0)
                        {
                            j = 0;
                        }
                    }
                }

                nums.Clear();
                count = 0;

                for (int k = 0; k < currentResult.Length; k++)
                {
                    nums.Add(currentResult[k] - 48);
                    count++;
                }
            }
            else
            {
                Console.Write(string.Join(" ", nums));
                Console.WriteLine();
                return;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Numerics;

class KaspichanNumbers
{
    static void Main()
    {
        BigInteger dec = BigInteger.Parse(Console.ReadLine());
        List<BigInteger> nums = new List<BigInteger>();
        BigInteger remainder = 0;
        int count = 0;

        if (dec == 0)
        {
            Console.WriteLine("A");
        }

        while (dec > 0)
        {
            remainder = dec % 256;
            dec = dec / 256;
            nums.Add(remainder);
            count++;
        }

        nums.Reverse();

        BigInteger count2 = 0;
        BigInteger remainder2 = 0;
        BigInteger number2 = 0;
        List<char> result = new List<char>();

        for (int i = 0; i < count; i++)
        {
            if (nums[i] < 26)
            {
                result.Add((char)(nums[i] + 65));
            }
            else
            {
                remainder2 = nums[i] % 26;
                number2 = nums[i] / 26;
                nums.Add(number2);
                nums.Add(remainder2);
                result.Add((char)(number2 + 96));
                result.Add((char)(remainder2 + 65));
            }
        }

        foreach (char res in result)
        {
            Console.Write(res);
        }

        Console.WriteLine();
    }
}


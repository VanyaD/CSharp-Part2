using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.DurankulakNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> codes = new List<string>();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().Any(char.IsUpper))
                {
                    codes.Add(input[i].ToString());
                    count++;
                }
                else
                {
                    codes.Add(input[i].ToString() + input[i + 1].ToString());
                    i++;
                    count++;
                }
            }
            BigInteger[] nums = new BigInteger[count];
            BigInteger dec = 0;
            for (int i = 0; i < count; i++)
            {
                string newString = codes[i].ToString();

                if (newString.Length == 2)
                {
                    nums[i] = ((char)newString[0] - 96) * 26 + (char)newString[1] - 65;
                }
                else
                {
                    nums[i] = (char)newString[0] - 65;
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (nums[i] == '0')
                {
                    continue;
                }
                else
                {
                    dec = dec + nums[nums.Length - 1 - i] * BigInteger.Pow(168, i);
                }
            }

            Console.WriteLine(dec);
        }
    }
}


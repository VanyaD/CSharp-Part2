using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class StrangeLandNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] codes = new string[] { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
        int index = 0;
        string temp = input;

        for (int i = 0; i < 7; i++)
        {
            index = input.IndexOf(codes[i]);
            if (index >= 0)
            {
                temp = temp.Replace(codes[i], i.ToString());
            }
        }

        BigInteger dec = 0;
        BigInteger num = 0;

        for (int i = 0; i < temp.Length; i++)
        {
            num = temp[temp.Length - 1 - i] - 48;
            dec = dec + num * BigInteger.Pow(7, i);
        }

        Console.WriteLine(dec);
    }
}


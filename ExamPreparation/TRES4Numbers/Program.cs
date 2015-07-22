using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class TRES4Numbers
{
    static void Main()
    {
        BigInteger dec = BigInteger.Parse(Console.ReadLine());
        BigInteger remainder = 0;
        BigInteger num = dec;
        StringBuilder output = new StringBuilder();

        if (dec == 0)
        {
            Console.Write("LON+");
        }

        while (num > 0) 
        {
            remainder = num % 9;
            num = num / 9;
            output.Append(remainder);
        }


        for (int i = 0; i < output.Length; i++)
        {
            switch (output[output.Length - 1 - i])
            {
                case '0':
                    Console.Write("LON+");
                    break;
                case '1':
                    Console.Write("VK-");
                    break;
                case '2':
                    Console.Write("*ACAD");
                    break;
                case '3':
                    Console.Write("^MIM");
                    break;
                case '4':
                    Console.Write("ERIK|");
                    break;
                case '5':
                    Console.Write("SEY&");
                    break;
                case '6':
                    Console.Write("EMY>>");
                    break;
                case '7':
                    Console.Write("/TEL");
                    break;
                case '8':
                    Console.Write("<<DON");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        Console.WriteLine();
    }
}


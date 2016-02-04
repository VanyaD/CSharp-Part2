using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sizeOfCodeTable = int.Parse(Console.ReadLine());
        string[] test = new string[sizeOfCodeTable];

        for (int i = 0; i < sizeOfCodeTable; i++)
        {
            test[i] = Console.ReadLine();
        }

        Array.Sort(test, (x1, x2) => x1.Length.CompareTo(x2.Length));

        StringBuilder codesStr = new StringBuilder();
        for (int i = 0; i < sizeOfCodeTable; i++)
        {
            codesStr.Append(test[i]);
        }

        string[] inputArr = input.Split(' ');
        int[] decs = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            decs[i] = int.Parse(inputArr[i]);
        }

        StringBuilder result = ConvertDecToBin(decs);

        var onesCount = result.ToString().Count(c => c == '1');
        StringBuilder outcome = GetOriginalText(result, codesStr, onesCount);

        Console.WriteLine(outcome);
    }

    private static StringBuilder GetOriginalText(StringBuilder result, StringBuilder codesStr, int onesCount)
    {
        StringBuilder originalText = new StringBuilder();
        StringBuilder fin = new StringBuilder();
        int ones = 0;
        int count = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '1')
            {
                ones++;
                count++;

                if (count == onesCount)
                {
                    int index = codesStr.ToString().IndexOf(ones.ToString());
                    fin.Append(codesStr[index - 1]);
                    break;
                }
            }
            else if (count < onesCount)
            {
                int index = codesStr.ToString().IndexOf(ones.ToString());
                fin.Append(codesStr[index - 1]);

                ones = 0;
            }
            else if (count == onesCount)
            {
                int index = codesStr.ToString().IndexOf(ones.ToString());
                fin.Append(codesStr[index - 1]);
                break;
            }
        }

        return fin;
    }

    private static StringBuilder ConvertDecToBin(int[] decs)
    {
        StringBuilder bin = new StringBuilder();
        StringBuilder result = new StringBuilder();
        int remainder = 0;
        int count = 0;

        for (int i = 0; i < decs.Length; i++)
        {
            while (decs[i] > 0)
            {
                remainder = decs[i] % 2;
                decs[i] = decs[i] / 2;
                bin.Append(remainder);
                count++;
            }

            if (count < 8)
            {
                string binPadded = bin.ToString().PadRight(8, '0');
                for (int j = binPadded.Length - 1; j >= 0; j--)
                {
                    result.Append(binPadded[j]);
                }
            }
            else
            {
                for (int j = bin.Length - 1; j >= 0; j--)
                {
                    result.Append(bin[j]);
                }
            }

            bin.Clear();
            count = 0;
        }

        return result;
    }
}



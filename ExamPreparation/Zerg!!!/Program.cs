using System;

class Zerg
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] codes = { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };
        int index;
        string result = " ";
        string temp = input;
        string coeff = " ";

        for (int i = 0; i < codes.Length; i++)
        {
            index = input.IndexOf(codes[i]);

            if (index >= 0)
            {
                if (i == 10)
                {
                    coeff = "A";
                    result = temp.Replace(codes[i], coeff);
                }

                if (i == 11)
                {
                    coeff = "B";
                    result = temp.Replace(codes[i], coeff);
                }

                if (i == 12)
                {
                    coeff = "C";
                    result = temp.Replace(codes[i], coeff);
                }

                if (i == 13)
                {
                    coeff = "D";
                    result = temp.Replace(codes[i], coeff);
                }

                if (i == 14)
                {
                    coeff = "E";
                    result = temp.Replace(codes[i], coeff);
                }
                else if (i < 10)
                {
                    result = temp.Replace(codes[i], i.ToString());
                }

                temp = result;
            }
        }

        int[] nums = new int[result.Length];

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == 'A')
            {
                nums[i] = 10;
            }

            else if (result[i] == 'B')
            {
                nums[i] = 11;
            }
            else if (result[i] == 'C')
            {
                nums[i] = 12;
            }
            else if (result[i] == 'D')
            {
                nums[i] = 13;
            }
            else if (result[i] == 'E')
            {
                nums[i] = 14;
            }
            else
            {
                nums[i] = result[i] - 48;
            }
        }

        double dec = 0;
        for (int i = 0; i < result.Length; i++)
        {
            dec = dec + nums[result.Length - 1 - i] * Math.Pow(15, i);
        }

        Console.WriteLine(dec);
    }
}


using System;

class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] codes = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
        int index;
        string result = input;
        string temp = string.Empty;
 
        for (int i = 0; i < codes.Length; i++)
        {
            index = input.IndexOf(codes[i]);
            if (index >= 0)
            {
                temp = i.ToString();
                if (i == 10)
                {
                    temp = "A";
                }

                if (i == 11)
                {
                    temp = "B";
                }

                if (i == 12)
                {
                    temp = "C";
                }
                result = result.Replace(codes[i], temp.ToString());
            }
        }

        double dec = 0;
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
            else if (nums[i] < 10)
            {
                nums[i] = result[i] - 48;
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            dec = dec + nums[result.Length - 1 - i] * Math.Pow(13, i);
        }

        Console.WriteLine(dec);
    }
}


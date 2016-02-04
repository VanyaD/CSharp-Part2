using System;
using System.Text;
using System.Linq;

class MovingLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        string longestElement = words.OrderByDescending(s => s.Length).First();
        int max = longestElement.Length;

        string temp = string.Empty;
        StringBuilder output = new StringBuilder();

        for (int j = 0; j < max; j++)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (j > words[i].Length - 1)
                {
                    continue;
                }
                temp = words[i];
                output = output.Append(temp[temp.Length - 1 - j]);
            }
        }

        int k = 0;
        for (int i = 0; i < output.Length; i++)
        {
            if (output[i] < 91)
            {
                k = output[i] - 64;
            }
            else
            {
                k = output[i] - 96;
            }

            if (k > output.Length)
            {
                k = k % output.Length;
            }

            if (k > output.Length - 1 - i)
            {
                int newPosition = k - (output.Length - i);
                output.Insert(newPosition, output[i]);

                if (newPosition < i)
                {
                    output.Remove(i + 1, 1);
                }
                else
                {
                    output.Remove(i, 1);
                }
            }
            else
            {
                int newPosition = i + k + 1;
                output.Insert(newPosition, output[i]);

                if (newPosition < i)
                {
                    output.Remove(i + 1, 1);
                }
                else
                {
                    output.Remove(i, 1);
                }
            }
        }

        Console.WriteLine(output);
    }
}


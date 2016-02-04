using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicWords
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        string longestEl = words.OrderByDescending(s => s.Length).First();
        int max = longestEl.Length;

        for (int i = 0; i < n; i++)
        {
            int position = words[i].Length % (n + 1);

            if (position > i)
            {
                words.Insert(position, words[i]);
                words.RemoveAt(i);
            }

            if (position < i)
            {
                words.Insert(position, words[i]);
                int newInd = i + 1;
                words.RemoveAt(newInd);
            }
        }

        var output = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < words[j].Length)
                {
                    output.Append(words[j].Substring(i, 1));
                }

                if (i > words[j].Length)
                {
                    continue;
                }
            }
        }

        Console.WriteLine(output);
    }
}


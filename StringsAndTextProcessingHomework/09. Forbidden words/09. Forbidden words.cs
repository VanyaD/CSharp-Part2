using System;

class ForbiddenWords
{
    static void Main()
    {
       /* •	We are given a string containing a list of forbidden words and a text containing some of 
        * these words.
          •	Write a program that replaces the forbidden words with asterisks.*/

        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords =  "PHP, CLR, Microsoft";
        string[] forbiddenWordsArr = forbiddenWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string result = text;

        foreach (string str in forbiddenWordsArr)
        {
            string strNew = new string('*', str.Length);
            if (text.Contains(str))
            {
                result = result.Replace(str, strNew);
            }
        }

        Console.WriteLine(result);
        Console.WriteLine();
    }
}


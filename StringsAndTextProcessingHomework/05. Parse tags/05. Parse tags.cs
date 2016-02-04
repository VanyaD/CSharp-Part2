using System;

class ParseTags
{
    static void Main()
    {
        //•	You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and</upcase> to upper-case.
        //•	The tags cannot be nested.

        string text = "We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";
        string startOfUpcase = "<upcase>";
        string endOfUpcase = "</upcase";

        int matchEnd;
        int countOfSubText;
        string toBeReplaced = string.Empty;
        string res = text;
        string substring = string.Empty;

        int matchBegin = res.IndexOf(startOfUpcase, 0);
        while (matchBegin >= 0)
        {
            matchBegin = res.IndexOf(startOfUpcase);
            matchEnd = res.IndexOf(endOfUpcase);
            countOfSubText = matchEnd - matchBegin + 9;
            toBeReplaced = res.Substring(matchBegin, countOfSubText);
            substring = res.Substring(matchBegin + 9, countOfSubText - 19).ToUpper();
            res = res.Replace(toBeReplaced, substring);
            matchBegin = res.IndexOf(startOfUpcase);
        }

        Console.WriteLine(res);
    }
}


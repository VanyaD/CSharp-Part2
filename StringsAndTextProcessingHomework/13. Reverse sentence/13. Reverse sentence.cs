using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        //•	Write a program that reverses the words in given sentence.

        string text = "C# is not C++, not PHP and not Delphi!";
        string result = ReverseWordsInSentence(text);
        Console.WriteLine("Original text: {0}", text);
        Console.WriteLine("Reversed words: {0}", result);
    }

    private static string ReverseWordsInSentence(string text)
    {
        StringBuilder result = new StringBuilder();
        string[] textArr = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < textArr.Length; i++)
        {
            result.Append(textArr[textArr.Length - 1 - i]);
            result.Append(" ");
        }

        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] == ',') ||
            (text[i] == '.') ||
            (text[i] == '!') ||
            (text[i] == '?'))
            {
                result.Insert(i, text[i]);
            }
        }

        return result.ToString();
    }
}


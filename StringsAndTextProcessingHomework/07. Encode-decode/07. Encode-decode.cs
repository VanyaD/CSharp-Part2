using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        /*•	Write a program that encodes and decodes a string using given encryption key (cipher).
          •	The key consists of a sequence of characters.
          •	The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
         * letter of the string with the first of the key, the second – with the second, etc. When 
         * the last key character is reached, the next is the first.*/

        Console.WriteLine("Please enter some text: ");
        string text = Console.ReadLine();

        Console.WriteLine("Please enter a key: ");
        string cipher = Console.ReadLine();

        string encoded = Encode_Decode(text, cipher);
        string decoded = Encode_Decode(encoded, cipher);

        Console.WriteLine(encoded + Environment.NewLine + decoded);
    }

    private static string Encode_Decode(string text, string cypher)
    {
        StringBuilder encoded = new StringBuilder();
        int inputLetter = 0;
        int cipherLetter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            inputLetter = (int)text[i];
            cipherLetter = (int)cypher[i % cypher.Length];
            encoded.Append((char)(inputLetter ^ cipherLetter));
        }

        return encoded.ToString();
    }
}

using System;
using System.IO;
using System.Linq;

class OddLines
{
    static void Main()
    {
        //•	Write a program that reads a text file and prints on the console its odd lines.

        //StreamReader reader = new StreamReader("..\\..\\SampleInput.txt");
        string[] allLines = System.IO.File.ReadAllLines("..\\..\\SampleInput.txt"); 
         string[] oddLines = allLines.Where((line, index) => (index + 1) % 2 != 0).ToArray<string>(); 
         Console.WriteLine(string.Join("\n", oddLines)); 

        //Console.SetIn(reader);


    }
}


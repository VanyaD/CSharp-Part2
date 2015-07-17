using System;

// Problem 5. Sort by string length
// • You are given an array of strings. Write a method that sorts the array 
// by the length of its elements (the number of characters composing them).


    class SortByStringLength
    {
        static void Main()
        {
            Console.WriteLine("Please enter the elements of the string, separated by comma: ");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(inputArr, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine(string.Join(", ", inputArr));
        }
    }

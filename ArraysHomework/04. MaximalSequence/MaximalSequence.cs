﻿using System;

// Problem 4. Maximal sequence
// • Write a program that finds the maximal sequence of equal elements in an array.

public class MaximalSequence
{
    public static void Main()
    {
        Console.WriteLine("Please enter the elements of the array, separated by space: ");
        string input = Console.ReadLine();
        string[] inputArr = input.Split(' ');

        int[] nums = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            nums[i] = int.Parse(inputArr[i]);
        }

        int count = 1;
        int number = nums[0];
        int countFinal = 0;
        int numberFinal = 0;

        for (int i = 0; i < inputArr.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                count++;
            }

            if (nums[i] != nums[i + 1])
            {
                count = 1;
                number = nums[i + 1];
            }

            if (count > countFinal)
            {
                countFinal = count;
                numberFinal = number;
            }
        }

        for (int i = 0; i < countFinal; i++)
        {
            Console.Write("{0} ", numberFinal);
        }

        Console.WriteLine();
    }
}
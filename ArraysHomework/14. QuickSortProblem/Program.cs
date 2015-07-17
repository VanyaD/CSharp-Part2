﻿namespace QuickSort
 {
     using System;

     // Write a program that sorts an array of integers using the Quick sort algorithm. 
     class QuickSortByInt
     {
         static void Main()
         {
             Console.Write("Please enter the number of elements in the array = ");
             int n = int.Parse(Console.ReadLine());
             int[] array = new int[n];
             Console.WriteLine("Please enter the elements:");

             for (int i = 0; i < array.Length; i++)
             {
                 Console.Write("element[{0}] = ", i);
                 array[i] = int.Parse(Console.ReadLine());
             }

             QuickSort(array, 0, array.Length - 1);

             for (int i = 0; i < array.Length; i++)
             {
                 if (i < array.Length - 1)
                 {
                     Console.Write(array[i] + " ");
                 }
                 else
                 {
                     Console.WriteLine(array[i] + " ");
                 }
             }
         }

         static void QuickSort(int[] elements, int left, int right)
         {
             if (left < right)
             {
                 int pivot = Partition(elements, left, right);
                 if (pivot > 1)
                 {
                     QuickSort(elements, left, pivot - 1);
                 }

                 if (pivot + 1 < right)
                 {
                     QuickSort(elements, pivot + 1, right);
                 }
             }
         }

         static public int Partition(int[] array, int left, int right)
         {
             int pivot = array[left];
             while (true)
             {
                 while (array[left] < pivot)
                 {
                     left++;
                 }

                 while (array[right] > pivot)
                 {
                     right--;
                 }

                 if (left < right)
                 {
                     int temp = array[right];
                     array[right] = array[left];
                     array[left] = temp;
                 }
                 else
                 {
                     return right;
                 }
             }
         }
     }
 }

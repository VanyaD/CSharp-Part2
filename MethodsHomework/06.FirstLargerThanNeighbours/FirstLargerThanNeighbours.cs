using System;

// Problem 6. First larger than neighbours
// • Write a method that returns the index of the first element in array that 
// is larger than its neighbours, or  -1 , if there’s no such element.
// • Use the method from the previous exercise.


class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] nums = { 5, 7, 21, 13, 8, 99, 105, 2 };
        //int[] nums = { -5, 16, -21, -13, 0, 99, 105, 2 };
        //int[] nums = { 1000, 7, 15, 13, 5000, 99, 105, 2 };

        FindFirstLargerThanNeighbours(nums);
    }

    static void FindFirstLargerThanNeighbours(int[] numsArr)
    {
        for (int i = 1; i < numsArr.Length - 1; i++)
        {
            if ((numsArr[i] > numsArr[i - 1]) && (numsArr[i] > numsArr[i + 1]))
            {
                Console.WriteLine("The first element that is larger than its neighbours is at position {0}.", i);
                return;
            }
            else
            {
                if (i == numsArr.Length - 1)
                {
                    Console.WriteLine("There is no such element.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheRabbit
{
    class Main
    {
        static int[] nums;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            nums = new int[inputArr.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(inputArr[i]);
            }

            int numberOfSteps = 0;
            int maxNumberOfSteps = 0;
            int numberOfPossibleSteps = nums.Length;
            int numberOfPossibleEntries = nums.Length;

            for (int step = 1; step <= numberOfPossibleSteps; step++)
            {
                for (int entry = 0; entry < numberOfPossibleEntries; entry++)
                {
                    numberOfSteps = GetNumberOfSteps(entry, step);

                    if (numberOfSteps > maxNumberOfSteps)
                    {
                        maxNumberOfSteps = numberOfSteps;
                    }
                }
            }

            Console.WriteLine(maxNumberOfSteps);
        }

        private static int GetNumberOfSteps(int entry, int step)
        {
            int numberOfSteps = 1;
            int currentPosition = entry;

            for (int i = 0; i < nums.Length; i++)
            {
                int nextPosition = currentPosition + step;

                if (nextPosition >= nums.Length)
                {
                    nextPosition = step - nums.Length + currentPosition;
                }

                if (nums[nextPosition] > nums[currentPosition])
                {
                    numberOfSteps++;
                    currentPosition = nextPosition;
                }
                else
                {
                    break;
                }
            }

            return numberOfSteps;
        }
    }
}


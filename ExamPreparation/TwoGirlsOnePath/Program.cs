using System;
using System.Numerics;

class TwoGirlsOnePath
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] inputArr = input.Split(' ');
        long[] nums = new long[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            nums[i] = long.Parse(inputArr[i]);
        }

        BigInteger flowersM = nums[0];
        long positionM = 0;
        long oldPositionM = 0;
        long offsetM = nums[0];
        nums[0] = 0;

        BigInteger flowersD = nums[nums.Length - 1];
        long positionD = nums.Length - 1;
        long oldPositionD = nums.Length - 1;
        long offsetD = nums[positionD];
        nums[nums.Length - 1] = 0;

        while (offsetM != 0 && offsetD != 0)
        {
            if (offsetM > nums.Length)          
            {
                offsetM = offsetM % nums.Length;
                oldPositionM = positionM;
                positionM = positionM + offsetM; 
            }
            else
            {
                oldPositionM = positionM;
                positionM = positionM + offsetM;
            }

            if (positionM >= nums.Length)        
            {
                positionM = 0 + (offsetM - (nums.Length - oldPositionM));
                offsetM = nums[positionM];
                oldPositionM = positionM;
            }
            else
            {
                offsetM = nums[positionM];
                oldPositionM = positionM;
            }

            // Dolly

            if (offsetD > nums.Length)
            {
                offsetD = offsetD % nums.Length;
            }

            oldPositionD = positionD;
            positionD = positionD - offsetD;

            if (positionD < 0)
            {
                positionD = nums.Length - (offsetD - oldPositionD);
                offsetD = nums[positionD];
                oldPositionD = positionD;
            }
            else
            {
                offsetD = nums[positionD];
                oldPositionD = positionD;
            }

            if (positionD == positionM)
            {
                flowersM = flowersM + (offsetM / 2);
                flowersD = flowersD + (offsetD / 2);
                nums[oldPositionM] = (int)offsetM % 2;
            }
            else
            {
                flowersM = flowersM + offsetM;
                nums[oldPositionM] = 0;
                flowersD = flowersD + offsetD;
                nums[oldPositionD] = 0;
            }
        }

        if (offsetM == 0 && offsetD == 0)
        {
            Console.WriteLine("Draw");
            Console.WriteLine("{0} {1}", flowersM, flowersD);
            return;
        }

        if (offsetM == 0 && offsetD != 0)
        {
            Console.WriteLine("Dolly");
            Console.WriteLine("{0} {1}", flowersM, flowersD);
            return;
        }

        if (offsetM != 0 && offsetD == 0)
        {
            Console.WriteLine("Molly");
            Console.WriteLine("{0} {1}", flowersM, flowersD);
            return;
        }
    }
}


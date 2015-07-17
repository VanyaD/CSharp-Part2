using System;

class RandomNumbers
{
    static void Main()
    {
        //•	Write a program that generates and prints to the console 10 random values in the range [100, 200].

        Random rnd = new Random();
        int randomNum;

        for (int i = 0; i < 10; i++)
        {
            randomNum = rnd.Next(100, 200);
            Console.WriteLine(randomNum);
        }
    }
}


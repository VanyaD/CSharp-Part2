using System;

class LeapYear
{
    static void Main()
    {
        //•	Write a program that reads a year from the console and checks whether it is a leap one.
        //•	Use System.DateTime.

        Console.WriteLine("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);

        Console.WriteLine("Year {0} is leap --> {1}", year, isLeap);
    }
}


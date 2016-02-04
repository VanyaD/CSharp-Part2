using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        //•	Write a program that reads two dates in the format:
        //  day.month.year and calculates the number of days between them.

        Console.WriteLine("Please enter the first date (day.month.year): ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo);

        Console.WriteLine("Please enter the second date (day.month.year): ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo);

        double diff = (secondDate - firstDate).TotalDays;
        Console.WriteLine("{0}", diff);
    }
}


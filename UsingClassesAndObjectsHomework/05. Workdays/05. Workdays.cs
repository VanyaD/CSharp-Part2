using System;

class Workdays
{
    static void Main()
    {
        /*•	Write a method that calculates the number of workdays between today and given date, 
         * passed as parameter.
          •	Consider that workdays are all days from Monday to Friday except a fixed list of public 
         * holidays specified preliminary as array.*/

        Console.WriteLine("Please enter your end date in the format yyyy/mm/dd: ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        DateTime[] bankHolidays = { new DateTime(2015, 03, 01), new DateTime(2015, 05, 24) };

        DateTime day = new DateTime();
        int numberOfDays = 0;

        for (day = DateTime.Now.Date; day.Date < endDate.Date; day = day.Date.AddDays(1))
        {
            string dayOfWeek = Convert.ToString(day.DayOfWeek);
            if (dayOfWeek != "Saturday" && dayOfWeek != "Sunday")
            {
                numberOfDays++;
            }
            for (int i = 0; i < bankHolidays.Length; i++)
            {
                if (day == bankHolidays[i])
                {
                    numberOfDays--;
                }
            }
        }
        Console.WriteLine("Business days = {0}", numberOfDays);
    }
}


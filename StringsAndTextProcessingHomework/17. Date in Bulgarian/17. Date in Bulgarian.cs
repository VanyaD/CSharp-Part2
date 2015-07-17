using System;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        /*•	Write a program that reads a date and time given in the format:
         * day.month.year hour:minute:second and prints the date and time 
         * after 6 hours and 30 minutes (in the same format) along with the 
         * day of week in Bulgarian.*/

        Console.WriteLine("Please enter a date in the following format: day.month.year hour:minute:second: ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "day.month.year hour:minute:second", DateTimeFormatInfo.CurrentInfo);

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        string format = "d.M.yyyy H:m:s";
        CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");
         
        DateTime date = DateTime.ParseExact(Console.ReadLine(), format, provider);
        date = date.AddMinutes(390);
        Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), provider);
    }
}

using System;

namespace Structs.DateTimeExample
{
    internal class IndexDateTimeExample
    {
        public IndexDateTimeExample()
        {
            IndexDateTimeMethod();
        }

        public void IndexDateTimeMethod()
        {
            DateTime dateTime = new DateTime(2018, 1, 1); // Correct initialization

            Console.WriteLine("Hello World!");

            Console.WriteLine($"The date is: {dateTime.ToShortDateString()}"); // Print the date

            // Write today on screen
            Console.WriteLine(DateTime.Today);
            // Write current time on the screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();

            // Display the date for tomorrow
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);

            //Display weekday
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            //Display first day of a year
            Console.WriteLine(GetFirstDayOfYear(1999));

            // Days in months
            int days = DateTime.DaysInMonth(2024, 11);
            Console.WriteLine("Days in November 2024: {0}", days);

            // Display the current minute of the hour
            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            // display the time in this structure x o'clock y minutes and z seconds 
            Console.WriteLine("Line:1 | {0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            //Counts the days passed since the given date
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong Inout!");
            }

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}

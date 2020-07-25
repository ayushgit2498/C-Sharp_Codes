using System;

namespace AdvancedCSharpConcepts
{
    class DateTimePractice
    {        
        public void DateTimeFunctions()
        {
            DateTime dateTime = new DateTime(1998, 4, 2);
            Console.WriteLine("My Birthdate is {0}", dateTime);

            // Display today's date
            Console.WriteLine(DateTime.Today);
            // Display local time
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow is {0}", tomorrow);
            Console.WriteLine(DateTime.Today.DayOfWeek);

            DateTime d = DateTime.Now;
            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", d.Hour, d.Minute, d.Second);

            Console.WriteLine("Enter your birthdate in format yyyy-mm-dd");
            DateTime d1;
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out d1))
            {
                Console.WriteLine(d1);
                TimeSpan t = DateTime.Now.Subtract(d1);
                Console.WriteLine("You are {0} days old", t.Days);
            }else
            {
                Console.WriteLine("Wrong input");
            }

        }

        public DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}

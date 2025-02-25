using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            DateTime dateTime = new DateTime(2007, 10, 26);
            Console.WriteLine("          DateTime : " + dateTime);
            dateTime = dateTime.AddYears(1);
            dateTime = dateTime.AddMonths(5);
            dateTime = dateTime.AddDays(3);
            dateTime = dateTime.AddMinutes(30);
            dateTime = dateTime.AddSeconds(15);
            Console.WriteLine("      Add DateTime : {0}", dateTime);

            TimeSpan timeSpan = new TimeSpan(7, 0, 0, 0);
            Console.WriteLine("            1 Week : {0}", timeSpan);
            dateTime -= timeSpan;
            Console.WriteLine("       Before Week : {0}\n", dateTime);

            dateTime = DateTime.Now;
            Console.WriteLine("          DateTime : {0}", dateTime);
            Console.WriteLine("     DateTime.Date : {0}", dateTime.Date);
            Console.WriteLine("      DateTime.Day : {0}", dateTime.Day);
            Console.WriteLine("DateTime.DayOfWeek : {0}", dateTime.DayOfWeek);
            Console.WriteLine("DateTime.DayOfYear : {0}", dateTime.DayOfYear);
            Console.WriteLine("    DateTime.Ticks : {0}", dateTime.Ticks);
            Console.WriteLine("DateTime.TimeOfDay : {0}\n", dateTime.TimeOfDay);

            Console.Write("Press a key to exit...");
            Console.ReadKey(true);
        }
    }
}

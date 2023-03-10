using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_EnterInput
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            DateTime dt = new DateTime(2007, 10, 26);
            Console.WriteLine("          dt : " + dt);
            dt = dt.AddYears(1);
            dt = dt.AddMonths(5);
            dt = dt.AddDays(3);
            dt = dt.AddMinutes(30);
            dt = dt.AddSeconds(15);
            Console.WriteLine("      Add dt : {0}", dt);
            TimeSpan hafta = new TimeSpan(7, 0, 0, 0);
            Console.WriteLine("      1 Week : {0}", hafta);
            dt = dt - hafta;
            Console.WriteLine(" Before Week : {0}\n", dt);

            dt = DateTime.Now;
            Console.WriteLine("          dt : {0}", dt);
            Console.WriteLine("     dt.Date : {0}", dt.Date);
            Console.WriteLine("      dt.Day : {0}", dt.Day);
            Console.WriteLine("dt.DayOfWeek : {0}", dt.DayOfWeek);
            Console.WriteLine("dt.DayOfYear : {0}", dt.DayOfYear);
            Console.WriteLine("    dt.Ticks : {0}", dt.Ticks);
            Console.WriteLine("dt.TimeOfDay : {0}\n", dt.TimeOfDay);

            Console.Write("Press a key to exit...");
            Console.ReadKey(true);
        }
    }
}

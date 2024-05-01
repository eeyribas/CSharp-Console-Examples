using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Use
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            DateTime dateTime = new DateTime(2012, 6, 23, 16, 5, 7, 999);
            string str = String.Format("{0:yy yyyy}", dateTime);

            Console.WriteLine(str);
            str = String.Format("{0:MM MMMM}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:dd dddd}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:hh HH}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:m mm}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:s ss}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:fff}", dateTime);
            Console.WriteLine(str + "\n");

            str = String.Format("{0:t}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:d}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:T}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:D}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:f}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:F}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:g}", dateTime);
            Console.WriteLine(str);
            str = String.Format("{0:G}", dateTime);
            Console.WriteLine(str + "\n");

            Console.Write("Press a key to exit...");
            Console.ReadKey(true);
        }
    }
}

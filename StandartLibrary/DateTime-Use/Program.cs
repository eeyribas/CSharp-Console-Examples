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

            DateTime dt = new DateTime(2012, 6, 23, 16, 5, 7, 999);
            string str = String.Format("{0:yy yyyy}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:MM MMMM}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:dd dddd}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:hh HH}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:m mm}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:s ss}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:fff}", dt);
            Console.WriteLine(str + "\n");

            str = String.Format("{0:t}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:d}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:T}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:D}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:f}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:F}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:g}", dt);
            Console.WriteLine(str);
            str = String.Format("{0:G}", dt);
            Console.WriteLine(str + "\n");

            Console.Write("Press a key to exit...");
            Console.ReadKey(true);
        }
    }
}

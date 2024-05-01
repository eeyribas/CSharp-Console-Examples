using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace While_DateTime
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            DateTime ti = DateTime.Now;
            DateTime tf = ti.AddSeconds(20);
            while (true) 
            {
                Console.WriteLine("{0} ---> {1}", ti.TimeOfDay, ti.ToFileTime());
                Thread.Sleep(1000);
                ti = DateTime.Now;
                if (ti >= tf) break;
            }

            Console.Write("Press a key to exit...");
            Console.ReadKey(true);
        }
    }
}

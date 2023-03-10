using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch_Use
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            int N = 5;
            Stopwatch sw = new Stopwatch();
            for (int n = 0; n < N; n++) {
                sw.Start();
                Thread.Sleep(1000);
                sw.Stop();
                Console.WriteLine("Duration: {0} ms ---> {1}", sw.ElapsedMilliseconds, sw.ElapsedTicks);
                sw.Reset();
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

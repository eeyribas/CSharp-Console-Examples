using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopwatchExp
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Stopwatch stopwatch = new Stopwatch();
            int N = 5;
            for (int n = 0; n < N; n++) 
            {
                stopwatch.Start();
                Thread.Sleep(1000);
                stopwatch.Stop();
                Console.WriteLine("Duration: {0} ms ---> {1}", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
                stopwatch.Reset();
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

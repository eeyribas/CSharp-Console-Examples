using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgrndColor_ForegrndColor
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            int i = 0, j = 8;
            while (true)
            {
                if (Console.KeyAvailable)
                    break;

                Console.BackgroundColor = (ConsoleColor)i;
                Console.ForegroundColor = (ConsoleColor)j;
                Console.Clear();
                Console.WriteLine("Background = {0}\t{1}", i, (ConsoleColor)i);
                Console.WriteLine("Foreground = {0}\t{1}", j, (ConsoleColor)j);
                Thread.Sleep(1000);

                i++;
                j++;
                i %= 16;
                j %= 16;
            }
        }
    }
}

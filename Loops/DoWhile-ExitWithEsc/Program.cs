using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoWhile_ExitWithEsc
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";
            Console.WriteLine("Exit the program with Esc");

            ConsoleKeyInfo key;
            do 
            {
                key = Console.ReadKey(true);
                Console.WriteLine("{0}.{1}.{2}.{3}", key.KeyChar, (int)key.KeyChar, key.Key, 
                                  key.Modifiers);
            } while (key.KeyChar != 27);
            Thread.Sleep(1000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_EscExitsAndEnterTakes
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Esc exits, Enter takes.");
            Console.WriteLine("----------------------");

            while (true) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string str = null;

                while (true) 
                {
                    char ch = Console.ReadKey().KeyChar;
                    if (ch == 27) 
                        return;
                    if (ch == 13) 
                        break;
                    str += ch;
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" ---> " + str);
                Console.Beep(1500, 250); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_ConsoleScreenDesign
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            char c = '*';
            ConsoleKeyInfo tus;
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            while (true) {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
                int xe = x;
                int ye = y;
                tus = Console.ReadKey(true);
                if (tus.Key == ConsoleKey.Escape) 
                    break;
                else if (tus.Key == ConsoleKey.LeftArrow) 
                    x--;
                else if (tus.Key == ConsoleKey.RightArrow) 
                    x++;
                else if (tus.Key == ConsoleKey.UpArrow) 
                    y--;
                else if (tus.Key == ConsoleKey.DownArrow) 
                    y++;
                else 
                    c = tus.KeyChar;

                if (x < 0) 
                    x = Console.WindowWidth - 1;
                else if (x > Console.WindowWidth - 1) 
                    x = 0;

                if (y < 0) 
                    y = Console.WindowHeight - 1;
                else if (y > Console.WindowHeight - 1) 
                    y = 0;
                Console.SetCursorPosition(xe, ye);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(c);
            }
        }
    }
}

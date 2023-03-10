using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cursor_Color_Lock_Buffer_Window
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.CursorSize = 100;
            int x = 60, y = 30, t = 5000;
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
            Console.SetCursorPosition(0, y - 1);
            Thread.Sleep(t);
            Console.WriteLine("      Console.Title = {0}\n", Console.Title);
            Thread.Sleep(t);
            Console.WriteLine("         CursorSize = {0}", Console.CursorSize);
            Console.WriteLine("         CursorLeft = {0}", Console.CursorLeft);
            Console.WriteLine("          CursorTop = {0}", Console.CursorTop);
            Console.WriteLine("      CursorVisible = {0}\n", Console.CursorVisible);
            Thread.Sleep(t);
            Console.WriteLine("    BackgroundColor = {0}", Console.BackgroundColor);
            Console.WriteLine("    ForegroundColor = {0}\n", Console.ForegroundColor);
            Thread.Sleep(t);
            Console.WriteLine("           CapsLock = {0}", Console.CapsLock);
            Console.WriteLine("         NumberLock = {0}\n", Console.NumberLock);
            Thread.Sleep(t);
            Console.WriteLine("        BufferWidth = {0}", Console.BufferWidth);
            Console.WriteLine("       BufferHeight = {0}\n", Console.BufferHeight);
            Thread.Sleep(t);
            Console.WriteLine("         WindowLeft = {0}", Console.WindowLeft);
            Console.WriteLine("          WindowTop = {0}", Console.WindowTop);
            Console.WriteLine("        WindowWidth = {0}", Console.WindowWidth);
            Console.WriteLine("       WindowHeight = {0}\n", Console.WindowHeight);
            Thread.Sleep(t);
            Console.WriteLine(" LargestWindowWidth = {0}", Console.LargestWindowWidth);
            Console.WriteLine("LargestWindowHeight = {0}\n", Console.LargestWindowHeight);
            Thread.Sleep(100);
            Console.WriteLine("       KeyAvailable = {0}\n", Console.KeyAvailable);
            Thread.Sleep(t);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

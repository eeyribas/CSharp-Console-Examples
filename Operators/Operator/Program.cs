using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            int x = 150, y;
            Console.WriteLine("int x = 150       --->  x = {0}", x);
            y = x++;
            Console.WriteLine("int y = x++       --->  x = {0} , y = {1}", x, y);
            y = x--;
            Console.WriteLine("y = x--           --->  x = {0} , y = {1}", x, y);
            y = ++x;
            Console.WriteLine("y = ++x           --->  x = {0} , y = {1}", x, y);
            y = --x;
            Console.WriteLine("y = --x           --->  x = {0} , y = {1}\n", x, y);
            x = int.MinValue;
            Console.WriteLine("x = int.MinValue  --->  x = {0,11}", x);
            Console.WriteLine("--x               --->  x = {0,11}", --x);
            Console.WriteLine("++x               --->  x = {0,11}\n", ++x);
            x = int.MaxValue;
            Console.WriteLine("x = int.MaxValue  --->  x = {0,11}", x);
            Console.WriteLine("++x               --->  x = {0,11}", ++x);
            Console.WriteLine("--x               --->  x = {0,11}\n", --x);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

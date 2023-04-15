using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteDoubleFloatDecimal
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            int x = 17, y = 3;
            Console.WriteLine(x / y);
            Console.WriteLine((float)x / y);
            Console.WriteLine((double)x / y);
            Console.WriteLine((decimal)x / y);
            Console.WriteLine();

            double z = (double)x / y;
            Console.WriteLine("z = {0}", z);
            Console.WriteLine("z = {0:F9}", z);
            Console.WriteLine("z = {0:F20}", z);
            double zReel = z - (int)z;
            Console.WriteLine("z - (int)z = {0}", zReel);

            double value = 7243.555555555555E-25;
            Console.WriteLine("\n" + value + "\n");

            Console.WriteLine(" float.Epsilon      --->  {0}", float.Epsilon);
            Console.WriteLine(" float.Epsilon + 3  --->  {0}", float.Epsilon + 3);
            Console.WriteLine("double.Epsilon      --->  {0}", double.Epsilon);
            Console.WriteLine("double.Epsilon + 3  --->  {0}", double.Epsilon + 3);
            Console.WriteLine();

            Console.WriteLine(17f / 3);
            Console.WriteLine(17.0 / 3);
            Console.WriteLine(17d / 3);
            Console.WriteLine(17m / 3);
            Console.WriteLine();

            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

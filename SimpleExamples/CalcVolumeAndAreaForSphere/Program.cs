using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcVolumeAndAreaForSphere
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.WriteLine("Calculating Volume And Area for Sphere");
            Console.WriteLine("Pi Number = {0}", Math.PI);
            Console.Write("\nr : ");

            double r = Convert.ToDouble(Console.ReadLine());
            double area = 4 * Math.PI * r * r;
            double volume = area * r / 3;
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Volume = {0}\n", volume);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

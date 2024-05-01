using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaOfTheCircle
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.WriteLine("Calculating Circle");
            Console.WriteLine("Pi Number = {0}", Math.PI);
            Console.Write("\nr : ");

            double r = Convert.ToDouble(Console.ReadLine());
            double env = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Environment = {0}", env);
            Console.WriteLine("Area   = {0}\n", area);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

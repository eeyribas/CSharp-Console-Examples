using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteLine
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.WriteLine("C# Programming");
            Console.WriteLine("C# Programming");
            Console.WriteLine("C# Programming\n");

            string str = "C# Programming";
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str + "\n");

            Console.WriteLine("{0}\n{0}\n{0}\n", str);

            for (int n = 0; n < 5; n++) 
                Console.WriteLine(str);
            Console.WriteLine();

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

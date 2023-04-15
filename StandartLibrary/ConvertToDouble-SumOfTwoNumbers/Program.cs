using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToDouble_SumOfTwoNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";
            Console.WriteLine("Addition of Two Real Numbers\n");
            try {
                Console.Write("\t1.Number > ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("\t2.Number > ");
                double y = Convert.ToDouble(Console.ReadLine());
                double z = x + y;
                Console.WriteLine("\tResult  = {0}\n", z);
            }
            catch {
                Console.WriteLine("\nEnter real number\n");
            }
            finally {
                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}

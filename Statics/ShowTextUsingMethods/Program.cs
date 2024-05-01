using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTextUsingMethods
{
    class Program
    {
        static void Wait()
        {
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }


        static void Write1(string[] array)
        {
            Console.Write("Data --->");
            foreach (string str in array)
                Console.Write(" {0}", str);
            Console.WriteLine("\n");
        }

        static void Write2(string[] array)
        {
            Console.Write("Data --->");
            for (int i = 0; i < array.Length; i++)
                Console.Write(" {0}", array[i]);
            Console.WriteLine("\n");
        }

        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            string[] data = {"Hasan", "Ahmet", "Serdar", "Arif", "Bahadır", "Cemal", "Sedat"};
            Write1(data);
            Write2(data);
            Wait();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCharArrayExp
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            string str = "CSharp Programming Lesson";
            Console.WriteLine("{0}", str);
            Console.WriteLine("String Length = {0}\n", str.Length);

            char[] array = str.ToCharArray();
            int n = array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(array[i]);
            Console.WriteLine("\nArray Length = {0}\n", n);

            array = str.ToCharArray(7, 11);
            n = array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(array[i]);
            Console.WriteLine("\nArray Length = {0}\n", n);

            array = str.ToCharArray();
            string copyStr = new string(array);
            Console.WriteLine("{0}", copyStr);
            Console.WriteLine("String Length = {0}\n", copyStr.Length);

            Console.Write("Press a key to exit...");
            Console.ReadKey();
        }
    }
}

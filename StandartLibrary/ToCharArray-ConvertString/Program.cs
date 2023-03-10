using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToCharArray_ConvertString
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
            int i, n = array.Length;
            for (i = 0; i < n; i++)
                Console.Write(array[i]);
            Console.WriteLine("\nArray Length = {0}\n", n);

            array = str.ToCharArray(7, 11);
            n = array.Length;
            for (i = 0; i < n; i++)
                Console.Write(array[i]);
            Console.WriteLine("\nArray Length = {0}\n", n);

            array = str.ToCharArray();
            string s = new string(array);
            Console.WriteLine("{0}", s);
            Console.WriteLine("String Length = {0}\n", s.Length);

            Console.Write("Press a key to exit...");
            Console.ReadKey();
        }
    }
}

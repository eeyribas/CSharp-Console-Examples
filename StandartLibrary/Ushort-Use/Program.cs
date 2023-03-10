using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushort_Use
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            ushort a = 0xA3D9;
            Console.WriteLine("     a = {0:X4} ---> {0,5}", a);
            ushort f = (ushort)(~a);
            Console.WriteLine("    ~a = {0:X4} ---> {0,5}", f);
            f = (ushort)(a >> 8);
            Console.WriteLine("a >> 8 = {0:X4} ---> {0,5}", f);
            f = (ushort)(a << 8);
            Console.WriteLine("a << 8 = {0:X4} ---> {0,5}\n", f);
            ushort b = 0x2E7A;
            Console.WriteLine("     b = {0:X4} ---> {0,5}", b);
            f = (ushort)(~b);
            Console.WriteLine("    ~b = {0:X4} ---> {0,5}", f);
            f = (ushort)(b >> 8);
            Console.WriteLine("b >> 8 = {0:X4} ---> {0,5}", f);
            f = (ushort)(b << 8);
            Console.WriteLine("b << 8 = {0:X4} ---> {0,5}\n", f);
            Console.WriteLine("     a = {0:X4} ---> {0,5}", a);
            Console.WriteLine("     b = {0:X4} ---> {0,5}", b);
            f = (ushort)(a & b);
            Console.WriteLine(" a & b = {0:X4} ---> {0,5}", f);
            f = (ushort)(a | b);
            Console.WriteLine(" a | b = {0:X4} ---> {0,5}", f);
            f = (ushort)(a ^ b);
            Console.WriteLine(" a ^ b = {0:X4} ---> {0,5}\n", f);
            f = (ushort)(a ^ f);
            Console.WriteLine(" a ^ f = {0:X4} ---> {0,5}\n", f);

            Console.Write("Press a key to exit...");
            Console.ReadKey(true);
        }
    }
}

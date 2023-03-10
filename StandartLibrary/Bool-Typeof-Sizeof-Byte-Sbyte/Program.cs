using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Typeof_Sizeof_Byte_Sbyte
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.WriteLine("   bool.FalseString = {0}", bool.FalseString);
            Console.WriteLine("   bool.TrueString  = {0}", bool.TrueString);
            Console.WriteLine("       sizeof(bool) = {0}", sizeof(bool));
            Console.WriteLine("       typeof(bool) = {0}\n", typeof(bool));

            char ch = (Char)350;
            Console.WriteLine("                 ch = {0} ---> {1}", (int)ch, ch);
            Console.WriteLine("      char.MinValue = {0}", (int)char.MinValue);
            Console.WriteLine("      char.MaxValue = {0}", (int)char.MaxValue);
            Console.WriteLine("       sizeof(char) = {0}", sizeof(char));
            Console.WriteLine("       typeof(char) = {0}\n", typeof(char));

            byte bayt = 200;
            Console.WriteLine("               bayt = {0}", bayt);
            Console.WriteLine("      byte.MinValue = {0}", byte.MinValue);
            Console.WriteLine("      byte.MaxValue = {0}", byte.MaxValue);
            Console.WriteLine("       sizeof(byte) = {0}", sizeof(byte));
            Console.WriteLine("       typeof(byte) = {0}\n", typeof(byte));

            sbyte ibayt = 100;
            Console.WriteLine("              ibayt = {0}", ibayt);
            Console.WriteLine("     sbyte.MinValue = {0}", sbyte.MinValue);
            Console.WriteLine("     sbyte.MaxValue = {0}", sbyte.MaxValue);
            Console.WriteLine("      sizeof(sbyte) = {0}", sizeof(sbyte));
            Console.WriteLine("      typeof(sbyte) = {0}\n", typeof(sbyte));

            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

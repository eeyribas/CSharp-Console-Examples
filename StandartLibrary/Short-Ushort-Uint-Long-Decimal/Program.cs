using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Ushort_Uint_Long_Decimal
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Console.WriteLine("   short.MinValue = {0}", short.MinValue);
            Console.WriteLine("   short.MaxValue = {0}", short.MaxValue);
            Console.WriteLine("    sizeof(short) = {0}", sizeof(short));
            Console.WriteLine("    typeof(short) = {0}\n", typeof(short));

            Console.WriteLine("  ushort.MinValue = {0}", ushort.MinValue);
            Console.WriteLine("  ushort.MaxValue = {0}", ushort.MaxValue);
            Console.WriteLine("   sizeof(ushort) = {0}", sizeof(ushort));
            Console.WriteLine("   typeof(ushort) = {0}\n", typeof(ushort));

            Console.WriteLine("     int.MinValue = {0}", int.MinValue);
            Console.WriteLine("     int.MaxValue = {0}", int.MaxValue);
            Console.WriteLine("      sizeof(int) = {0}", sizeof(int));
            Console.WriteLine("      typeof(int) = {0}\n", typeof(int));

            Console.WriteLine("    uint.MinValue = {0}", uint.MinValue);
            Console.WriteLine("    uint.MaxValue = {0}", uint.MaxValue);
            Console.WriteLine("     sizeof(uint) = {0}", sizeof(uint));
            Console.WriteLine("     typeof(uint) = {0}\n", typeof(uint));

            Console.WriteLine("    long.MinValue = {0}", long.MinValue);
            Console.WriteLine("    long.MaxValue = {0}", long.MaxValue);
            Console.WriteLine("     sizeof(long) = {0}", sizeof(long));
            Console.WriteLine("     typeof(long) = {0}\n", typeof(long));

            Console.WriteLine("   ulong.MinValue = {0}", ulong.MinValue);
            Console.WriteLine("   ulong.MaxValue = {0}", ulong.MaxValue);
            Console.WriteLine("    sizeof(ulong) = {0}", sizeof(ulong));
            Console.WriteLine("    typeof(ulong) = {0}\n", typeof(ulong));

            Console.WriteLine("   float.MinValue = {0}", float.MinValue);
            Console.WriteLine("   float.MaxValue = {0}", float.MaxValue);
            Console.WriteLine("    sizeof(float) = {0}", sizeof(float));
            Console.WriteLine("    typeof(float) = {0}\n", typeof(float));

            Console.WriteLine("  double.MinValue = {0}", double.MinValue);
            Console.WriteLine("  double.MaxValue = {0}", double.MaxValue);
            Console.WriteLine("   sizeof(double) = {0}", sizeof(double));
            Console.WriteLine("   typeof(double) = {0}\n", typeof(double));

            Console.WriteLine(" decimal.MinValue = {0}", decimal.MinValue);
            Console.WriteLine(" decimal.MaxValue = {0}", decimal.MaxValue);
            Console.WriteLine("  sizeof(decimal) = {0}", sizeof(decimal));
            Console.WriteLine("  typeof(decimal) = {0}\n", typeof(decimal));

            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

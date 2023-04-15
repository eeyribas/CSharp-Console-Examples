using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_EnterNumberInArguman
{
    class Program
    {
        static void Main(string[] str)
        {
            double number;

            if (str.Length < 2) {
                Console.WriteLine("Must Have At Least 2 Parameters");
                return;
            }

            for (int i = 0; i < str.Length; i++) {
                if (!double.TryParse(str[i], out number)) {
                    Console.WriteLine("Parameters Must Be Real Numbers");
                    return;
                }
            }

            double sum = 0;
            for (int i = 0; i < str.Length; i++) {
                number = Convert.ToDouble(str[i]);
                Console.WriteLine("{0,3}.Number > {1}", i + 1, number);
                sum += number;
            }
            Console.WriteLine("  Sum > " + sum);
        }
    }
}

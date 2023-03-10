using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_While_DoWhile_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            const int N = 20;
            int n;
            Console.Write("Numbers : ");
            for (n = 1; n <= N; n++){
                if (n == 5 || n == 8 || n == 13)
                    continue;
                else if (n == 16) 
                    break;
                Console.Write("{0} ", n);
            }

            Console.Write("\n\nNumbers : ");
            n = 0;
            while (n < N) {
                n++;
                if (n == 5 || n == 8 || n == 13)
                    continue;
                else if (n == 16) 
                    break;
                Console.Write("{0} ", n);
            }

            Console.Write("\n\nNumbers : ");
            n = 0;
            do {
                n++;
                if (n == 5 || n == 8 || n == 13)
                    continue;
                else if (n == 16) 
                    break;
                Console.Write("{0} ", n);
            } while (n < N);

            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

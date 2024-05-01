using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_TwoDimensionalMatrix
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            Random random = new Random();
            int M = random.Next(10, 21);
            int N = random.Next(5, 10);
            double[,] array = new double[M, N];

            Console.WriteLine("[{0},{1}] dimensional A matrix\n", M, N);
            for (int m = 0; m < M; m++) 
            {
                for (int n = 0; n < N; n++) 
                {
                    array[m, n] = Math.Round(random.NextDouble(), 4);
                    Console.Write("{0,8}", array[m, n]);
                }
                Console.WriteLine();
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

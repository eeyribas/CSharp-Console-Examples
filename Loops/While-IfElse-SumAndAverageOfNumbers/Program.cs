using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_IfElse_SumAndAverageOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            int N; 
            Console.WriteLine("Sum and Average of integers from 1 to N\n");
            while (true) {
                Console.Write("Enter the integer N : ");
                if (int.TryParse(Console.ReadLine(), out N)) {
                    if (N < 1)
                        Console.WriteLine("\nN <= 0\n");
                    else 
                        break;
                }
                else {
                    Console.WriteLine("\nThe number you entered is not an integer.");
                    Console.WriteLine("Please enter an integer...\n");
                }
            }

            double average;
            int sum = 0;
            for (int n = 1; n <= N; n++) 
                sum += n;
            average = (double)sum / N;
            Console.WriteLine("\n  Sum : {0}", sum);
            Console.WriteLine(" Average : {0}\n", average);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

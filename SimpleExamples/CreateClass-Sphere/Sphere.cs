using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass_Sphere
{
    class Sphere
    {
        double r;

        void EnterRadius()
        {
            while (true) {
                Console.Write("   Sphere radius : ");
                if (double.TryParse(Console.ReadLine(), out r)) 
                    break;
                Console.WriteLine("The value you entered is not a real number.");
                Console.WriteLine("Please enter real number...\n");
            }
        }

        double Area()
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }

        double Valume()
        {
            return (r / 3) * Area();
        }

        public void Calc()
        {
            Console.Write("Calculating Area and Volume of a Sphere\n");
            Console.WriteLine("Pi = ( {0} )\n", Math.PI);
            EnterRadius();
            double x = Area();
            Console.WriteLine("Sphere Area : {0:F6}", x);
            x = Valume();
            Console.WriteLine("      Sphere Volume : {0:F6}", x);

            Console.Write("\nPress a key to exit...");
            Console.ReadKey(true);
        }
    }
}

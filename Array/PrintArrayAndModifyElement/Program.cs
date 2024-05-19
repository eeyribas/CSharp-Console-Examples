using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayAndModifyElement
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = new int[5];

			Console.WriteLine("Before assigning elements to the array:");
			Console.WriteLine("Number of elements:" + numbers.Length);

			for (int i = 0; i < numbers.Length; i++)
				Console.WriteLine("[{0}] = {1}", i, numbers[i]);

			numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			Console.WriteLine("After assigning elements to the array:");
			Console.WriteLine("Number of elements:" + numbers.Length);
			PrintWithForLoop(numbers);

			numbers[1] = -2;
			ModifyElement(numbers, 3, -4);
			Console.WriteLine("After the elements of the array are modified:");
			PrintWithForeachLoop(numbers);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static void PrintWithForLoop(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
				Console.WriteLine("[{0}] = {1}", i, array[i]);
		}

		static void PrintWithForeachLoop(int[] array)
		{
			foreach (int element in array)
				Console.WriteLine(element);
		}

		static void ModifyElement(int[] array, int index, int value)
		{
			array[index] = value;
		}
	}
}

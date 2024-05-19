using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
			string[,] strings = new string[5, 4];

			Console.WriteLine("Before assigning elements to the array:");
			Console.WriteLine("Number of elements:" + strings.Length);

			for (int i = 0; i < strings.GetLength(0); i++)
			{
				for (int j = 0; j < strings.GetLength(1); j++)
					Console.WriteLine("[{0}, {1}] = \"{2}\"", i, j, strings[i, j]);
			}

			strings = new string[,] {{"Str1a", "Str1b"}, {"Str2a", "Str2b"}};
			Console.WriteLine("After assigning elements to the array:");
			Console.WriteLine("Number of elements:" + strings.Length);
			PrintWithForLoop(strings);

			strings[0, 0] = "Str3a";
			ModifyElement(strings, 1, 1, "Str3b");
			Console.WriteLine("After the elements of the array are modified:");
			PrintWithForeachLoop(strings);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static void PrintWithForLoop(string[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
					Console.WriteLine("[{0}, {1}] = \"{2}\"", i, j, array[i, j]);
			}
		}

		static void PrintWithForeachLoop(string[,] array)
		{
			foreach (string value in array)
				Console.WriteLine(value);
		}

		static void ModifyElement(string[,] array, int index1, int index2, string value)
		{
			array[index1, index2] = value;
		}
	}
}

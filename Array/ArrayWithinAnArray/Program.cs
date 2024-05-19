using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithinAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
			bool[][] statuses = new bool[4][];

			for (int i = 0; i < statuses.Length; i++)
				statuses[i] = new bool[i + 1];
			Console.WriteLine("Before assigning elements to the array:");
			Console.WriteLine("Number of elements:" + statuses.Length);

			for (int i = 0; i < statuses.Length; i++)
			{
				for (int j = 0; j < statuses[i].Length; j++)
					Console.WriteLine("[{0}][{1}] = {2}", i, j, statuses[i][j]);
			}

			statuses = new bool[3][] { new bool[] {true, true, false}, new bool[] {true, false}, new bool[] {false, true, true, false}};
			Console.WriteLine("After assigning elements to the array:");
			Console.WriteLine("Number of elements:" + statuses.Length);
			PrintWithForLoop(statuses);

			statuses[0][2] = true;
			ModifyElement(statuses, 1, 0, false);
			Console.WriteLine("After the elements of the array are modified:");
			PrintWithForeachLoop(statuses);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static void PrintWithForLoop(bool[][] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
					Console.WriteLine("[{0}][{1}] = {2}", i, j, array[i][j]);
			}
		}

		static void PrintWithForeachLoop(bool[][] array)
		{
			foreach (bool[] status in array)
			{
				foreach (bool st in status)
					Console.WriteLine(st);
			}
		}

		static void ModifyElement(bool[][] array, int index1, int index2, bool value)
		{
			array[index1][index2] = value;
		}
	}
}

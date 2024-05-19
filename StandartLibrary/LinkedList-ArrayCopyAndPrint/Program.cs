using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_ArrayCopyAndPrint
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("- LinkedList Class Application -");

			LinkedList<char> linkedList = new LinkedList<char>();
			linkedList.AddFirst('A');
			linkedList.AddAfter(linkedList.First, 'C');
			linkedList.AddBefore(linkedList.Last, 'B');
			linkedList.AddLast('D');
			PrintArray(linkedList);

			Console.WriteLine("Enter the character to be deleted from the list : ");
			char ch = Convert.ToChar(Console.ReadLine());
			if (linkedList.Contains(ch))
			{
				linkedList.Remove(ch);
				CopyArray(linkedList);
			}
			else
			{
				Console.WriteLine(ch + " is empty!");
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public static void PrintArray(LinkedList<char> linkedList)
		{
			Console.WriteLine("There are {0} elements in the list.", linkedList.Count);

			LinkedListNode<char> tmp = linkedList.First;
			while (tmp != null)
			{
				Console.WriteLine(tmp.Value);
				tmp = tmp.Next;
			}
		}

		public static void CopyArray(LinkedList<char> linkedList)
		{
			Console.WriteLine("There are {0} elements in the list.", linkedList.Count);

			char[] array = new char[linkedList.Count];
			linkedList.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
				Console.WriteLine(array[i].ToString());
		}
	}
}

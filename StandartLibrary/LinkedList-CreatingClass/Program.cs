using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_CreatingClass
{
    class Program
    {
        public class LinkedListNode
        {
            public string value;
            public LinkedListNode next, previous;
        }

		public class LinkedList
		{
			public LinkedListNode first = null, last = null;
			public int count = 0;

			public void AddFirst(string value)
			{
				if (first == null)
				{
					first = new LinkedListNode();
					first.value = value;
					last = first;
				}
				else
				{
					LinkedListNode newNode = new LinkedListNode();
					LinkedListNode tmpNode = new LinkedListNode();
					tmpNode = first;
					newNode.value = value;
					newNode.next = first;
					first.previous = newNode;
					first = newNode;
					newNode = tmpNode;
				}

				count++;
			}

			public void AddLast(string value)
			{
				if (first == null)
				{
					first = new LinkedListNode();
					first.value = value;
					last = first;
				}
				else
				{
					LinkedListNode newNode = new LinkedListNode();
					LinkedListNode tmpNode = new LinkedListNode();
					tmpNode = last;
					newNode.value = value;
					newNode.previous = last;
					last.next = newNode;
					last = newNode;
					newNode = tmpNode;
				}

				count++;
			}

			public void AddPrevious(LinkedListNode selectedNode, string value)
			{
				if (selectedNode != first)
				{
					LinkedListNode newNode = new LinkedListNode();
					newNode.value = value;
					newNode.next = selectedNode;
					newNode.previous = selectedNode.previous;
					selectedNode.previous = newNode;
					newNode.previous.next = newNode;
				}
				else
				{
					LinkedListNode newNode = new LinkedListNode();
					newNode.value = value;
					newNode.next = selectedNode;
					selectedNode.previous = newNode;
					first = newNode;
				}

				count++;
			}

			public void AddNext(LinkedListNode selectedNode, string value)
			{
				if (selectedNode != last)
				{
					LinkedListNode newNode = new LinkedListNode();
					newNode.value = value;
					newNode.next = selectedNode.next;
					newNode.previous = selectedNode;
					selectedNode.next.previous = newNode;
					selectedNode.previous = newNode;
					selectedNode.next = newNode;
				}
				else
				{
					LinkedListNode newNode = new LinkedListNode();
					newNode.value = value;
					newNode.previous = selectedNode;
					selectedNode.next = newNode;
					last = newNode;
				}

				count++;
			}

			public bool Content(string value)
			{
				LinkedListNode node = new LinkedListNode();

				if (this.count != 0)
				{
					node = this.first;
					while (node != null)
					{
						if (node.value == value)
							return true;

						node = node.next;
					}
				}

				return false;
			}

			public bool Delete(string value)
			{
				LinkedListNode node = new LinkedListNode();

				if (this.count != 0)
				{
					node = this.first;

					while (node != null)
					{
						if (node.value == value)
						{
							if (node != first && node != last)
							{
								node.previous.next = node.next;
								node.next.previous = node.previous;
							}
							else if (node == first)
							{
								if (this.count == 1)
								{
									this.first = null;
								}
								else
								{
									node.next.previous = null;
									first = node.next;
								}
							}
							else
							{
								if (this.count == 1)
								{
									this.last = null;
								}
								else
								{
									node.previous.next = null;
									last = node.previous;
								}
							}
							count--;

							return true;
						}

						node = node.next;
					}
				}

				return false;
			}

			public LinkedListNode Find(string value)
			{
				LinkedListNode node = new LinkedListNode();
				if (this.count != 0)
				{
					node = this.first;

					while (node != null)
					{
						if (node.value == value)
							return node;

						node = node.next;
					}
				}

				return null;
			}

			public void CopyArray(string[] array)
			{
				LinkedListNode node = new LinkedListNode();
				int count = 0;

				if (this.count != 0)
				{
					node = this.first;
					while (node != null)
					{
						array[count] = node.value;
						node = node.next;
						count++;
					}
				}
			}
		}

		static void Main(string[] args)
        {
			Console.WriteLine("- LinkedList Class Application -");

			LinkedList linkedList = new LinkedList();
			linkedList.AddFirst("A");
			linkedList.AddNext(linkedList.first, "C");
			linkedList.AddPrevious(linkedList.last, "B");
			linkedList.AddLast("D");
			Print(linkedList);

			Console.WriteLine("Enter the character to be deleted from the list:");
			string ch = Console.ReadLine();
			if (linkedList.Content(ch))
			{
				linkedList.Delete(ch);
				PrintCopyingArray(linkedList);
			}
			else
			{
				Console.WriteLine(ch + " is empty!");
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public static void Print(LinkedList linkedList)
		{
			Console.WriteLine("There are {0} elements in the list.", linkedList.count);
			LinkedListNode tmp = linkedList.first;

			while (tmp != null)
			{
				Console.WriteLine(tmp.value);
				tmp = tmp.next;
			}
		}

		public static void PrintCopyingArray(LinkedList linkedList)
		{
			Console.WriteLine("There are {0} elements in the list.", linkedList.count);
			string[] array = new string[linkedList.count];
			linkedList.CopyArray(array);
			for (int i = 0; i < array.Length; i++)
				Console.WriteLine(array[i].ToString());
		}
	}
}

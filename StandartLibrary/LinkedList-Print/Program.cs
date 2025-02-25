using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> linkedList = new LinkedList<char>();
            linkedList.AddFirst('a');
            Print(linkedList);
            Console.WriteLine("-----");

            linkedList.AddAfter(linkedList.First, 'c');
            linkedList.AddBefore(linkedList.First.Next, 'n');
            linkedList.AddBefore(linkedList.Last, 'b');
            linkedList.AddLast('d');
            Print(linkedList);
            Console.WriteLine("-----");

            char character = Convert.ToChar(Console.ReadLine());
            if (linkedList.Contains(character))
            {
                linkedList.Remove(character);
                Console.WriteLine("Deleted element in LinkedList.");
            }
            else
            {
                Console.WriteLine("It is not in the LinkedList.");
            }
            Print(linkedList);
        }

        public static void Print(LinkedList<char> linkedList)
        {
            LinkedListNode<char> linkedListNode;
            linkedListNode = linkedList.First;
            while (linkedListNode != null)
            {
                Console.WriteLine(linkedListNode.Value.ToString());
                linkedListNode = linkedListNode.Next;
            }
        }
    }
}

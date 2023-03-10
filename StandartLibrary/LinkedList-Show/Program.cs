using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Show
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Esen EYRIBAS";

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(0);
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.RemoveFirst();
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);
            linkedList.AddLast(6);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            linkedList.AddLast(7);
            linkedList.AddFirst(8);
            linkedList.AddFirst(9);

            LinkedListNode<int> linkedListNode;
            Console.WriteLine("Linked List Length  = {0}", linkedList.Count);
            Console.Write("Linked List Values = ");
            for (linkedListNode = linkedList.First; linkedListNode != null; linkedListNode = linkedListNode.Next) {
                if (linkedListNode != linkedList.First) 
                    Console.Write(" , ");
                Console.Write(linkedListNode.Value);
            }
            Console.WriteLine();

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

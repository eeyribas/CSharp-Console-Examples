using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeClass binaryTreeClass = new BinaryTreeClass();
            binaryTreeClass.AddNode(5);
        }

        class BinaryTreeNode
        {
            public int data;
            BinaryTreeNode rightNode, leftNode;
        }

        class BinaryTreeClass
        {
            BinaryTreeNode rootNode;

            public void AddNode(int value)
            {
                BinaryTreeNode newNode = new BinaryTreeNode
                {
                    data = value
                };

                if (this.rootNode == null) {
                    this.rootNode = newNode;
                }
                else {
                    BinaryTreeNode tmpNode;
                    tmpNode = rootNode;
                }
            }
        }
    }
}

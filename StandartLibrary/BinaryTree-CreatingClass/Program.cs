using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_CreatingClass
{
    class Program
    {
        public class BinaryTreeNode
        {
            public BinaryTreeNode leftNode;
            public BinaryTreeNode rightNode;
			public int data;
		}

		public class BinaryTree
		{
			private BinaryTreeNode rootNode;

			public BinaryTreeNode GetRootNode()
			{
				return rootNode;
			}

			public void AddNode(int value)
			{
				if (rootNode == null)
				{
					rootNode = new BinaryTreeNode();
					rootNode.data = value;
				}
				else
				{
					BinaryTreeNode currentNode = rootNode;
					BinaryTreeNode newNode = new BinaryTreeNode();
					newNode.data = value;

					while (currentNode != null)
					{
						if (newNode.data > currentNode.data)
						{
							if (currentNode.rightNode == null)
							{
								currentNode.rightNode = newNode;
								return;
							}
							else
							{
								currentNode = currentNode.rightNode;
							}
						}
						else if (newNode.data < currentNode.data)
						{
							if (currentNode.leftNode == null)
							{
								currentNode.leftNode = newNode;
								return;
							}
							else
							{
								currentNode = currentNode.leftNode;
							}
						}
						else
						{
							return;
						}
					}
				}
			}

			public bool SearchNode(int value)
			{
				if (rootNode == null)
				{
					Console.WriteLine("Tree is empty!!!");
					return false;
				}
				else
				{
					BinaryTreeNode currentNode = rootNode;

					while (currentNode != null)
					{
						if (value > currentNode.data)
						{
							if (currentNode.rightNode == null)
								return false;
							else
								currentNode = currentNode.rightNode;
						}
						else if (value < currentNode.data)
						{
							if (currentNode.leftNode == null)
								return false;
							else
								currentNode = currentNode.leftNode;
						}
						else
						{
							return true;
						}
					}

					return false;
				}
			}

			public void FirstInorderTraversal(BinaryTreeNode node)
			{
				if (node != null)
				{
					Console.WriteLine(node.data.ToString());
					FirstInorderTraversal(node.leftNode);
					FirstInorderTraversal(node.rightNode);
				}
			}

			public void InorderTraversal(BinaryTreeNode node)
			{
				if (node != null)
				{
					InorderTraversal(node.leftNode);
					Console.WriteLine(node.data.ToString());
					InorderTraversal(node.rightNode);
				}
			}

			public void LastInorderTraversal(BinaryTreeNode node)
			{
				if (node != null)
				{
					LastInorderTraversal(node.leftNode);
					LastInorderTraversal(node.rightNode);
					Console.WriteLine(node.data.ToString());
				}
			}
		}

		static void Main(string[] args)
        {
			BinaryTree binaryTree = new BinaryTree();
			Random random = new Random();

			Console.WriteLine("Elements of the tree:");
			for (int i = 0; i < 10; i++)
			{
				int number = random.Next(1, 101);
				Console.WriteLine(number.ToString());
				binaryTree.AddNode(number);
			}

			Console.WriteLine("Enter the value to search for:");
			if (binaryTree.SearchNode(Convert.ToInt32(Console.ReadLine())))
				Console.WriteLine("Find!");
			else
				Console.WriteLine("Not find!");

			Console.WriteLine("Inorder traversal:");
			binaryTree.FirstInorderTraversal(binaryTree.GetRootNode());
			Console.WriteLine("Traversal in order:");
			binaryTree.InorderTraversal(binaryTree.GetRootNode());
			Console.WriteLine("Postorder traversal:");
			binaryTree.LastInorderTraversal(binaryTree.GetRootNode());

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
    }
}

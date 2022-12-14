using System;

namespace BinaryTree
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree problem");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();

            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(63);
           
            int Size = BinaryTree.GetSize();
            Console.WriteLine(Size);

            bool result = BinaryTree.SearchKey(63);
            Console.WriteLine(result);
        }
    }
}

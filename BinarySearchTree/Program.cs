using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Message To Binary Search Trees");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            //Inserting nodes into binary search tree.
            binarySearchTree.InsertNode(30);
            binarySearchTree.InsertNode(70);
            binarySearchTree.InsertNode(22);
            binarySearchTree.InsertNode(40);
            binarySearchTree.InsertNode(60);
            binarySearchTree.InsertNode(95);
            binarySearchTree.InsertNode(11);
            binarySearchTree.InsertNode(65);
            binarySearchTree.InsertNode(3);
            binarySearchTree.InsertNode(16);
            binarySearchTree.InsertNode(63);
            binarySearchTree.InsertNode(67);

            //Display the binary binary search tree 
            binarySearchTree.Display();

            //Getting the size of Binary search tree
            binarySearchTree.GetSize();

            //Searching a node in binary search tree.
            bool result = binarySearchTree.IfExists(63, binarySearchTree);
            Console.WriteLine(result);

        }
    }
}

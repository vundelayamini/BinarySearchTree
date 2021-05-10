using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        //Getting and setting nodedata.
        public T NodeData { get; set; }

        //Getting and setting the left tree.
        public BinarySearchTree<T> leftTree { get; set; }
        /// Getting and setting the right tree.
        public BinarySearchTree<T> rightTree { get; set; }

        //Initializing the nodeDat,left tree and right tree.
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        //Insert a element in a binary search tree
        public void InsertNode(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.InsertNode(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.InsertNode(item);
            }
        }
        /// Displaying the Binary search tree nodes.
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }
        //Using size method by getting size of binary search tree.
        public void GetSize()
        {
            Console.WriteLine("Size of binary search tree is " +" "+ (1 + this.leftCount + this.rightCount));
        }
        //Searching a node in Binary search tree.
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element found in the binary search tree : " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("Current node in BST is : " + node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.rightTree);
            }
            return result;
        }
    }


}

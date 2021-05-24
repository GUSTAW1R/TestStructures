using System;
using TestStructures.BinaryTree;
using TestStructures.DoubleList;

namespace TestStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //CircleDoublyLinkedList<int> linkedList = new CircleDoublyLinkedList<int>();
            //linkedList.Add(22);
            //linkedList.Add(42);
            //linkedList.Add(62);
            //foreach (var item in linkedList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //linkedList.Remove(42);
            //foreach (var item in linkedList)
            //{
            //    Console.Write(item + " ");
            //}
            BinaryTree<int> Tree = new BinaryTree<int>(50);
            Tree.add(40);
            Tree.add(60);
            Tree.add(70);
            Tree.add(65);
            Tree.add(56);
            Tree.print(Tree);
        }
    }
}

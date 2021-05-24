using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStructures.BinaryTree
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
		private BinaryTree<T> left, right;
		private T item;
		private List<dynamic> listForPrint = new List<dynamic>();

		public BinaryTree(T val)
		{
			this.item = val;
		}

		public void add(T item)
		{
			if (item.CompareTo(this.item) < 0)
			{
				if (this.left == null)
				{
					this.left = new BinaryTree<T>(item);
				}
				else if (this.left != null)
					this.left.add(item);
			}
			else
			{
				if (this.right == null)
				{
					this.right = new BinaryTree<T>(item);
				}
				else if (this.right != null)
					this.right.add(item);
			}
		}

		public BinaryTree<T> search(BinaryTree<T> tree, T val)
		{
			if (tree == null) return null;
			switch (val.CompareTo(tree.item))
			{
				case 1: 
					return search(tree, val);
				case -1: 
					return search(tree, val);
				case 0: 
					return tree;
				default:
					return null;
			}
		}
		public void print(BinaryTree<T> node)
		{
			if (node == null) return;
			print(node.left);
			listForPrint.Add(node.item);
			Console.Write(node + " ");
			if (node.right != null)
				print(node.right);
		}
		public override string ToString()
		{
			return item.ToString();
		}
        public IEnumerator<T> GetEnumerator()
        {
            if (left != null)
            {
                foreach (var item in this.left)
                {
                    yield return item;
                }
            }
            yield return this.item;
            if (right != null)
            {
                foreach (var item in this.right)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
			return ((IEnumerable)this).GetEnumerator();
		}

    }
}

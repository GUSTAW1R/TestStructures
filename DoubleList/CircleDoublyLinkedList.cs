using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStructures.DoubleList
{
    class CircleDoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyNode<T> head;
        int count;

        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
            {
                head = node;
                head.Next = node;
                head.Previous = node;
            }
            else
            {
                node.Previous = head.Previous;
                node.Next = head;
                head.Previous.Next = node;
                head.Previous = node;
            }
            count++;
        }

        public bool Remove(T data)
        {
            DoublyNode<T> current = head;

            DoublyNode<T> removedItem = null;
            if (count == 0) return false;

            do
            {
                if (current.Data.Equals(data))
                {
                    removedItem = current;
                    break;
                }
                current = current.Next;
            } while (current != head);

            if (removedItem != null)
            {
                if (count == 1)
                    head = null;
                else
                {
                    if (removedItem == head)
                    {
                        head = head.Next;
                    }
                    removedItem.Previous.Next = removedItem.Next;
                    removedItem.Next.Previous = removedItem.Previous;
                }
                count--;
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            int countItem = count;
            DoublyNode<T> current = head;
            while (current != null && countItem > 0)
            {
                yield return current.Data;
                current = current.Next;
                countItem--;
            }
        }
    }
}

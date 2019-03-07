using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class DynamicQueue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public int Count;

        public DynamicQueue()
        {
            Count = 0;
            head = null;
            tail = null;
        }

        public void Enqueue(T item)
        {
            Node<T> node = new Node<T>(item);
            if (Count==0)
            {
                node.Next = null;
                head = node;
                tail = node;
            }
            else if (Count==1)
            {
                head = node;
                head.Next = tail;
            }
            else
            {
                node.Next = head;
                head = node;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException();
            T item = tail.Value;
            if (Count == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node<T> node = head;
                while (!node.Next.Equals(tail))
                    node = node.Next;
                tail = node;
                tail.Next = null;
            }
            Count--;
            return item;
        }

        public T Peek()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException();
            return tail.Value;
        }

        public void Clear()
        {
            head.Next = null;
            head = null;
            tail = null;
        }

        public bool Contains(T item)
        {
            Node<T> node = head;
            bool ret = false;

            while (node!=null)
            {
                if (node.Value.Equals(item))
                {
                    ret = true;
                    break;
                }
                node = node.Next;
            }
            return ret;
        }

        public T[] ToArray()
        {
            T[] arr = new T[Count];
            Node<T> node = head;
            for (int i=0; i<Count; i++)
            {
                arr[i] = node.Value;
                node = node.Next;
            }
            return arr;
        }
    }
}

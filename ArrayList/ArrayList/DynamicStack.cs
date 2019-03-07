using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class DynamicStack<T>
    {
        private Node<T> head;
        public int Count;

        public DynamicStack()
        {
            this.head = null;
            Count = 0;
        }

        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);
            if (Count == 0)
            {
                this.head = node;
                head.Next = null;
            }
            else
            {
                node.Next = this.head;
                this.head = node;
            }
            Count++;
        }

        public T Pop()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException();
            T item = this.head.Value;
            if (Count == 1)
                this.head = null;
            else
                this.head = this.head.Next;
            Count--;
            return item;
        }

        public T Peek()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException();
            return this.head.Value;
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            if (Count == 0) return false;
            var ret = false;
            Node<T> node = this.head;
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
            Node<T> node = this.head;
        
            for (int i = 0; i < Count; i++)
            {
                arr[i] = node.Value;
                node = node.Next;
            }
        
            return arr;
        }

    }
}

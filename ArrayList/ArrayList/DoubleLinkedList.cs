using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class DoubleLinkedList<T>
    {
        private DoubleLinkedNode<T> head;
        private DoubleLinkedNode<T> tail;

        public int Count { get; private set; }

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            Count = 0;

        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                    throw new ArgumentOutOfRangeException();
                DoubleLinkedNode<T> curr = head;
                for (int i=0; i<index; i++)
                {
                    curr = curr.Next;
                }
                return curr.Value;
            }
            set
            {
                if (index >= Count)
                    throw new ArgumentOutOfRangeException();
                DoubleLinkedNode<T> curr = head;
                for (int i = 0; i < index; i++)
                {
                    curr = curr.Next;
                }
                curr.Value = value;
            }
            
        }

        public void AddFront(T item)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(item);
            if (Count==0)
            {
                head = node;
                head.Next = null;
                tail = node;
                tail.Next = null;
                Count++;
            }
            else if (Count==1)
            {
                head = node;
                head.Next = tail;
                tail.Prev = head;
                head.Prev = null;
                Count++;
            }
            else
            {
                node.Next = head;
                head.Prev = node;
                head = head.Prev;
                Count++;
            }
        }

        public void AddEnd(T item)
        {
            DoubleLinkedNode<T> node = new DoubleLinkedNode<T>(item);
            if (Count == 0)
            {
                head = node;
                head.Next = null;
                tail = node;
                tail.Next = null;
                Count++;
            }
            else if (Count == 1)
            {
                node.Next = null;
                tail = node;
                head.Next = tail;
                tail.Prev = head;
                Count++;
            }
            else
            {
                node.Next = null;
                tail.Next = node;
                node.Prev = tail;
                tail = node;
                Count++;
            }
        }

        public void Remove(T item)
        {
            if (IndexOf(item)!=-1)
            {
                remove(item);
            }

        }

        public void RemoveAt(int index)
        {
            remove(this[index]);
        }

        public int IndexOf(T item)
        {
            DoubleLinkedNode<T> curr = head;
            for (int i = 0; i < Count; i++)
            {
                if (curr.Value.Equals(item))
                {
                    return i;
                }
                curr = curr.Next;
            }
            return -1;
        }

        private void remove(T item)
        {
            if (head.Value.Equals(item))
            {
                head = head.Next;
                head.Prev = null;
                Count--;
            }
            else if (tail.Value.Equals(item))
            {
                tail = tail.Prev;
                tail.Next = null;
                Count--;
            }
            else
            {
                DoubleLinkedNode<T> node = head;
                while (!node.Value.Equals(item))
                    node = node.Next;
                node.Prev.Next = node.Next;
                Count--;
            }
        }
        //public void ForEach(Action<T> action)
        //{
        //    DoubleLinkedNode<T> current = head;
        //    while (current is DoubleLinkedNode<T>)
        //    {
        //        action(current.Value);
        //        current = current.Next;
                
        //    }
        //}
    }
}
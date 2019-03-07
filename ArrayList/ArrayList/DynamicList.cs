using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class MyDynamicList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                    throw new ArgumentOutOfRangeException();
                Node<T> curr = head;
                for (int i = 0; i < index; i++)
                    curr = curr.Next;
                return curr.Value;
            }
            set
            {
                if (index >= Count)
                    throw new ArgumentOutOfRangeException();
                Node<T> curr = head;
                for (int i = 0; i < index; i++)
                    curr = curr.Next;
                curr.Value = value;
            }
        }

        public void AddFirst(T item)
            {
            Node<T> addThis = new Node<T>(item);
            if (Count == 0)
            {
                Count++;
                head = addThis;
                tail = addThis;
                head.Next = null;
                tail.Next = null;
            }
            else
            {
                Count++;
                addThis.Next = head;
                head = addThis;
            }

        }

        public void Remove(T item)
        {
            Node<T> curr = head;
            if (IndexOf(item) != -1)
            {
                if (head.Value.Equals(item))
                {
                    head = head.Next;
                    Count--;
                }
                else if (tail.Value.Equals(item))
                {
                    for (int i = 0; i < Count - 1; i++)
                    {
                        curr = curr.Next;
                    }
                    tail = curr;
                    tail.Next = null;
                    Count--;
                }
                else
                {
                    for (int i = 0; i < Count; i++)
                    {
                        if (curr.Next.Value.Equals(item)) break;
                        curr = curr.Next;
                    }
                    curr.Next = curr.Next.Next;
                    Count--;
                }
            }
        }
        public void AddLast(T item)
        {
            Node<T> addThis = new Node<T>(item);
            if (Count == 0)
            {
                Count++;
                head = addThis;
                tail = addThis;
                head.Next = null;
                tail.Next = null;
            }
            else
            {
                Count++;
                tail.Next = addThis;
                tail = tail.Next;
            }
        }

        public int IndexOf(T item)
        {
            Node<T> curr = head;
            for (int i=0; i<Count; i++)
            {
                if (curr.Value.Equals(item))
                {
                    return i;
                }
                curr = curr.Next;   
            }
            return -1;
        }
        public void RemoveAt(int index)
        {
            Remove(this[index]);
        }
    }
}

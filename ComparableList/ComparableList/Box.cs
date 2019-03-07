using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableList
{
    class Box<T> : IBox<T>
        where T : IComparable
    {
        private T[] items;
        private int count;

        public Box()
        {
            this.items = new T[4];
            this.count = 0;
        }

        public int Count { get => this.count; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (++this.count > items.Length)
            {
                this.extendArray();
            }
            this.items[count - 1] = item;
        }

        private void extendArray()
        {
            var temp = new T[count + 4];
            items.CopyTo(temp, 0);
            items = temp;
        }

        public bool Contains(T element)
        {
            if (count < 1) throw new ArgumentOutOfRangeException("Box is empty.");
            return items.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            if (count < 1) throw new ArgumentOutOfRangeException("Box is empty.");
            int br = 0;
            for (int i=0; i<count; i++)
            {
                if (items[i].CompareTo(element) == 1) br++;
            }
            return br;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0; i<count; i++)
            {
                yield return items[i];
            }
        }

        public T Max()
        {
            if (count < 1) throw new ArgumentOutOfRangeException("Box is empty.");
            return items.Max();
        }

        public T Min()
        {
            if (count < 1) throw new ArgumentOutOfRangeException("Box is empty.");
            return items.Min();
        }

        public T Remove(int index)
        {
            if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();
            T item = items[index];
            T[] temp = new T[items.Length];
            int br = 0;
            for (int i=0; i<Count; i++)
            {
                if (i == index) continue;
                temp[br++] = items[i];
            }
            count--;
            items = temp;
            return item;
        }

        public void Sort()
        {
            if (count < 1) throw new ArgumentOutOfRangeException("Box is empty.");
            else if (count > 1)
            {
                for (int i = count-1; i >=0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (items[j].CompareTo(items[j + 1]) == 1) Swap(j, j + 1);
                    }
                }
            }
        }

        public void Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= count || index2 < 0 || index2 >= count) throw new ArgumentOutOfRangeException();
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

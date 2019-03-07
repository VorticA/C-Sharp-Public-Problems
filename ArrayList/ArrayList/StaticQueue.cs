using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class StaticQueue<T>
    {
        private int startIndex;
        private int endIndex;
        private const int startCap = 4;
        public int Count;
        private T[] array;

        public StaticQueue()
        {
            array = new T[startCap];
            Count = 0;
            startIndex = 0;
            endIndex = 0;
        }

        public void Enqueue(T item)
        {
            if (Count == array.Length) Resize();
            Add(item);

        }

        public T Dequeue()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException();
            T item = array[startIndex];
            array[startIndex] = default(T);
            Count--;
            startIndex++;
            return item;
        }

        public T Peek()
        {
            if (Count == 0) throw new ArgumentOutOfRangeException();
            return array[startIndex];
        }

        public void TrimExcess()
        {
            if (array.Length > Count)
            {
                T[] temp = new T[Count];
                int br = 0;
                for (int i=startIndex; i<=endIndex; i++)
                {
                    temp[br] = array[i];
                    br++;
                }
                array = temp;
                startIndex = 0;
                endIndex = Count - 1;
            }
        }

        public void Clear()
        {
            array = new T[startCap];
            Count = 0;
        }

        public bool Contains(T item)
        {
            bool ret = false;
            for (int i=startIndex; i<=endIndex; i++)
            {
                if (array[i].Equals(item))
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public T[] ToArray()
        {
            T[] ret = new T[Count];
            Array.Copy(array, startIndex, ret, 0, Count);
            return ret;
        }

        private void Add(T item)
        {
            if (Count == 0)
            {
                array[0] = item;
            }
            else
            {
                array[endIndex + 1] = item;
                endIndex++; 
            }
            Count++;
            
        }

        private void Resize()
        {
            T[] temp = new T[array.Length * 2];
            Array.Copy(array, temp, Count);
            array = temp;
        }
    }
}

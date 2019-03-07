using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList<T>
    {
        private const int startSize= 2;
        private T[] array;
        public ArrayList()
        {
            this.array = new T[startSize];
        }
        public int Count { get; private set; }
        public T this[int index]
        {
            get
            {
                if (index >= Count) throw new ArgumentOutOfRangeException();
                else return array[index];
            }
            set
            {
                if (index >= Count) throw new ArgumentOutOfRangeException();
                else array[index] = value;
            }
        }
        private void Resize()
        {
            var copy = new T[this.array.Length*2];
            for (int i = 0; i < this.array.Length; i++)
                copy[i] = this.array[i];
            this.array = copy;
        }
        public void Add(T item)
        {
            Count++;
            if (Count == this.array.Length) this.Resize();
            this.array[Count - 1] = item;
        }
        public void RemoveAt(int index)
        {
            if (index >= this.Count) throw new ArgumentOutOfRangeException();
            this.array[index] = default(T);
            this.Shift(index);
            Count--;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count; i++)
                array[i] = array[i + 1];
        }
        public void Shrink()
        {
            if (Count == this.array.Length)
            {
                var copy = new T[Count];
                for (int i = 0; i < Count; i++)
                    copy[i] = this.array[i];
                this.array = copy;
            }
        }
    }
}

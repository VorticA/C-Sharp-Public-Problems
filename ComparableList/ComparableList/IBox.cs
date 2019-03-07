using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableList
{
    interface IBox<T> : IEnumerable<T>
    {
        int Count { get; }
        void Add(T item);
        T Remove(int index);
        bool Contains(T element);
        void Swap(int index1, int index2);
        int CountGreaterThan(T Element);
        T Max();
        T Min();
        void Sort();
        T this[int index] { get; set; }
    }
}

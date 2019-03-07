using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Node<T>
    {
        public T Value { get { return this.value; } set { this.value = value; } }
        public Node<T> Next { get { return this.next; } set { this.next = value; } }
        private T value;
        private Node<T> next;
        public Node(T value)
        {
            this.Value = value;
        }
    }
}

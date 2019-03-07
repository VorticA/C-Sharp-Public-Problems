using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class DoubleLinkedNode<T>
    {
        private T value;
        private DoubleLinkedNode<T> prevNode;
        private DoubleLinkedNode<T> nextNode;

        public  T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public DoubleLinkedNode<T> Prev
        {
            get
            {
                return this.prevNode;
            }
            set
            {
                this.prevNode = value;
            }
        }

        public DoubleLinkedNode<T> Next
        {
            get
            {
                return this.nextNode;
            }
            set
            {
                this.nextNode = value;
            }
        }

        public DoubleLinkedNode(T value)
        {
            this.value = value;
        }
    }
}

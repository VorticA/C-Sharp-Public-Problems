using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapper
{
    public class Box<T>
    {
        private T value;

        public T Value { get => value; set => this.value = value; }

        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return typeof(T).FullName + ": " + this.value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public string Name { get => this.name; set => this.name = value; }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Age must be positive!");
                this.age = value;
            }
        }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}", this.name, this.age);
        }
    }
}

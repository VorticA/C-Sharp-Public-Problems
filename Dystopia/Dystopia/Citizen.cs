using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dystopia
{
    class Citizen : Inhabitant, IBirthDateable, IBuyer
    {
        private string name;
        private int age;

        public DateTime BirthDate { get; set; }
        public string Name { get => this.name; set => this.name=value; }
        public int Age { get => this.age; set => this.age=value; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            base.Id = id;
        }
        public Citizen(string name, int age, string id, DateTime bday)
            : this(name, age, id)
        {
            this.BirthDate = bday;
        }

        public int BuyFood()
        {
            this.Food += 10;
            return 10;
        }
    }
}

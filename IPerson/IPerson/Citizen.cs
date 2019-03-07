using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPerson
{
    class Citizen : IPerson, IIdentifiable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public string Name { get => this.name; set => this.name=value; }
        public int Age { get => this.age; set => this.age=value; }
        public string Birthdate { get => this.birthdate; set => this.birthdate=value; }
        public string Id { get => this.id; set => this.id=value; }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Citizen(string name, int age, string id)
            : this(name, age)
        {
            this.Id = id;
        }
        public Citizen(string name, int age, string id, string birthdate)
            : this(name, age, id)
        {
            this.Birthdate = birthdate;
        }
    }
}

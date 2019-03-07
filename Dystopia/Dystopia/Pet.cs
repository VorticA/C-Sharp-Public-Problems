using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dystopia
{
    class Pet : IBirthDateable
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Pet(string name, DateTime bday)
        {
            this.Name = name;
            this.BirthDate = bday;
        }
    }
}

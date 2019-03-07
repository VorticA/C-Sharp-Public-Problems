using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dystopia
{
    class Robot : Inhabitant
    {
        private string model;

        public string Model { get => this.model; set => this.model=value; }

        public Robot(string model, string id)
        {
            this.Model = model;
            base.Id = id;
        }
    }
}

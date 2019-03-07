using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        private string color;
        private string model;

        public string Model { get => this.model; set => this.model=value; }
        public string Color { get => this.color; set => this.color=value; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return this.color + " Seat " + this.model;
        }
    }
}

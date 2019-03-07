using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : IElectricCar
    {
        private string color;
        private string model;
        private int battery;

        public string Model { get => this.model; set => this.model = value; }
        public string Color { get => this.color; set => this.color = value; }
        public int Battery
        {
            get => this.battery;
            set
            {
                if (value < 1) throw new InvalidBatteriesException("Batteries must be 1 or more.");
                this.battery = value;
            }
        }

        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
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
            if (this.battery==1)
                return this.color + " Tesla " + this.model + " with 1 Battery";
            else
                return this.color + " Tesla " + this.model + " with " + this.battery + " Batteries";
        }
    }
}

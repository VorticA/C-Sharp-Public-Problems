using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    public abstract class ColoredFigure
    {
        protected double size;
        protected string color;

        public ColoredFigure(string color, double size)
        {
            this.size = size;
            this.color = color;
        }
        public abstract string GetName();
        public abstract double GetArea();

        public override string ToString()
        {
            return String.Format("{0}:\n" +
                "Color: {1}\n" +
                "Size: {2}\n" +
                "Area: {3}",
                this.GetName(), this.color, this.size, String.Format("{0:0.00}", this.GetArea()));
        }
    }
}

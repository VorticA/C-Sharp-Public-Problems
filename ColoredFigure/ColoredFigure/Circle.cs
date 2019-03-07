using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    class Circle : ColoredFigure
    {
        public Circle(string color, double size)
            : base(color, size)
        {

        }

        public override string GetName()
        {
            return "Circle";
        }
        public override double GetArea()
        {
            return Math.PI * base.size * base.size;
        }
    }
}

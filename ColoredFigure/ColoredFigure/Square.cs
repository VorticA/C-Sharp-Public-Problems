using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    class Square : ColoredFigure
    {
        public Square(string color, double size)
            : base(color, size)
        {

        }

        public override string GetName()
        {
            return "Square";
        }
        public override double GetArea()
        {
            return base.size * base.size;
        }
    }
}

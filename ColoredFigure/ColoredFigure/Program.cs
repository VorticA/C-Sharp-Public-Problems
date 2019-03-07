using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<ColoredFigure> Figures = new List<ColoredFigure>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToList();
                if (line[0] == "Triangle") Figures.Add(new Triangle(line[1], int.Parse(line[2])));
                else if (line[0] == "Square") Figures.Add(new Square(line[1], int.Parse(line[2])));
                else if (line[0] == "Circle") Figures.Add(new Circle(line[1], int.Parse(line[2])));
            }
            Figures.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}

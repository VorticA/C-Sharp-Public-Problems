using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public static class Engine
    {
        public static void Run()
        {
            Program.EnterMatrix();
            for (int i = 0; i < Program.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Program.Matrix.GetLength(1); j++)
                {

                    if (Program.Matrix[i, j] == '-')
                    {
                        Program.Areas.Add(new Area(i, j));
                        Program.areas++;
                        Program.SearchArea(i, j);
                    }
                }
            }
            Program.PrintAreas();
        }
    }
}

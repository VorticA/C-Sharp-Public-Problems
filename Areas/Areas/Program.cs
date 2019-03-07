using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public static class Program
    {
        public static char[,] Matrix;
        public static List<Area> Areas = new List<Area>();
        public static int areas = 0;
        public static void Main(string[] args)
        {
            Engine.Run();
        }

        public static void PrintAreas()
        {
            Console.WriteLine("Total areas found: " + areas);
            Areas = Areas.OrderByDescending(p => p.Size).ThenBy(p => p.CorHeight).ThenBy(p => p.CorLength).ToList();
            Areas.ForEach(p => Console.WriteLine("Area #{0} at ({1}, {2}), size: {3}", Areas.IndexOf(p) + 1, p.CorHeight, p.CorLength, p.Size));
        }

        public static void SearchArea(int row, int col)
        {
            if (!IsInRange(row, col)) return;
            else
            {
                if (Matrix[row, col] != '-') return;
                else
                {
                    Areas[areas - 1].Size++;
                    Matrix[row, col] = 'm';
                    SearchArea(row, col + 1);
                    SearchArea(row + 1, col);
                    SearchArea(row - 1, col);
                    SearchArea(row, col - 1);
                }
            }
        }
        public static bool IsInRange(int row, int col)
        {
            if (row < Matrix.GetLength(0) && row >= 0 && col < Matrix.GetLength(1) && col >= 0) return true;
            else return false;
        }
        public static void EnterMatrix()
        {
            var W = int.Parse(Console.ReadLine());
            var H = int.Parse(Console.ReadLine());
            Matrix = new char[W, H];
            for (int i=0; i<W; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < H; j++)
                    Matrix[i, j] = line[j];
            }
        }
    }
}

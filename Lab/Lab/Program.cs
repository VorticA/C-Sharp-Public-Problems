using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static List<char> Path = new List<char>();
        static List<string> Paths = new List<string>();
        static char[,] Matrix;

        static void Search(int row, int col, char dir)
        {
            if (IsWall(row, col))
                return;
            else
            {
                Path.Add(dir); // Adds potential path letter in list.
                if (IsExit(row, col)) AddPath(Path);
                else if (IsNotVisited(row, col))
                {
                    MarkPath(row, col); // Leaves a trace to keep track of the path.

                    Search(row, col + 1, 'R');
                    Search(row, col - 1, 'L');
                    Search(row + 1, col, 'D');
                    Search(row - 1, col, 'U');

                    UnMarkPath(row, col); // Removes trace.


                    // Goes back a step and tries for other paths.
                }
                if (Path.Count>0) Path.RemoveAt(Path.Count - 1); //Removes last direction.
            }
        }

        private static void EnterMatrix()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var mtr = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < cols; j++)
                    mtr[i, j] = line[j];
            }
            Matrix = mtr;
        }

        private static void AddPath(List<char> path)
        { 
            Path.Remove('S');
            var pth = string.Join("", Path);
            Paths.Add(pth);
        }

        private static bool IsExit(int row, int col)
        {
            if (Matrix[row, col] == 'e') return true;
            else return false;
        }

        private static bool IsNotVisited(int row, int col)
        {
            if (Matrix[row, col] == 'm') return false;
            else return true;
        }

        private static void UnMarkPath(int row, int col)
        {
            Matrix[row, col] = '-';
        }

        private static void MarkPath(int row, int col)
        {
            Matrix[row, col] = 'm';
        }

        private static bool IsWall(int row, int col)
        {
            int Rows = Matrix.GetLength(0);
            int Cols = Matrix.GetLength(1);
            if (row >= Rows || col >= Cols || row < 0 || col < 0) return true;
            else if (Matrix[row, col] == '*') return true;
            else return false;
        }

        private static void ReturnPaths()
        {
            Console.WriteLine(string.Join("\n", Paths.OrderBy(p => p.Length).ToList()));
        }
    
        static void Main(string[] args)
        {
            EnterMatrix();
            Search(0, 0, 'S');
            ReturnPaths();
            Console.ReadKey();
        }
    }
}

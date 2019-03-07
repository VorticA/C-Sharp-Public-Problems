using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleSnake.GameObjects
{
    public class Wall
    {
        private int width;
        private int height;
        private const char wallSymbol = '\u25A0';

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public Wall(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            DrawWalls();
        }

        private void DrawWalls()
        {
            DrawTop();
            DrawBottom();
            DrawLeft();
            DrawRight();
        }

        private void DrawRight()
        {
            for (int yi=1; yi<this.height-1; yi++)
            {
                Point point = new Point(this.width - 1, yi);
                point.Draw(wallSymbol, ConsoleColor.Black);

            }
        }

        private void DrawLeft()
        {
            for (int yi=1; yi<this.height-1; yi++)
            {
                Point point = new Point(0, yi);
                point.Draw(wallSymbol, ConsoleColor.Black);
            }
        }

        private void DrawBottom()
        {
            for (int xi=0; xi<this.width; xi++)
            {
                Point point = new Point(xi, this.height-1);
                point.Draw(wallSymbol, ConsoleColor.Black);
            }
        }

        private void DrawTop()
        {
            for (int xi=0; xi<this.width; xi++)
            {
                Point point = new Point(xi, 0);
                point.Draw(wallSymbol, ConsoleColor.Black);
            }
        }
    }
}

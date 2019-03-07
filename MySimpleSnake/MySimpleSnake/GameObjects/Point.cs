using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleSnake.GameObjects
{
    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get => this.x;
            set
            {
                if (value < -1 || value > Console.WindowWidth) throw new ArgumentOutOfRangeException();
                this.x = value;
            }
        }
        public int Y
        {
            get => y;
            set
            {
                if (value < -1 || value > Console.WindowHeight) throw new ArgumentOutOfRangeException();
                this.y = value;
            }
        }

        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw(char symbol)
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(symbol);
        }
        public virtual void Draw(char symbol, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(symbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}

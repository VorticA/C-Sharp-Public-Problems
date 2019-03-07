using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleSnake.GameObjects
{
    public class Food : Point
    {
        private const char foodSymbol = '*';
        private Random random;
        private Wall wall;
        private LinkedList<Point> snakeNodes;
        private Stopwatch lifespan;

        public Stopwatch Lifespan { get => lifespan; set => lifespan = value; }

        public Food(Wall wall, LinkedList<Point> snakenodes)
        {
            this.Lifespan = new Stopwatch();
            this.Lifespan.Start();
            this.random = new Random();
            this.wall = wall;
            this.snakeNodes = snakenodes;
            GenerateRandomCoordinates();
            this.DrawFood();
            
        }


        private void GenerateRandomCoordinates()
        {
            bool isPointOfSnake;
            int x, y;
            do
            {
                x = this.GenerateRandomX();
                y = this.GenerateRandomY();
                isPointOfSnake = snakeNodes.Any(p => p.X == x && p.Y == y);
            }
            while (isPointOfSnake);
            base.X = x;
            base.Y = y;
        }

        private int GenerateRandomY()
        {
            return random.Next(2, wall.Height - 1);
        }

        private int GenerateRandomX()
        {
            return random.Next(2, wall.Width - 1);
        }

        private void DrawFood()
        {
            base.Draw(foodSymbol, ConsoleColor.Red);
        }
    }
}

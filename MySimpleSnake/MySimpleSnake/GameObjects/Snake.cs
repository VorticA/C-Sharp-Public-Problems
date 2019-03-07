using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleSnake.GameObjects
{
    public class Snake
    {
        private LinkedList<Point> snakeNodes;
        private Wall wall;
        private Point direction;
        private Food food;
        private Point nextPoint;
        private const char snakeSymbol = '\u25CF';
        private int score;
        private bool isMoving;

        public bool IsMoving { get => this.isMoving; set => this.isMoving = value; }
        public int Score { get => this.score; }

        public Snake(Wall wall)
        {
            this.IsMoving = true;
            this.wall = wall;
            snakeNodes = new LinkedList<Point>();
            SetUpSnake();
            this.direction = new Point(0, 0);
            this.food = new Food(wall, snakeNodes);
            TrackFoodLife();
        }

        public void StopFood()
        {
            this.food.Lifespan.Stop();
        }
        
        public void StartFood()
        {
            this.food.Lifespan.Start();
        }

        private void TrackFoodLife()
        {
            if (food.Lifespan.Elapsed.Seconds >= 8)
            {
                food.Draw(' ');
                this.food = new Food(wall, snakeNodes);
            }

        }

        private void SetUpSnake()
        {
            for (int xi = wall.Width/2-3; xi<wall.Width/2+3; xi++)
            {
                snakeNodes.AddLast(new Point(xi, wall.Height / 2));
                snakeNodes.Last.Value.Draw(snakeSymbol);
            }
        }

        public void AttemptMove(Point direction)
        {
            TrackFoodLife();
            this.direction = direction;
            GetNextPoint();
            if (IsFood()) EatAndMove();
            else if (IsSnake()) IsMoving = false;
            else JustMove();
        }

        private bool IsSnake()
        {
            return this.snakeNodes.Any(p => p.X == nextPoint.X && p.Y == nextPoint.Y);
        }

        private void JustMove()
        {
            this.snakeNodes.Last.Value.Draw(' ');
            this.snakeNodes.RemoveLast();
            this.snakeNodes.AddFirst(this.nextPoint);
            this.snakeNodes.First.Value.Draw(snakeSymbol);
        }

        private bool IsFood()
        {
            return food.X == nextPoint.X && food.Y == nextPoint.Y;
        }

        private void EatAndMove()
        {
            this.score++;
            this.snakeNodes.AddFirst(nextPoint);
            this.nextPoint.Draw(snakeSymbol);
            this.food = new Food(wall, snakeNodes);
        }

        private void GetNextPoint()
        {
            int nextx = snakeNodes.First.Value.X + direction.X;
            int nexty = snakeNodes.First.Value.Y + direction.Y;
            if (nextx < 1) nextx += this.wall.Width - 2;
            else if (nextx > this.wall.Width - 2) nextx = 1;
            if (nexty < 1) nexty += this.wall.Height - 2;
            else if (nexty > this.wall.Height - 2) nexty = 1;
            this.nextPoint = new Point(nextx, nexty);
        }

        public void ClearSnake()
        {
            foreach (Point node in snakeNodes)
                node.Draw(' ');
            food.Draw(' ');
        }
    }
}

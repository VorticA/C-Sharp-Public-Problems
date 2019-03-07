using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySimpleSnake.GameObjects;
using System.Diagnostics;

namespace MySimpleSnake.TheEngine
{
    class Engine
    {
        private Snake snake;
        private Point direction;
        private Wall wall;
        private int wWidth;
        private int wHeight;
        private double sleepTime;
        Stopwatch timer;

        public Engine(Snake snake, Wall wall)
        {
            this.snake = snake;
            this.wall = wall;
            this.direction = new Point(-1, 0);
            this.wWidth = wall.Width;
            this.wHeight = wall.Height;
        }

        public void Run()
        {
            this.sleepTime = 80;
            timer = new Stopwatch();
            timer.Start();
            while(snake.IsMoving)
            {
                
                if (Console.KeyAvailable)
                    GetNewDirection();
                snake.AttemptMove(direction);
                DisplayScore();
                if (sleepTime>10)
                    sleepTime -= 0.01;
                Thread.Sleep((int)sleepTime);
            }
            AskUserForRestart();
        }

        private void DisplayScore()
        {
            Console.SetCursorPosition(wall.Width + 2, 2);
            Console.Write("Score: " + snake.Score);
            Console.SetCursorPosition(wall.Width + 2, 4);
            Console.Write(String.Format("{0:00}:{1:00}:{2:00}", timer.Elapsed.Hours, timer.Elapsed.Minutes, timer.Elapsed.Seconds));
            Console.SetCursorPosition(wall.Width + 2, 6);
            Console.Write("Toggle spacebar to pause/unpause game. ");

        }

        private void AskUserForRestart()
        {
            Console.SetCursorPosition(wall.Width/2 - 11, 4);
            Console.Write("Uh oh, play again? y/n ");
            do
            {
                Console.SetCursorPosition(0, wall.Height);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Y) StartAgain();
                else if (key.Key == ConsoleKey.N) GameOver();
            }
            while (true);
        }

        private void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Game over!");
            Console.SetCursorPosition(0, 0);
            Environment.Exit(0);
        }

        private void StartAgain()
        {
            Console.Clear();
            this.wall = new Wall(this.wWidth, this.wHeight);
            this.snake = new Snake(this.wall);
            direction = new Point(-1, 0);
            this.Run();
        }

        private void GetNewDirection()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            if ((input.Key == ConsoleKey.UpArrow || input.Key==ConsoleKey.W) && direction.Y != 1) direction = new Point(0, -1);
            else if ((input.Key == ConsoleKey.DownArrow || input.Key == ConsoleKey.S) && direction.Y != -1) direction = new Point(0, 1);
            else if ((input.Key == ConsoleKey.LeftArrow || input.Key == ConsoleKey.A) && direction.X != 1) direction = new Point(-1, 0);
            else if ((input.Key == ConsoleKey.RightArrow || input.Key==ConsoleKey.D) && direction.X != -1) direction = new Point(1, 0);
            else if (input.Key == ConsoleKey.Spacebar) Pause();
        }

        private void Pause()
        {
            timer.Stop();
            snake.StopFood();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar) break;
            }
            timer.Start();
            snake.StartFood();
        }
    }
}

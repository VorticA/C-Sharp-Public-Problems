using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimpleSnake.TheEngine;
using MySimpleSnake.Utilities;
using MySimpleSnake.GameObjects;

namespace MySimpleSnake
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            ConsoleWindow.CustomizeConsole();
            Wall wall = new Wall(100, 40);
            Snake snake = new Snake(wall);
            Engine engine = new Engine(snake, wall);
            engine.Run();
        }
    }
}

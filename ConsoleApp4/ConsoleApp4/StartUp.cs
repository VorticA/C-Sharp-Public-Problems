using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers
{
    using Appenders;
    using ConsoleApp4.Binary.Engine;
    using global::Loggers.Appenders.Interfaces;
    using global::Loggers.Layouts.Interfaces;
    using global::Loggers.Loggers.Interfaces;
    using Layouts;
    using Loggers;
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}

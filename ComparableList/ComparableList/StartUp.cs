using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IBox<string> box = new Box<string>();
            IBoxCommandInterpreter<string> commandInterpreter = new StringCommandInterpreter(box);
            IEngine engine = new Engine<string>(commandInterpreter);
            engine.Run();
        }
    }
}

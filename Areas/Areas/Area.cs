using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    public class Area
    {
        public int CorHeight { get; set; }
        public int CorLength { get; set; }
        public int Size { get; set; }
        public Area(int height, int length)
        {
            this.CorHeight = height;
            this.CorLength = length;
        }
    }
}

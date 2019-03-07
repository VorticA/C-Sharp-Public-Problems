using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawable
{
    class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Draw()
        {
            Drawline(this.width, '*', '*');
            for (int i = 1; i < this.height-1; i++)
            {
                Drawline(this.width, ' ', '*');
            }
            Drawline(this.width, '*', '*');
        }

        private void Drawline(int width, char mid, char end)
        {
            Console.Write(end);
            for (int i = 1; i < width-1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
            Console.WriteLine();
        }
    }
}

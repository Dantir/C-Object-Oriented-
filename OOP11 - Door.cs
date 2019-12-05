using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    class Door
    {
        private string color;
        private int height, width;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }        public Door(string color, int height, int width)        {            this.color = color;            this.height = height;            this.width = width;        }
        public Door()
        {}

        public override string ToString()
        {
            return ("Color: " + color + " Height: " + height + " Width: " + width);
        }
    }
}

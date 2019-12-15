﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    struct Coordinates
    {
        private int x, y, z;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public override string ToString()
        {
            return ("X: " + x + " Y: " + y + " Z: " + z);
        }
    }
}
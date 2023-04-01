using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}


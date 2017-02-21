using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt
{
    class Snake
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int richtung { get; set; }
        public Snake(int maxx, int maxy)
        {
            x = maxx / 2 - 3;
            y = maxy / 2 - 3;
            richtung = 1;
        }
    }
}

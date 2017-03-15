using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point()
        {

        }

        public bool check_point(int snake_x, int snake_y)
        {
            if (snake_x == x & snake_y == y)
            {
                return false;
            }
            return false;
        }
    }
}

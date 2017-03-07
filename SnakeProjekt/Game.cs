using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt
{
    class Game
    {
        public Game()
        {

        }
        public bool get_dot(int headx,int heady,int pointx,int pointy)
        {
            if (headx == pointx && heady == pointy) return true;
            else return false;
        }
        public string move_snake(int richtung, int x, int y)
        {
            if (richtung==1) y = y + 8;
            else if (richtung==2 ) x = x - 8;
            else if (richtung==3) y = y - 8;
            else if (richtung==4) x = x + 8;
            
            string s = string.Format("{0}" + ";" + "{1}", x, y);
            return s;
        }
    }
}

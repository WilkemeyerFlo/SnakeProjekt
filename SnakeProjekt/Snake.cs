using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjekt
{
    class Snake
    {
        public int headx { get; set; }
        public int heady { get; set; }
        public int richtung { get; set; }
        public Snake(int maxx, int maxy)
        {
            int x,y;
            x = (maxx / 2) + 3;
            y = maxy / 2;
            richtung = 1;
            headx = x;
            heady = y;
        }
        public void move()
        {
            switch (richtung)
            {
                case '1':
                    heady = heady + 4;
                    break;
                case '2':
                    headx = headx - 4;
                    break;
                case '3':
                    heady = heady - 4;
                    break;
                case '4':
                    headx = headx + 4;
                    break;
            }
        }
    }
}

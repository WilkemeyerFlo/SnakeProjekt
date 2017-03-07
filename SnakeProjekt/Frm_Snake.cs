using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SnakeProjekt
{
    public partial class FrmSnake : Form
    {
        Graphics g;
        Snake Schlange;
        Point Punkt;
        Game Spiel;
        int last_x;
        int last_y;
        List<string> positions;
        public FrmSnake()
        {
            InitializeComponent();
            Schlange = new Snake(pb_main.Height, pb_main.Width);
            Punkt = new Point();
            Spiel = new Game();
            positions = new List<string>();
            string s = string.Format("{0}"+";"+"{1}", Schlange.headx,Schlange.heady);
            positions.Add(s);
            last_x = Schlange.headx;
            last_y = Schlange.heady;
        }
        public void CreateSnake()
        {
            g = pb_main.CreateGraphics();
            CreatePoint();
            foreach (string position in positions)
            {
                string[] data = position.Split(';');
                g.FillRectangle(Brushes.Black, Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), 8, 8);
            }
            g.FillRectangle(Brushes.Gray, last_x, last_y, 8, 8);

        }

        private void pb_main_Click(object sender, EventArgs e)
        {
            move();
        }

        public int Randomint(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        public void CreatePoint()
        {
            int rndx = Randomint(1,pb_main.Width);
            Thread.Sleep(Randomint(1,1000));
            int rndy = Randomint(1,pb_main.Height);
            g = pb_main.CreateGraphics();
            g.FillRectangle(Brushes.Pink, rndx-4, rndy-4, 8, 8);
            Punkt.x = rndx;
            Punkt.y = rndy;
        }

        private void Frm_Snake_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    Schlange.richtung = 1;
                    break;
                case 'a':
                    Schlange.richtung = 2;
                    break;
                case 's':
                    Schlange.richtung = 3;
                    break;
                case 'd':
                    Schlange.richtung = 4;
                    break;
            }
        }
        private void move()
        {
            string temp = Spiel.move_snake(Schlange.richtung, last_x, last_y);

            positions.Add(temp);
            string[] data = temp.Split(';');
            last_x = Convert.ToInt32(data[0]);
            last_y = Convert.ToInt32(data[1]);
            CreateSnake();
        }
    }
}

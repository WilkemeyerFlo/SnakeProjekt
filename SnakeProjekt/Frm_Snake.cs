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
        int last_list_remove_couter = 0;
        int count = 0;
        bool firsttime = true;
        public FrmSnake()
        {
            InitializeComponent();
            Schlange = new Snake(pb_main.Height, pb_main.Width);
            Punkt = new Point();
            Spiel = new Game();
            positions = new List<string>();
            last_x = Schlange.headx;
            last_y = Schlange.heady;
            string s = string.Format("{0}"+";"+"{1}"+":"+"{2}", Schlange.headx,Schlange.heady,count);
            positions.Add(s);
            count++;
            pb_main.BackColor = Color.White;
        }
        public void CreateSnake()
        {
            g = pb_main.CreateGraphics();
            string position = positions[count];
                string[] data = position.Split(':');
                string[] data2 = data[0].Split(';');
                g.FillRectangle(Brushes.Black, Convert.ToInt32(data2[0]), Convert.ToInt32(data2[1]), 8, 8);
        }

        public int Randomint(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        public void CreatePoint()
        {
            int rndx = Randomint(1, pb_main.Width);
            Thread.Sleep(Randomint(1, 1000));
            int rndy = Randomint(1, pb_main.Height);
            rndx = (rndx - (rndx % 8)) +1;
            rndy = (rndy - (rndy % 8)) -4;
            g = pb_main.CreateGraphics();
            g.FillRectangle(Brushes.Pink, rndx - 4, rndy - 4, 8, 8);
            Punkt.x = rndx;
            Punkt.y = rndy;
        }


        private void move()
        {
            string temp = Spiel.move_snake(Schlange.richtung, last_x, last_y, count);

            positions.Add(temp);
            string[] data = temp.Split(':');
            string[] data2 = data[0].Split(';');
            last_x = Convert.ToInt32(data2[0]);
            last_y = Convert.ToInt32(data2[1]);

            CreateSnake();
            bool got_point = Spiel.get_dot(Schlange.headx,Schlange.heady,Punkt.x,Punkt.y);
            count++;
            if (got_point == false)
            {
                string temp2 = positions[last_list_remove_couter];
                data = temp2.Split(':');
                data2 = data[0].Split(';');
                repaint(Convert.ToInt32(data2[0]),Convert.ToInt32(data2[1]));
                positions.Remove(Convert.ToString(last_list_remove_couter));
                last_list_remove_couter++;
            }
            else
            {
                
            }
        }

        private void pb_main_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    Schlange.richtung = 1;
                    break;
                case Keys.A:
                    Schlange.richtung = 2;
                    break;
                case Keys.S:
                    Schlange.richtung = 3;
                    break;
                case Keys.D:
                    Schlange.richtung = 4;
                    break;
            }
        }

        private void tim_timer_Tick(object sender, EventArgs e)
        {
            if (firsttime == true)
            {
                CreatePoint();
                firsttime = false;
            }
            move();
        }

        private void repaint(int x, int y)
        {
            g = pb_main.CreateGraphics();
            g.FillRectangle(Brushes.White, x, y, 8, 8);
        }
    }
}

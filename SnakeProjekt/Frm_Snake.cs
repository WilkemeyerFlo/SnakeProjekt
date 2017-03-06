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
        public FrmSnake()
        {
            InitializeComponent();
            Schlange = new Snake(pb_main.Height, pb_main.Width);
        }
        public void CreateSnake()
        {
            g = pb_main.CreateGraphics();
            g.FillRectangle(Brushes.Black, Schlange.x, Schlange.y, 10, 10);
        }

        private void pb_main_Click(object sender, EventArgs e)
        {
            CreateSnake();
            CreatePoint();
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
            g.FillRectangle(Brushes.Pink, rndx-4, rndy-4, 10, 10);
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
    }
}

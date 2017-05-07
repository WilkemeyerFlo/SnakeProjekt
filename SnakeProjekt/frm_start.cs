using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeProjekt
{
    public partial class frm_start : Form
    {
        public frm_start()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            FrmSnake add = new FrmSnake();
            this.Hide();
            add.ShowDialog();

        }
    }
}

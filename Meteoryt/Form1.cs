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

namespace Meteoryt
{
    public partial class Form1 : Form
    {
        public Rysuj rysuj = new Rysuj();
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void BtDane_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            class11.Invalidate();
            class11.Paint += new PaintEventHandler((e1, n) =>
            {
                Graphics gf = n.Graphics;

                rysuj.czysctlo(gf);
                rysuj.RysujTorMeteorytu(gf, n);
                rysuj.RysujStrefy(gf, n);
                rysuj.RysujMeteoryt(gf, n);
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

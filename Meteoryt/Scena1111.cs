using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;


namespace Meteoryt
{
    class Scena1111 : System.Windows.Forms.PictureBox
    {
        #region chujemuje

        static Color ColorMeteorytu = Color.FromArgb(255, 0, 0, 0);
        static Color ColorZiemi = Color.FromArgb(255, 0, 255, 0);
        static Color ColorMeteorytu1 = Color.FromArgb(255, 0, 0, 255);
        static Color ColorEgzosfera = Color.FromArgb(50, 255, 255, 0);

        SolidBrush BrusEgzosfera = new SolidBrush(ColorEgzosfera);
        SolidBrush BrusMeteorytu = new SolidBrush(ColorMeteorytu);
        SolidBrush BrusMeteorytu1 = new SolidBrush(ColorMeteorytu1);
        SolidBrush BrusZiemi = new SolidBrush(ColorZiemi);

        Pen PenMeteory = new Pen(Color.Red, 2);
        Pen PenTroposfery = new Pen(Color.Blue, 2);
        Pen PenStratosfer = new Pen(Color.Purple, 2);
        Pen PenMezosfer = new Pen(Color.Orange, 2);
        Pen PenTermosfera = new Pen(Color.Gray, 2);
        Pen PenEgzosfera = new Pen(Color.Green, 2);

        
        int p = 125;
        int r = 10;
        int x = 0;
        int y = 0;
        int x2 = 0;
        int y2 = 0;
        int x3 = 0;
        int y3 = 0;

        int szerokosc = 75 * 3;
        int DlugoscZiemi = 75;
        


        float[] dash = { 1, 1 };

        int DlugoscMeteorytu = 410;
        int SzerokoscMeteorytu = 695;
        int skalaX = 170;
        int skalaY = 200;
        int SzerokoscZiemi = 75;
        int DlugoscTroposfery = 150;
        int SzerokoscTroposfery = 150;
        int DlugoscMezosfery = 200;
        int SzerokoscMezosfery = 200;
        int DlugoscStratosfery = 250;
        int SzerokoscStratosfery = 250;
        int DlugoscTermosfery = 300;
        int SzerokoscTermosfery = 300;
        int DlugoscEgzosfery = 350;
        int SzerokoscEgzosfery = 350;

        #endregion


        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Scena
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Scena_Paint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }


        public Scena1111()
        {
            InitializeComponent();
        }

        public void RysujStrefy(PaintEventArgs n, Bitmap bmp)
        {
            #region init

            PenTroposfery.DashPattern = dash;
            PenStratosfer.DashPattern = dash;
            PenMezosfer.DashPattern = dash;
            PenTermosfera.DashPattern = dash;
            PenEgzosfera.DashPattern = dash;

            #endregion

            n.Graphics.FillEllipse(BrusZiemi, bmp.Width / 2 - szerokosc, bmp.Height / 2 - DlugoscZiemi / 2, DlugoscZiemi, SzerokoscZiemi);
            n.Graphics.DrawEllipse(PenTroposfery, bmp.Width / 2 - szerokosc - SzerokoscZiemi / 2, bmp.Height / 2 - DlugoscTroposfery / 2, DlugoscTroposfery, SzerokoscTroposfery);
            n.Graphics.DrawEllipse(PenMezosfer, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscMezosfery / 2, bmp.Height / 2 - DlugoscMezosfery / 2, DlugoscMezosfery, SzerokoscMezosfery);
            n.Graphics.DrawEllipse(PenStratosfer, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscStratosfery / 2, bmp.Height / 2 - DlugoscStratosfery / 2, SzerokoscStratosfery, SzerokoscStratosfery);
            n.Graphics.DrawEllipse(PenTermosfera, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscTermosfery / 2, bmp.Height / 2 - DlugoscTermosfery / 2, DlugoscTermosfery, SzerokoscTermosfery);
            n.Graphics.DrawEllipse(PenEgzosfera, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscEgzosfery / 2, bmp.Height / 2 - DlugoscEgzosfery / 2, DlugoscEgzosfery, SzerokoscEgzosfery);

        }

        /*public void RysujTorMeteorytu(PaintEventArgs n, Bitmap bmp)
        {
            PenMeteory.DashPattern = dash;
            n.Graphics.DrawEllipse(PenMeteory, bmp.Width / 2 - skalaX, bmp.Height / 2 - skalaY, SzerokoscMeteorytu, DlugoscMeteorytu);
            //gf.Flush();
        }*/

        public void RysujTorMeteorytu(PaintEventArgs n, Bitmap bmp)
        {
            PenMeteory.DashPattern = dash;
           // n.Graphics.DrawEllipse(PenMeteory, bmp.Width / 2 - skalaX, bmp.Height / 2 - skalaY, SzerokoscMeteorytu, DlugoscMeteorytu);
            double ddt = 0.1;
            Point a, b;
            int xp = bmp.Width / 2 + 450;
            int yp = bmp.Height / 2;
            x = Convert.ToInt32(xp );
            y = Convert.ToInt32(yp );
            a = new Point(x,y);
            for (double dt = 0; dt <= Math.PI * 2; dt+= 0.1)
            {
                b = new Point(x, y);
                x = Convert.ToInt32(xp + Math.Cos(-dt) * (p / (1 + 0.8 * Math.Cos(dt))));
                y = Convert.ToInt32(yp + Math.Sin(-dt) * (p / (1 + 0.8 * Math.Cos(dt))));
                
                n.Graphics.DrawLine(new Pen( Brushes.Black), a,b);
                a = b;
            }
            //gf.Flush();
        }

        public void RysujMeteoryt(PaintEventArgs n, Bitmap bmp)
        {
            int xp = bmp.Width / 2 + 450;
            int yp = bmp.Height / 2;
            float x1 = bmp.Width / 2 - szerokosc - DlugoscZiemi / 2;
            float y1 = bmp.Height / 2 - DlugoscZiemi / 2 - SzerokoscZiemi / 2;

            /* for (double dt = 0; dt < 20; dt += 0.0001)
             {*/
            x = Convert.ToInt32(xp + Math.Cos(-dt) * (p / (1 + 0.8 * Math.Cos(dt))));
            y = Convert.ToInt32(yp + Math.Sin(-dt) * (p / (1 + 0.8 * Math.Cos(dt))));
            
            double dl = Math.Sqrt(Math.Pow(x - r - x1, 2) + Math.Pow(y - r - y1, 2));
            
            if ( dl >= DlugoscEgzosfery / 2.0)
            {
                n.Graphics.FillEllipse(BrusMeteorytu, x - r, y - r, 2*r, 2*r);
            }
            else
            {
                x2 = x;
                y2 = y;
                x3 = Convert.ToInt32(x2 + 100 + Math.Cos(-dt) * (p / (1 + 0.6 * Math.Cos(-dt + Math.Atan(Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)))))));
                y3 = Convert.ToInt32(y2 + 30 + Math.Sin(-dt) * (p / (1 + 0.6 * Math.Cos(-dt + Math.Atan(Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)))))));
                n.Graphics.FillEllipse(BrusMeteorytu1, x3-r, y3-r,2* r, 2*r);
                 dl = Math.Sqrt(Math.Pow(x3 - r - x1, 2) + Math.Pow(y3 - r - y1, 2));
                Console.WriteLine(dl);
                if (dl <=  76)
                {
                    //break;
                    //throw new Exception("koniec");
                    frmMain.Koniec = true;
                    MessageBox.Show("kolizja");
                }
            }
            //}
            //gf.Flush();
        }

        private double dt = 0;
        public double Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        private void Scena_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                using (Bitmap bmp = new Bitmap(e.ClipRectangle.Width, e.ClipRectangle.Height))
                {
                    RysujStrefy(e, bmp);
                    e.Graphics.RotateTransform((float)frmSetup.Katrotacji);
                    RysujTorMeteorytu(e, bmp);
                    RysujMeteoryt(e, bmp);
                    e.Graphics.ResetTransform();
                }
            }
            finally
            {
                e.Dispose();
            }
        }
    }
    
}

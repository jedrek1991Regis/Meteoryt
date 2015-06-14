using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
namespace Meteoryt
{
    public class Rysuj
    {
        public Rysuj() { }

        public void czysctlo(Graphics gf)
        {
            gf.Clear(Color.White);
        }

        public void RysujStrefy(Graphics gf,PaintEventArgs n)
        {
            Bitmap bmp = new Bitmap(n.ClipRectangle.Width, n.ClipRectangle.Height);
            
            Color ColorZiemi = Color.FromArgb(255, 0, 255, 0);
            SolidBrush BrusZiemi = new SolidBrush(ColorZiemi);

            Color ColorTroposfera = Color.FromArgb(50, 255, 0, 0);
            SolidBrush BrusTroposfera = new SolidBrush(ColorTroposfera);

            Color ColorStratosfer = Color.FromArgb(50, 0, 255, 0);
            SolidBrush BrusStratosfer = new SolidBrush(ColorStratosfer);

            Color ColorMezosfer = Color.FromArgb(50, 0, 0, 255);
            SolidBrush BrusMezosfer = new SolidBrush(ColorMezosfer);

            Color ColorTermosfera = Color.FromArgb(50, 255, 0, 255);
            SolidBrush BrusTermosfera = new SolidBrush(ColorTermosfera);

            Color ColorEgzosfera = Color.FromArgb(50, 255, 255, 0);
            SolidBrush BrusEgzosfera = new SolidBrush(ColorEgzosfera);

            float[] dash = { 1, 1 };

            Pen PenTroposfery = new Pen(Color.Blue, 2);
            Pen PenStratosfer = new Pen(Color.Purple, 2);
            Pen PenMezosfer = new Pen(Color.Orange, 2);
            Pen PenTermosfera = new Pen(Color.Gray, 2);
            Pen PenEgzosfera = new Pen(Color.Green, 2);
            PenTroposfery.DashPattern = dash;
            PenStratosfer.DashPattern = dash;
            PenMezosfer.DashPattern = dash;
            PenTermosfera.DashPattern = dash;
            PenEgzosfera.DashPattern = dash;

            int szerokosc = 75*3;

            int DlugoscZiemi = 75;
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

            gf.FillEllipse(BrusZiemi, bmp.Width / 2 - szerokosc, bmp.Height / 2 - DlugoscZiemi / 2 , DlugoscZiemi, SzerokoscZiemi);
            gf.DrawEllipse(PenTroposfery, bmp.Width / 2 - szerokosc - SzerokoscZiemi / 2, bmp.Height / 2 - DlugoscTroposfery / 2, DlugoscTroposfery, SzerokoscTroposfery);
            gf.DrawEllipse(PenMezosfer, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscMezosfery / 2, bmp.Height / 2 - DlugoscMezosfery / 2, DlugoscMezosfery, SzerokoscMezosfery);
            gf.DrawEllipse(PenStratosfer, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscStratosfery / 2, bmp.Height / 2 - DlugoscStratosfery / 2, SzerokoscStratosfery, SzerokoscStratosfery);
            gf.DrawEllipse(PenTermosfera, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscTermosfery / 2, bmp.Height / 2 - DlugoscTermosfery / 2, DlugoscTermosfery, SzerokoscTermosfery);
            gf.DrawEllipse(PenEgzosfera, bmp.Width / 2 - szerokosc + SzerokoscZiemi / 2 - SzerokoscEgzosfery / 2, bmp.Height / 2 - DlugoscEgzosfery / 2, DlugoscEgzosfery, SzerokoscEgzosfery);

            gf.Flush();

        }

        public void RysujTorMeteorytu(Graphics gf, PaintEventArgs n)
        {
            Bitmap bmp = new Bitmap(n.ClipRectangle.Width, n.ClipRectangle.Height);

            float[] dash = { 1, 1 };
            Pen PenMeteory = new Pen(Color.Red, 2);
            PenMeteory.DashPattern = dash;

            Color ColorEgzosfera = Color.FromArgb(50, 255, 255, 0);
            SolidBrush BrusEgzosfera = new SolidBrush(ColorEgzosfera);

            int DlugoscMeteorytu = 410;
            int SzerokoscMeteorytu = 695;
            int skalaX = 170;
            int skalaY = 200;
            gf.DrawEllipse(PenMeteory, bmp.Width / 2 - skalaX, bmp.Height / 2 - skalaY, SzerokoscMeteorytu, DlugoscMeteorytu);
            gf.Flush();

        }

        public void RysujMeteoryt(Graphics gf, PaintEventArgs n)
        {
            Bitmap bmp = new Bitmap(n.ClipRectangle.Width, n.ClipRectangle.Height);

            Color ColorMeteorytu = Color.FromArgb(50, 0, 0, 0);
            SolidBrush BrusMeteorytu = new SolidBrush(ColorMeteorytu);

            Color ColorMeteorytu1 = Color.FromArgb(50, 0, 0, 255);
            SolidBrush BrusMeteorytu1 = new SolidBrush(ColorMeteorytu1);

            int xp = bmp.Width / 2 + 450;
            int yp = bmp.Height / 2 ;
            int p = 125;
            int r = 10;
            int x = 0;
            int y = 0;
            int x2 = 0;
            int y2 = 0;
            int x3 = 0;
            int y3 = 0;

            int szerokosc = 75*3;
            int DlugoscZiemi = 75;
            float x1 = bmp.Width / 2 - szerokosc;
            float y1 = bmp.Height / 2 - DlugoscZiemi / 2;

            for (double dt = 0; dt < 20; dt += 0.001)
            {
                if (Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)) >= 175)
                {
                    x = Convert.ToInt32(xp + Math.Cos(-dt) * (p / (1 + 0.8 * Math.Cos(dt))));
                    y = Convert.ToInt32(yp + Math.Sin(-dt) * (p / (1 + 0.8 * Math.Cos(dt))));
                    gf.FillEllipse(BrusMeteorytu, x, y, r, r);
                }
                else
                {
                    x2 = x;
                    y2 = y;
                    x = Convert.ToInt32(xp + Math.Cos(-dt) * (p / (1 + 0.8 * Math.Cos(-dt))));
                    y = Convert.ToInt32(yp + Math.Sin(-dt) * (p / (1 + 0.8 * Math.Cos(-dt))));
                    x3 = Convert.ToInt32(x2+100 + Math.Cos(-dt) * (p / (1 + 0.6 * Math.Cos(-dt + Math.Atan(Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)))))));
                    y3 = Convert.ToInt32(y2+30 + Math.Sin(-dt) * (p / (1 + 0.6 * Math.Cos(-dt + Math.Atan(Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2)))))));
                    gf.FillEllipse(BrusMeteorytu1, x3, y3, r, r);
                    if (Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)) >= 30)
                    {
                        break;
                    }
                }
            }
            gf.Flush();

        }
    }
}

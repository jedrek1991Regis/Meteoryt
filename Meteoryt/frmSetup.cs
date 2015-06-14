using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteoryt
{
    public partial class frmSetup : Form
    {
        private static double predkosc = 0;
        private static double masa = 0;
        private static double odleglosc = 0;
        private static double temperatura = 0;
        private static double x = 0;
        private static double y = 0;
        private static double p = 0.8;
        private static double katrotacji = 0;


        public static double Predkosc
        {
            get { return predkosc;}
            set { predkosc = value; }
        }
        public static double Masa
        {
            get { return masa; }
            set { masa = value; }
        }

        public static double Odleglosc
        {
            get { return odleglosc; }
            set { odleglosc = value; }
        }

        public static double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        
        public static double X
        {
            get { return x; }
            set { x = value; }
        }
        
        public static double Y
        {
            get { return y; }
            set { y = value; }
        }

        public static double P
        {
            get { return p; }
            set { p = value; }
        }


        public static double Katrotacji
        {
            get { return katrotacji; }
            set { katrotacji = value; }
        }     

        public frmSetup()
        {
            InitializeComponent();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            Predkosc = predkosc;
            Masa = masa;
            Temperatura = temperatura;
            P = p;
            Katrotacji = katrotacji;
            Odleglosc = odleglosc;
            X = x;
            Y = y;
            
            this.Close();
        }

        private void TbPredkosc_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbPredkosc.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }

        private void TbPredkosc_Validated(object sender, EventArgs e)
        {
            predkosc = Convert.ToDouble(TbPredkosc.Text);
        }

        private void TbTemperatura_Validated(object sender, EventArgs e)
        {
            temperatura = Convert.ToDouble(TbTemperatura.Text);
        }

        private void TbTemperatura_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbTemperatura.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }

        private void TbMasa_Validated(object sender, EventArgs e)
        {
            masa = Convert.ToDouble(TbMasa.Text);
        }

        private void TbMasa_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbMasa.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }

        private void TbOdleglosc_Validated(object sender, EventArgs e)
        {
            odleglosc = Convert.ToDouble(TbOdleglosc.Text);
        }

        private void TbOdleglosc_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbOdleglosc.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }

        private void TbX_Validated(object sender, EventArgs e)
        {
            x = Convert.ToDouble(TbX.Text);
        }

        private void TbX_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbX.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }

        private void TbY_Validated(object sender, EventArgs e)
        {
            y = Convert.ToDouble(TbY.Text);
        }

        private void TbY_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbY.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }

        private void TbWysokość_Validated(object sender, EventArgs e)
        {
            p = Convert.ToDouble(TbP.Text);
        }

        private void TbWysokość_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbP.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }
        

        private void TbKatrotacji_Validated(object sender, EventArgs e)
        {
            katrotacji = Convert.ToDouble(TbKatrotacji.Text);
        }

        private void TbKatrotacji_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Convert.ToDouble(TbKatrotacji.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
            }
        }
    }
}

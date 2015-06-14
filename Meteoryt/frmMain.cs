using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Meteoryt
{
    public partial class frmMain : Form
    {
        public Rysuj rysuj = new Rysuj();
        private double dt = DT_INIT;
        private const double DT_INIT = 0;
        private const double MAX_DT = Math.PI;
        private double ddt = Math.PI / 360;
        Thread animateThread = null;
        static internal Boolean Koniec
        {
            get;
            set;
        }
        public frmMain()
        {
            InitializeComponent();
                       

            //Creating Thread
           
        }

        private void createAnimationThread()
        {
            animateThread = new Thread(new ThreadStart(animate));
        }

        private void animate()
        {
            try
            {
                while (Koniec == false && dt < MAX_DT)
                {
                    lock (this)
                    {
                        this.Invoke(new MethodInvoker(delegate()
                                    {

                                        class11.Invalidate();
                                        class11.Dt = dt;
                                        dt += ddt;
                                    }
                            ));

                    }
                    Thread.Sleep(33);
                }
                lock (this)
                {
                    Console.WriteLine("koniec " + Thread.CurrentThread.Name);
                }
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }catch( Exception w ){
                Console.WriteLine("KONIEC ANIMACJI");
            }
        }

        private void BtDane_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSetup())
            {
                frm.ShowDialog();
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            if (animateThread != null && animateThread.IsAlive == true)
            {
                animateThread.Abort();
                while (animateThread.IsAlive) continue;
                animateThread = null;
            }  
            createAnimationThread();
            initAnimate();
            animateThread.Start();
        }

        private void initAnimate()
        {
            dt = DT_INIT;
            Koniec = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (animateThread == null) return;
            if (animateThread.IsAlive == true)
                animateThread.Abort();
            while (animateThread.IsAlive) ;
            animateThread = null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Meteoryt
{
    class TorLotu
    {
        internal Action interacja;

        public double Dt
        {
            get;
            set;
        }

        public double TimeElapsed
        {
            get;
            set;
        }

        public TorLotu(){
            ZebraneDane = new List<Dane>();
            Sfery = new List<CialoNiebieskie>();
        }

        public List<Dane> ZebraneDane{
            get;
            set;
        }

        public List<CialoNiebieskie> Sfery
        {
            get;
            set;
        }

        public Meteoryt Meteoryt
        {
            get;
            set;
        }

        public Ziemia Ziemia
        {
            get;
            set;
        }

        public double Temp
        {
            get;
            set;
        }

        public double Gestosc
        {
            get;
            set;
        }

        public double Predkosc
        {
            get;
            set;
        }

        public double Przysp
        {
            get;
            set;
        }



        //POJEDNYCZA ITERACJA (POJEDYNCZA !!!!) !!!!
        public void iteruj()
        {
            if (interacja != null)
                interacja();
        }

        //Generowanie elipsy
        public List<PointF> generujTorLotu(PointF a, PointF b, double R)
        {
            return null;
        }

        internal struct Dane{
           public PointF polozenie;
           public Double gestosc;
           public Double temp;
           public Double predkosc;
           public Double przyspieszenie;
           public Double timeElapsed;
        }

        //zapisuje pojedyncza dna typu Dane.
        public void saveSnap(){
            var dana = new Dane{ polozenie = new PointF( Meteoryt.SX, Meteoryt.SY ), gestosc = Gestosc, predkosc = Predkosc, przyspieszenie = Przysp, temp = Temp, timeElapsed = TimeElapsed };
            ZebraneDane.Add( dana );
        }

        public void setIteracjaTorNormal()
        {
            interacja = iteracjaTorNormal;
        }

        public void setIteracjaTorEgzoSfera()
        {
            interacja = iteracjaTorEgzoSfera;
        }

        public void iteracjaTorNormal()
        {
            //tor normal
        }

        public void iteracjaTorEgzoSfera()
        {
            //tor kozak
        }
    }
}

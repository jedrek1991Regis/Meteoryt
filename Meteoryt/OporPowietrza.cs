using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class OporPowietrza
    {
        private double gestosc_powietrza;
        private double pole_powierzchni;
        private double predkosc;
        private double Cx = 1;
        public OporPowietrza(double gestosc_powietrza, double pole_powierzchni, double predkosc, double Cx)
        {
            this.gestosc_powietrza = gestosc_powietrza;
            this.pole_powierzchni = pole_powierzchni;
            this.predkosc = predkosc;
            this.Cx = Cx;
        }

        public double LiczOporPowietrza()
        {
            double wynik = 0.5 * Cx * gestosc_powietrza * pole_powierzchni * predkosc;
            return wynik;
        }

        public double GetGestosc_powietrza
        {
            get { return gestosc_powietrza; }
            set { gestosc_powietrza = value; }
        }

        public double GetPole_powierzchni
        {
            get { return pole_powierzchni; }
            set { pole_powierzchni = value; }
        }

        public double GetCx
        {
            get { return Cx; }
            set { Cx = value; }
        }

        public double GetPredkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        } 
    }
}

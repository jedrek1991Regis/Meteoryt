using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class Atmosfera11km
    {
        private double temperatura = 288.15;
        private double cisnienie = 1013.25;
        private double gestosc = 1.2255;
        private double lepkosc_kinetycza = 1.466 * Math.Pow(10, -5);
        private double predkosc_dzieku = 340.3;

        public Atmosfera11km(double temperatura, double cisnienie, double gestosc, double predkosc_dzieku)
        {
            this.gestosc = gestosc;
            this.temperatura = temperatura;
            this.cisnienie = cisnienie;
            this.predkosc_dzieku = predkosc_dzieku;
        }

        public double Cisnienie(double wysokosc)
        {
            double wynik = cisnienie * (Math.Pow(1 - wysokosc / 44300, 5.256));
            return wynik;
        }

        public double Temperatura()
        {
            double wynik = temperatura + 6.5;
            return wynik;
        }

        public double Gestosc(double wysokosc)
        {
            double wynik = gestosc * (Math.Pow(1 - wysokosc / 44300, 4.256));
            return wynik;
        }

        public double Preskoscdzwieku()
        {
            double temp = Temperatura();
            double wynik = predkosc_dzieku * Math.Sqrt(temp / 288);
            return wynik;
        }

        public double GetTemperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public double GetCisnienie
        {
            get { return cisnienie; }
            set { cisnienie = value; }
        }

        public double GetGestosc
        {
            get { return gestosc; }
            set { gestosc = value; }
        }

        public double GetPredkosc
        {
            get { return predkosc_dzieku; }
            set { predkosc_dzieku = value; }
        }
        
    }
}

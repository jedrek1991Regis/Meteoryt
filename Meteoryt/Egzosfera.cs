using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class Egzosfera
    {
        private double temperatura = 1200;
        private double cisnienie = 0;
        private double gestosc;

        public Egzosfera(double gestosc, double temperatura, double cisnienie)
        {
            this.temperatura = temperatura;
            this.cisnienie = cisnienie;
            this.gestosc = gestosc;
        }

        public double Temperatura()
        {
            double wynik = temperatura - 0.01;
            return wynik;
        }

        public double Cisnieie()
        {
            double wynik = cisnienie;
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
    }
}

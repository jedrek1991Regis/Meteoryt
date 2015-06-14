using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class Troposfera
    {
        private double temperatura = -56.5;
        private double cisnienie = 200;
        private double gestosc;
        public Troposfera(double gestosc, double temperatura, double cisnienie)
        {
            this.temperatura = temperatura;
            this.cisnienie = cisnienie;
            this.gestosc = gestosc;
        }

        public double Temperatura()
        {
            double wynik = temperatura + 0.65;
            return wynik;
        }

        public double Cisnieie()
        {
            double wynik = cisnienie + 6.7;
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

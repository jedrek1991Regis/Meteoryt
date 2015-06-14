using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class Stratosfera
    {
        private double temperatura = 15;
        private double cisnienie = 0;
        private double gestosc;

        public Stratosfera(double gestosc, double temperatura, double cisnienie)
        {
            this.temperatura = temperatura;
            this.cisnienie = cisnienie;
            this.gestosc = gestosc;
        }

        public double Temperatura()
        {
            double wynik = temperatura + 2;
            return wynik;
        }

        public double Cisnieie()
        {
            double wynik = cisnienie + 5.7;
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

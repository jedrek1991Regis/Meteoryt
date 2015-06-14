using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class Termosfera : CialoNiebieskie
    {
        private double temperatura = 1000;
        private double cisnienie = 0;
        private double gestosc;

        public Termosfera(double gestosc, double temperatura, double cisnienie, float x, float y, float r) : base( x, y ,r )
        {
            this.temperatura = temperatura;
            this.cisnienie = cisnienie;
            this.gestosc = gestosc;
        }

        public double Temperatura()
        {
            double wynik = temperatura - 2.55;
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

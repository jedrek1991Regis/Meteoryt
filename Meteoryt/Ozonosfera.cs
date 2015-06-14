using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteoryt
{
    public class Ozonosfera: CialoNiebieskie
    {
        private double temperatura = -44.5;
        private double cisnienie = 131.43;
        private double gestosc = 0;

        public Ozonosfera(double gestosc, double temperatura, double cisnienie)
        {
            this.temperatura = temperatura;
            this.cisnienie = cisnienie;
            this.gestosc = gestosc;
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
    }
}

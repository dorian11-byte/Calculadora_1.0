using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.CLASES
{
    class clsPorcentaje
    {
        public double Porcentaje(double N1, double N2)
        {
            double p;
           p = (N1/100) * N2;
            return p;
        }
    }
}

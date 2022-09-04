using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2.Clases
{
    internal class cldivision
    {
        public cldivision(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;
        }
        public double N1 { get; set; }
        public double N2 { get; set; }

        public double dividir()
        {
            return N1 / N2;
        }
    }
}
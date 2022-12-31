using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;


        public static double DolarParaReal(double cot, double quant)
        {
            double total = quant * cot;
            return total + total * iof / 100.0;
        }

    }
}

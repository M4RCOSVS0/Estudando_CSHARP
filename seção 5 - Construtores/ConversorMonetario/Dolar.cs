using ConversorMonetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMonetario
{
    internal class Dolar
    {
        public static double Conversor(double cot, double quati)
        {
            return (cot * quati * 1.06)/100;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolar
{
    internal class Dolar
    {
        public static double Conversor(double cot,double quati)
        {
            return (cot * quati * 1.06)/10;
        }
    }
}

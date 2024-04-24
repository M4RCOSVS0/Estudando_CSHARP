using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemaexemplo
{
    internal class Triangulo
    {
        public double A; //nome de atributo sempre maiusculo
        public double B;
        public double C;

        public double Area(){ //Começa com letra maiúscula
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p*(p - A) * (p - B) * (p - C));
        }
    }
}

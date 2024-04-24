using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3._0
{
    internal class Aluno
    {
        public double N1, N2, N3;
        public string Nome;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public string Situacao()
        {
            double Situacao = NotaFinal();
            if (Situacao >= 60) 
            {
                return "APROVADO";
            }
            else
            {
                double faltou =  60 - Situacao ;
                return $"REPROVADO\nFALTARAM {faltou.ToString("F2",CultureInfo.InvariantCulture)} PONTOS";
            }
        }

    
    }
}

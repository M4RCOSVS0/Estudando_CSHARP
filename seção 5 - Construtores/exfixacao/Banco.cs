using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exfixacao
{
    internal class Banco
    {
        public int NumConta {  get; private set; }
        public string Nome {  get; private set; }
        public double Saldo { get; set; }

        public Banco(int numConta, string nome, double saldo)
        {
            NumConta = numConta;
            Nome = nome;
            Saldo = saldo;
        }

        public Banco(int numConta, string nome)
        {
            NumConta = numConta;
            Nome = nome;
        }

        public void AdcionarSaldo(double saldo)
        {
            Saldo += saldo;
        }

        public void RetirarSaldo(double saldo)
        {
            Saldo -= saldo + 5;
        }

        public override string ToString()
        {
            return $"Contas {NumConta}, Titular {Nome}, Saldo: {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
        }

    }
}

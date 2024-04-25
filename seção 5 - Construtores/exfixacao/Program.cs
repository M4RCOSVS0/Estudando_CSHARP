using System.Runtime.Intrinsics.Arm;

namespace exfixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco b;
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n) ");
            string condi = Console.ReadLine();
            if (condi == "s")
            {
                Console.Write("Entre com o valor de depósito: ");
                double saldo = double.Parse(Console.ReadLine());
                b = new Banco(num, titular, saldo);
            }
            else
            {
                b = new Banco(num, titular);
            }
            Console.WriteLine("Dados da conta:\n"+b);

            Console.Write("Entre com um valor para depósito: ");
            double s = double.Parse(Console.ReadLine());
            b.AdcionarSaldo(s);
            Console.WriteLine("Dados da conta atualizados:\n"+b);
            Console.Write("Entre com um valor para saque: ");
            s = double.Parse(Console.ReadLine());
            b.RetirarSaldo(s);
            Console.WriteLine("Dados da conta atualizados:\n" + b);

        }
    }
}

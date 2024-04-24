using System.Drawing;
using System.Globalization;

namespace ConversorMonetario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine());
            Console.WriteLine(value: $"Valor em ser pago em reais = {Dolar.Conversor(dolar, quantidade).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}

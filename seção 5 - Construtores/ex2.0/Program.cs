using System.Globalization;

namespace ex2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcioário: {f.Nome}, $ {f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double pct = double.Parse(Console.ReadLine());
            f.AumentarSalario(pct);
            Console.WriteLine($"Dados atualizados: {f.Nome}, $ {f.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}

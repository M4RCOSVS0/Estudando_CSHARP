namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionário:");
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo Funcionário:");
            Console.WriteLine("Nome:");
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine());
            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"Salário médio = {media.ToString("F2")}");

        }
    }
}

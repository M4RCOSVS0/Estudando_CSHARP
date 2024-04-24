using System.Globalization;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.Write($"\nDados do Produto: {p}\n");

            Console.Write("Digite o número de produtos que deseja adcionar");
            int qte = int.Parse(Console.ReadLine());
            p.AdcionarProdutos(qte);

            Console.Write("Digite o número de produtos que remover adcionar");
            int rmv = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rmv);
            
            Console.Write($"\nDados atualizados {p}");

        }
    }
}

﻿using System.Globalization;

namespace Construtor01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto p = new Produto("TV",500.00,10);

            p.Nome = "TV 4k";
            p.Preco = 1000;
            Console.WriteLine(p.ToString());

            /*Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500.0,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */
        }
    }
}




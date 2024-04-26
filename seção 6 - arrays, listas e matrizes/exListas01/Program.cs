using exListas01;
using System;
using System.Collections.Generic;

namespace ExListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> list = new List<Empregados>();
            Console.Write("Quantos empregados você irá registrar? ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Empregado{i + 1}");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Salário:");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Empregados(id, nome, salario));
            }

            Console.Write("Entre com o ID do empregado que terá aumento de salário: ");
            int idAumento = int.Parse(Console.ReadLine());
            Empregados empregado = list.Find(emp => emp.Id == idAumento);
            if (empregado != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                empregado.EncrementarSalario(porcentagem);
                Console.WriteLine("Aumento aplicado com sucesso!");
            }
            else
            {
                Console.WriteLine("Empregado não encontrado.");
            }

            Console.WriteLine("Lista de empregados atualizada:");
            foreach (var emp in list)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
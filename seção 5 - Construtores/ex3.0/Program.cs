﻿using System.Globalization;

namespace ex3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}\n{a.Situacao()}");
        }
    }
}

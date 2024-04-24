using System;
using System.Globalization;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char sexo = 'F';
            char letra = '\u0041';
            sbyte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147486482L;
            float n5 = 4.554545f;
            double n6 = 4.5;
            string nome = "Maria Grenn";
            object obj1 = "Alec Brown";
            double obj2 = 4.5545f;
            
            int m1 = int.MinValue;
            int m2 = int.MaxValue;
            sbyte m3 = sbyte.MinValue;
            decimal m4 = decimal.MaxValue;



            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(n6);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2.ToString("F2"));

            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(sexo);
            Console.WriteLine(nome);
        }
    }
}
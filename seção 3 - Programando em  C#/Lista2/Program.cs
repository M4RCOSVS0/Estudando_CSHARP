using System.Globalization;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * EX1
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.Write("NEGATIVO");
            }
            * EX2
            
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.Write("IMPAR");
            }
            
            *EX3
            
            string[] valores = Console.ReadLine().Split(' ');
            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);
    
            if(n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }

            *EX4
            
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            
            *EX5

             
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);
            double tot = 0;

            switch (codigo)
            {
                case 1:
                    tot = qtd * 4.00;
                    break;
                case 2:
                    tot = qtd * 4.50;
                    break;
                case 3:
                    tot = qtd * 5.00;
                    break;
                case 4:
                    tot = qtd * 2.00;
                    break;
                case 5:
                    tot = qtd * 1.50;
                    break;
                default:
                    Console.WriteLine("ERRADO");
                    break;
            }

            Console.WriteLine($"Total: R$ {tot:F2}");
            
            double number = double.Parse(Console.ReadLine());
            if (number >=  0 && number <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (number <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (number <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }else if (number <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            
            *EX7

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q1");                 
                }
                else
                {
                    Console.WriteLine("Q4");
                }
            }
            else if(x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }
            else
            {
                Console.WriteLine("Origem");
            }
            
            */
            double number = double.Parse(Console.ReadLine());
            if (number < 2000)
            {
                Console.WriteLine("Isento");
            }
            else if(number < 3000)
            {
                number -= 2000;
                Console.Write($"R$ {(number*0.08):F2}");
            }
            else if (number < 4500)
            {
                number -= 3000;
                
                Console.WriteLine($"R$ {(1000 * 0.08 + number * 0.18):F2}");
            }
            else
            {
                number -= 4500;
                Console.WriteLine($"R$ {(1000 * 0.08 + 1500 * 0.18 + number * 0.28):F2}");
            }

        }

    }
}

namespace Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ex1
            bool b = true;
            while (b)
            {
                int senha = int.Parse(Console.ReadLine());
                if (senha != 2002)
                {
                    Console.WriteLine("Senha Iválida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    b = false;
                }
            }
            
            *ex2
            bool b = true;
            while (b)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else
                    {
                        Console.WriteLine("terceiro");
                    }
                }
            }
            */
            bool b = true;
            int a = 0,g = 0,d = 0;
            while (b)
            {
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        a++;
                        break;
                    case 2:
                        g++;
                        break;
                    case 3:
                        d++;
                        break;
                    case 4:
                        b = false;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {a}\nGasolina: {g}\r\nDiesel: {d}");

        }
    }
}

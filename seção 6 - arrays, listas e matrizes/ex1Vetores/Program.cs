namespace ex1Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos vai ter? ");
            int n = int.Parse(Console.ReadLine());
            Hotel[] h = new Hotel[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Clinte #" + (i + 1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                h[quarto] = new Hotel(name, email);
            }
            Console.WriteLine("Quartos Alugados:");
            for (int i = 0; i < 10; i++)
            {
                if (h[i] != null)
                {
                    Console.WriteLine($"{i}: {h[i].ToString()}");
                }
                else
                {
                    continue;
                }
                
            }
            
        }
    }
}


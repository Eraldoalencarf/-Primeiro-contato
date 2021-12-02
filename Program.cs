using System;

namespace Cap6
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Quantos quartos serao alugados?");
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel: [{i + 1}]");
                Console.WriteLine("Qual nome do cliente?");
                string name = Console.ReadLine();
                Console.WriteLine("Qual email do cliente?");
                string email = Console.ReadLine();
                Console.WriteLine("Qual quarto o cliente deseja?");
                int nDoQuarto = int.Parse(Console.ReadLine());
                vet[nDoQuarto] = new Product(name, email);
            }
            Console.WriteLine("Quartos Ocupados:");
            for(int i = 0;i < 11; i++)
            {
                if (vet[i] != null)
                Console.WriteLine($"[{i}] {vet[i]}");
            }

        }
    }
}
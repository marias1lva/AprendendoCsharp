using System;
using System.Globalization;
using System.Numerics;

namespace Pensao {
    class Program {
        static void Main(string[] args) {

            Hospede[] vet = new Hospede[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Hospede(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if (vet[i] != null) {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}

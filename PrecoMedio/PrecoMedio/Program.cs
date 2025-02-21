using System;
using System.Globalization;

namespace PrecoMedio {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];
            for (int i = 0; i < n; i++) {
                Console.Write("Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: R$");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine();
            Console.Write("Preço médio = R$" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
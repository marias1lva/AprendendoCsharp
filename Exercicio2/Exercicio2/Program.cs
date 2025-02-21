
using System;
using System.Globalization;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            
            Console.WriteLine("Entre com seu nome completo: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            string firstName = vet1[0];
            string lastName = vet1[1];
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura(mesma linha): ");
            string[] vet2 = Console.ReadLine().Split(' ');
            string lastName2 = vet2[0];
            int idade = int.Parse(vet2[1]);
            double altura = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Informações: ");
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

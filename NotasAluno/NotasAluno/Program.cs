using System;
using System.Globalization;

namespace NotasAluno {
    class Program {
        static void Main(String[] args) {

            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.NotaFinal() >= 60.00) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - a.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
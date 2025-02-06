using System;
using System.Globalization;

namespace SalarioFuncionario {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: R$");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: R$");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Funcionário: " + f);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + f);
        }
    }
}
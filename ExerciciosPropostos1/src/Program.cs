using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ExerciciosPropostos1 {
    class Program {
        static void Main(string[] args) {

            /* EXERCÍCIO 1:
            Console.WriteLine("Informe um valor para N1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um valor para N2: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("SOMA DE " + n1 + " + " + n2 + " = " + soma);*/

            /* EXERCÍCIO 2:
            Console.WriteLine("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = (double)(3.14159 * Math.Pow(raio, 2));
            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));*/

            /* EXERCÍCIO 3:
            Console.WriteLine("Informe 4 valores inteiros: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int diferenca = (A * B - C * D);
            Console.WriteLine("DIFERENÇA = " + diferenca);*/

            /* EXERCÍCIO 4:
            Console.WriteLine("Informe o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valorHora;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("NÚMERO DO FUNCIONÁRIO: " + numero);
            Console.WriteLine("SALÁRIO = R$" + salario.ToString("F2", CultureInfo.InvariantCulture));*/

            /* EXERCÍCIO 5:
            Console.WriteLine("Informe o código da peça 1, a quantidade e o valor unitário: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Informe o código da peça 2, a quantidade e o valor unitário: ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(peca1[0]);
            int quantidade1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            double total1 = quantidade1 * valor1;
            double total2 = quantidade2 * valor2;
            double total = total1 + total2;
            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));*/

            /*EXERCÍCIO 6:
            Console.WriteLine("Informe um valor para A:");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe um valor para B: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe um valor para C: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaTriangulo = (A * C) / 2;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = B * B;
            double areaRetangulo = A * B;
            Console.WriteLine("TRIÂNGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));*/
        }
    }
}
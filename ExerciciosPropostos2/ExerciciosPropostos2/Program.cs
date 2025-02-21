using System;
using System.Formats.Asn1;
using System.Globalization;

namespace ExerciciosPropostos2 {
    class Program {
        static void Main(string[] args) {

            /* EXERCÍCIO 1:
            int num;
            Console.WriteLine("Insira um valor inteiro para num: ");
            num = int.Parse(Console.ReadLine());
            if(num >= 0) {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }*/

            /* EXERCÍCIO 2:
            int num;
            Console.WriteLine("Insira um valor inteiro para num: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }*/

            /* EXERCÍCIO 3:
            int A, B;
            Console.WriteLine("Insira um valor inteiro para A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor inteiro para B: ");
            B = int.Parse(Console.ReadLine());
            if(A % B == 0 || B % A == 0) {
                Console.WriteLine("São múltiplos");
            }
            else {
                Console.WriteLine("Não são múltiplos");
            }*/

            /* EXERCÍCIO 4: 
            int horaInicial, horaFinal, duracao;
            Console.WriteLine("Informe a hora inicial do jogo: ");
            horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a hora final do jogo: ");
            horaFinal = int.Parse(Console.ReadLine());
            if(horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");*/

            /* EXERCÍCIO 5:
            int cod, qtd;
            double total = 0.0;
            Console.WriteLine("Informe o código do produto: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto: ");
            qtd = int.Parse(Console.ReadLine());
            if(cod == 1) {
                total = qtd * 4.0;
            }else if(cod == 2) {
                total = qtd * 4.5;
            }else if(cod == 3) {
                total = qtd * 5.0;
            }else if(cod == 4) {
                total = qtd * 2.0;
            }else if(cod == 5) {
                total = qtd * 1.5;
            }
            else {
                Console.WriteLine("Digite um código de 1 a 5.");
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));*/

            /* EXERCÍCIO 6:
            double valor;
            Console.WriteLine("Informe um valor: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor >= 0 && valor <= 25) {
                Console.WriteLine("Intervalo [0, 25]");
            } else if (valor > 25 && valor <= 50) {
                Console.WriteLine("Intervalo (25, 50]");
            } else if (valor > 50 && valor <= 75) {
                Console.WriteLine("Intervalo (50, 75]");
            } else if (valor > 75 && valor <= 100) {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else {
                Console.WriteLine("Fora do intervalo");
            }*/

            /* EXERCÍCIO 7:
            Console.WriteLine("Informe as coordenadas x e y do ponto para saber em que quadrante está: ");
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X"); 
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }*/

            /* EXERCÍCIO 8:
            double salario, imposto = 0.0;
            Console.WriteLine("Informe o salário: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (salario <= 2000.00) {
                Console.WriteLine("Isento");
            }else {
                if (salario > 2000.00 && salario <= 3000.00) {
                    imposto += (salario - 2000.00) * 0.08;
                }
                else if (salario > 3000.00 && salario <= 4500.00) {
                    imposto += (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);
                }
                else {
                    imposto += (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
                }
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }*/
        }
    }
}
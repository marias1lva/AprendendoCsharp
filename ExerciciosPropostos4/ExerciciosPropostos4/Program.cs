using System;
using System.Globalization;

namespace ExerciciosPropostos4 {
    class Program {
        static void Main(string[] args) {

            /* EXERCÍCIO 1:
            Console.Write("Até que número inteiro você quer ir? (Intervalo de 1 até 1000) ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Impares de 1 até " + X + ":");

            for (int i = 0; i < X; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }*/

            /* EXERCÍCIO 2:
            int N, X, dentro = 0, fora = 0;
            Console.Write("Insira um valor N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira " + N + " valores: ");
            for(int i = 0; i < N; i++) {
                X = int.Parse(Console.ReadLine());
                if(X >= 10 && X <= 20) {
                    dentro++;
                }else {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");*/

            /* EXERCÍCIO 3: 
            int N;
            double valor1, valor2, valor3, media;
            Console.Write("Quantos casos de teste você vai fazer? ");
            N = int.Parse(Console.ReadLine());
            for(int i =0; i < N; i++) {
                Console.WriteLine("Insira 3 valores: ");
                string[] valores = Console.ReadLine().Split(' ');
                valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
                Console.WriteLine("Média ponderada: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }*/

            /* EXERCÍCIO 4:
            int N;
            double N1, N2, divisao;
            Console.Write("Quantos casos de teste você vai fazer? ");
            N = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < N; i++) {
                Console.WriteLine("Insira 2 valores: ");
                string[] valores = Console.ReadLine().Split(' ');
                N1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                N2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                if (N2 == 0) {
                    Console.WriteLine("Divisão impossível");
                }
                else {
                    divisao = N1 / N2;
                    Console.WriteLine("Divisão: " + divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }*/

            /* EXERCÍCIO 5:
            int N, fatorial = 1;
            Console.Write("Digite um número inteiro para ser calculado o fatorial: ");
            N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++) {
                fatorial = fatorial * i;
            }
            Console.WriteLine("Fatorial: " + fatorial);*/

            /* EXERCÍCIO 6:
            int N;
            Console.Write("Digite um número inteiro para saber seus divisores: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                if (N % i == 0) {
                    Console.WriteLine(i);
                }
            }*/

            /* EXERCÍCIO 7: 
            int N;
            Console.Write("Digite um número inteiro: ");
            N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++) {
                Console.WriteLine(i + " " + i * i + " " + i * i * i);
            }*/
        }
    }
}
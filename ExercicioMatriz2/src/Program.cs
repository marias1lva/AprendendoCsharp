using System;
using System.Xml.Linq;

namespace ExercicioMatriz2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Preencha a matriz com " + m * n + " valores: ");

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] valores = Console.ReadLine().Split(' '); //Console.ReadLine(): lê uma linha inteira digitada pelo usuário, .Split(' '): separa os valores digitados com base nos espaços em branco, armazenando-os no array valores(cada número será um elemento do array).
                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(valores[j]); //int.Parse(valores[j]): converte o valor da string para inteiro, matriz[i, j]: recebe o valor correspondente da entrada
                }
            }

            Console.WriteLine();
            Console.Write("Digite um número da matriz: ");

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] == x) {
                        Console.WriteLine();
                        Console.WriteLine("Posição: " + i + "," + j);
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Cima: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Baixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
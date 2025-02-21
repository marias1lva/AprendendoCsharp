using System;

namespace ExercicioMatriz {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            Console.WriteLine("Preencha a matriz: ");
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    mat[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            int negativos = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        negativos++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + negativos);
        }
    }
}
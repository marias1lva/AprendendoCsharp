using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 3]; //primeiro linhas e depois colunas: 2 = linhas, 3 = colunas

            Console.WriteLine(mat.Length); //quantidade de elementos
            Console.WriteLine(mat.Rank); //quantidade de dimensões 
            Console.WriteLine(mat.GetLength(0)); //quantidade de elementos na dimensão 0 (linhas da matriz)
            Console.WriteLine(mat.GetLength(1)); //quantidade de elementos na dimensão 1 (colunas da matriz)
        }
    }
}
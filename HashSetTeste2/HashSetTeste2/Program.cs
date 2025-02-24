using System;
using System.Collections.Generic;
using HashSetTeste2.Entities;

namespace HashSetTeste2 {
    class Program {
        static void Main(string[] args) {

            // Cria um HashSet de produtos. HashSet armazena elementos únicos e não mantém ordem
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0)); // Adiciona um produto "TV" com preço de 900.0
            a.Add(new Product("Notebook", 1200.0)); // Adiciona um produto "Notebook" com preço de 1200.0

            // Cria um HashSet de pontos. HashSet armazena elementos únicos e não mantém ordem
            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4)); // Adiciona um ponto (3, 4)
            b.Add(new Point(5, 10)); // Adiciona um ponto (5, 10)

            // Verifica se um produto com os mesmos valores já existe no HashSet.
            Product prod = new Product("Notebook", 1200.0); // Cria um novo objeto Product com os mesmos dados
            Console.WriteLine(a.Contains(prod)); // Verifica se 'prod' está contido no HashSet 'a'

            // Verifica se um ponto com as mesmas coordenadas já existe no HashSet
            Point point = new Point(5, 10); // Cria um novo ponto com as mesmas coordenadas de um ponto já adicionado
            Console.WriteLine(b.Contains(point)); // Verifica se 'point' está contido no HashSet 'b'
        }
    }
}
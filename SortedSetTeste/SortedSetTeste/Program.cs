using System;
using System.Collections.Generic;

namespace SortedSetTeste {
    class Program {
        static void Main(string[] args) {

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // PrintCollection(a); // 0 2 4 6 8 10

            // Union
            SortedSet<int> c = new SortedSet<int>(a); // Cria um novo conjunto 'c' copiando os elementos de 'a'
            c.UnionWith(b); // Adiciona todos os elementos de 'b' em 'c', evitando duplicatas
            Console.WriteLine("UNION: ");
            PrintCollection(c); // 0 2 4 5 6 7 8 9 10 (todos os elementos de 'a' e 'b' sem repetições)

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a); // Cria um novo conjunto 'd' copiando os elementos de 'a'
            d.IntersectWith(b); // Mantém em 'd' apenas os elementos que também estão em 'b'
            Console.WriteLine();
            Console.WriteLine("INTERSECTION: ");
            PrintCollection(d); // 6 8 10 (elementos comuns em ambos os conjuntos)

            // Difference
            SortedSet<int> e = new SortedSet<int>(a); // Cria um novo conjunto 'e' copiando os elementos de 'a'
            e.ExceptWith(b); // Remove de 'e' todos os elementos que também existem em 'b'
            Console.WriteLine();
            Console.WriteLine("DIFFERENCE: ");
            PrintCollection(e); // 0 2 4 (elementos de 'a' que não estão em 'b')
        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using PredicateRemovendoProdutos.Entities;

namespace PredicateRemovendoProdutos {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*list.RemoveAll(p => p.Price >= 100.00);
            foreach (Product p in list) {
                Console.WriteLine(p);
            }*/

            // Remove todos os produtos da lista que satisfazem a condição do método ProductTest
            list.RemoveAll(ProductTest); // Remove produtos com preço >= 100.00
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
        }

        // Método usado como predicate para o método RemoveAll
        public static bool ProductTest(Product p) {
            return p.Price >= 100.0; // Retorna true se o preço for maior ou igual a 100, removendo o produto
        }
    }
}

// Um predicate é uma função que retorna verdadeiro ou falso com base em uma condição
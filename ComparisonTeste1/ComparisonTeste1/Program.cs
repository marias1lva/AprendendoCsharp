using System;
using System.Collections.Generic;
using ComparisonTeste1.Entities;

namespace ComparisonTeste1 {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>(); // Cria uma lista de objetos do tipo Product

            // Adiciona três peodutos diferentes  à lista, cada um com um nome e preço
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // 1- list.Sort();
            // 2- list.Sort(CompareProducts);
            /* 3- Comparison<Product> comp = CompareProducts;
                  list.Sort(comp);
             */
            // 4- Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());


            // 5- Ordena a lista de produtos pelo nome, em ordem alfabética (case-insensitive)
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            // Itera sobre cada produto na lista ordenada e imprime sua representação em string
            foreach (Product p in list) {
                Console.WriteLine(p); // Chama o método ToString() de Product automaticamente
            }
        }
        /* static int CompareProducts(Product p1, Product p2) {
                return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        */
    }
}
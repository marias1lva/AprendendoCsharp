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

            /* 1- Utiliza o método UpdatePrice como parâmetro para ForEach
            list.ForEach(UpdatePrice);
            foreach (Product p in list) {
                Console.WriteLine(p);
            }*/

            /* 2- Cria um delegate do tipo Action<Product> e passa UpdatePrice
            Action<Product> act = UpdatePrice;
            list.ForEach(act);
            foreach (Product p in list) {
                Console.WriteLine(p);
            }*/

            /* 3- Utiliza uma expressão lambda diretamente como delegate Action<Product>
            Action<Product> act = p => { p.Price += p.Price * 0.1; };
            list.ForEach(act);
            foreach (Product p in list) {
                Console.WriteLine(p);
            }*/

            // 4- Passa diretamente uma expressão lambda dentro do ForEach (sem variável intermediária)
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }
    }
}


using System;
using System.Linq;
using System.Collections.Generic;
using ProdutosECategoria.Entities;

namespace ProdutosECategoria {
    class Program {

        static void Print<T>(string message, IEnumerable<T> collection) { // Método genérico para imprimir coleções de qualquer tipo T
            Console.WriteLine(message);
            foreach (T obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {

            // Cria categorias para os produtos
            Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category { Id = 3, Name = "Eletronics", Tier = 1 };

            // Cria a lista de produtos e associa às categorias
            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0); // Vou pegar todo produto p tal que p.Category.Tier seja igual a 1 e p.Price seja menor que 900.0
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); // Vou pegar todo produto p tal que p.Category.Name seja igual a "Tools"
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); // Vou pegar todo produto p tal que p.Name[0](primeiro caracter) seja igual a 'C'
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); // Vou pegar todo produto p tal que p.Category.Tier seja igual a 1, ordenar por p.Price e depois por p.Name
            Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

            var r5 = r4.Skip(2).Take(4); // Vou pular 2 elementos e pegar os 4 seguintes
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

            var r6 = products.First(); // Vou pegar o primeiro elemento
            Console.WriteLine("First test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault(); // Vou pegar o primeiro elemento tal que p.Price seja maior que 3000.0
            Console.WriteLine("First or default test2: " + r7); // Se não existir nenhum elemento que satisfaça a condição, ele vai retornar null
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); // Vou pegar o único elemento tal que p.Id seja igual a 3 (usar quando tiver certeza que só vai retornar um ou nenhum elemento)
            Console.WriteLine("Single or default test1: " + r8); // Se não existir nenhum elemento que satisfaça a condição, ele vai retornar null

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault(); // Vou pegar o único elemento tal que p.Id seja igual a 30 (usar quando tiver certeza que só vai retornar um ou nenhum elemento)
            Console.WriteLine("Single or default test2: " + r9); // Se não existir nenhum elemento que satisfaça a condição, ele vai retornar null
            Console.WriteLine();

            var r10 = products.Max(p => p.Price); // Vou pegar o maior preço
            Console.WriteLine("Max price: $" + r10);

            var r11 = products.Min(p => p.Price); // Vou pegar o menor preço
            Console.WriteLine("Min price: $" + r11);
            Console.WriteLine();

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price); // Vou pegar a soma dos preços dos produtos cuja categoria seja igual a 1
            Console.WriteLine("Category 1 Sum prices: $" + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price); // Vou pegar a média dos preços dos produtos cuja categoria seja igual a 1
            Console.WriteLine("Category 1 Average prices: $" + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Vou pegar a média dos preços dos produtos cuja categoria seja igual a 5, se não existir nenhum elemento, ele vai retornar 0.0
            Console.WriteLine("Category 5 Average prices: $" + r14);
            Console.WriteLine();

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); // Soma personalizada usando Aggregate
            Console.WriteLine("Category 1 aggregate sum: $" + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category); // Vou agrupar os produtos por categoria
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group) {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        } 
    }
}
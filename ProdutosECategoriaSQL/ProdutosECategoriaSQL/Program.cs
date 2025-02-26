﻿// CÓDIGO DE PRODUTOS E CATEGORIAS USANDO LINQ E NOTAÇÃO SIMILAR À SQL

using System;
using System.Linq;
using System.Collections.Generic;
using ProdutosECategoriaSQL.Entities;

namespace ProdutosECategoriaSQL {
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

            // Vou pegar todo produto p tal que p.Category.Tier seja igual a 1 e p.Price seja menor que 900.0
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);

            // Vou pegar todo produto p tal que p.Category.Name seja igual a "Tools"
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2);

            // Vou pegar todo produto p tal que p.Name[0](primeiro caracter) seja igual a 'C'
            var r3 = 
                from p in products
                where p.Name[0] == 'C'
                select new {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", r3);

            // Vou pegar todo produto p tal que p.Category.Tier seja igual a 1, ordenar por p.Price e depois por p.Name
            var r4 = 
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

            // Vou pular 2 elementos e pegar os 4 seguintes
            var r5 =
                (from p in r4
                 select p)
                 .Skip(2)
                 .Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);

            // Vou pegar o primeiro elemento
            var r6 = (from p in products select p).First();
            Console.WriteLine("First test1: " + r6);

            // Vou pegar o primeiro elemento tal que p.Price seja maior que 3000.0
            var r7 = 
                (from p in products
                where p.Price > 3000.0
                select p).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7); // Se não existir nenhum elemento que satisfaça a condição, ele vai retornar null
            Console.WriteLine();

            // Vou agrupar os produtos por categoria
            var r16 =
                from p in products
                group p by p.Category;
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
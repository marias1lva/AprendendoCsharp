using System;
using System.Collections.Generic;
using System.Linq;
using FuncGerandoNovaLista.Entities;

namespace PredicateRemovendoProdutos {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*1- Utiliza um método separado (NameUpper) no Select
            List<string> result = list.Select(NameUpper).ToList();
            foreach(string s in result) {
                Console.WriteLine(s);
            }*/

            /*2- Cria um delegate Func<Product, string> e passa NameUpper
            Func<Product, string> func = NameUpper;
            List<string> result = list.Select(func).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }*/

            /*3- Utiliza uma expressão lambda diretamente como delegate Func<Product, string>
            Func<Product, string> func = p => p.Name.ToUpper();
            List<string> result = list.Select(func).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }*/

            //4- Passa diretamente uma expressão lambda dentro do Select (sem variável intermediária)
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result) {
                Console.WriteLine(s);
            }

        }

        /* Método usado em 1 e 2: recebe um objeto Product como parâmetro e retorna o nome do produto convertido para maiúsculas
            static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }*/

    }
}
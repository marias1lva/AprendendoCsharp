using System;
using System.Globalization;

namespace ProdutoEmEstoque {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: R$");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); //recebe um valor de entrada e adiciona esse valor à quantidade em estoque
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser retirado do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); //recebe um valor de entrada e remove esse valor da quantidade em estoque
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
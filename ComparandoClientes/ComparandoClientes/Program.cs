using System;
using ComparandoClientes.Entities;

namespace ComparandoClientes {
    class Program {
        static void Main(string[] args) {

            // Criação de dois objetos da classe Client, com diferentes nomes e e-mails.
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            // Verifica se os objetos a e b são considerados iguais usando o método Equals.
            Console.WriteLine(a.Equals(b)); // Retorna true se os e-mails forem iguais, false caso contrário.

            // Compara se os objetos a e b referenciam o mesmo espaço de memória.
            Console.WriteLine(a == b); // Como == não foi sobrescrito, verifica a igualdade de referência. Deve retornar false.

            // Exibe o código hash de a, gerado a partir do e-mail.
            Console.WriteLine(a.GetHashCode()); // Deve ser o mesmo se o e-mail for igual, pois o hash é baseado no e-mail.

            // Exibe o código hash de b, gerado a partir do e-mail.
            Console.WriteLine(b.GetHashCode()); // Igual ao anterior se o e-mail for o mesmo, diferente caso contrário.
        }
    }
}


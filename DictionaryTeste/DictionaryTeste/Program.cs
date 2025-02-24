using System;
using System.Collections.Generic;

namespace DictionaryTeste {
    class Program {
        static void Main(string[] args) {

            //Cria um Dictionary chamado 'cookies' que armazena pares de chave-valor (string, string)
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // Adiciona ou atualiza pares de chave-valor no Dictionary
            cookies["user"] = "maria"; // Adiciona a chave 'user' com o valor 'maria'
            cookies["email"] = "maria@gmail.com"; // Adiciona a chave 'email' com o valor 'maria@gmail.com'
            cookies["phone"] = "99771122"; // Adiciona a chave 'phone' com o valor '99771122'
            cookies["phone"] = "99771133"; // Atualiza o valor da chave 'phone' para '99771133', o valor será sobrescrito 
            Console.WriteLine(cookies["email"]); // Acessa e exibe o valor associado à chave 'email'
            cookies.Remove("email"); // Remove o par com a chave 'email' do Dictionary
            Console.WriteLine("Phone number: " + cookies["phone"]); // Acessa e exibe o valor atualizado associado à chave 'phone'

            // Verifica se a chave 'email' ainda existe no Dictionary
            if (cookies.ContainsKey("email")) { // Retorna false, pois a chave foi removida 
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else {
                Console.WriteLine("There is not 'email' key"); // Imprime: There is not 'email' key
            }

            // Exibe o número de elementos presentes no Dictionary
            Console.WriteLine("Size: " + cookies.Count); // Imprime: 2 (pois 'email' foi removido)

            // Exibe todas as chaves e valores presentes no Dictionary
            Console.WriteLine("ALL COOKIES:"); 
            foreach (KeyValuePair<string, string> item in cookies) { // Itera sobre cada par chave-valor
                Console.WriteLine(item.Key + ": " + item.Value); // Exibe a chave e o valor associados
            }
        }
    }
}
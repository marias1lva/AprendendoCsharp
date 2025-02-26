using System;
using System.Linq;

namespace LINQTeste {
    class Program {
        static void Main(string[] args) {

            // Especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Definir a query (consulta)
            var result = numbers
                .Where(x => x % 2 == 0) // Vou pegar na minha coleção numbers todo número x tal que x % 2 seja igual a 0
                .Select(x => x * 10); // Vou pegar o número x e multiplicar por 10

            // Executar a query (consulta)
            foreach (int x in result) {
                Console.WriteLine(x); // 20, 40: peguei apenas os números pares (2,4) e multipliquei por 10
            }
        }
    }
}
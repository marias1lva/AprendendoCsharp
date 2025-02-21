using System;

namespace Triplicar {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            Calculadora.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
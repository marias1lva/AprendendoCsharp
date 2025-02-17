using System;

namespace Triplicar2 {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int triple;
            Calculadora.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
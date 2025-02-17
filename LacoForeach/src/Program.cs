using System;

namespace LacoForeach {
    class Program {
        static void Main() {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            Console.WriteLine("Sem foreach: ");
            for (int i = 0; i < vect.Length; i ++){
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Com foreach: ");
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
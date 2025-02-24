using System;
using System.Collections.Generic;

namespace HashSetTeste {
    class Program {
        static void Main(string[] args) {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); // True
            Console.WriteLine(set.Contains("Computer")); // False

            foreach (string p in set) {
                Console.WriteLine(p); // TV, Notebook, Tablet
            }
        }
    }
}

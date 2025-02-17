using System;
using System.Collections.Generic;

namespace Listas {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco"); //lembrando que começa do 0

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); //eu quero o objeto x tal que x na posição 0 seja igual a 'A'
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------");
            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
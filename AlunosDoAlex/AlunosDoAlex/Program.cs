using System;

namespace AlunosDoAlex {
    class Program {
        static void Main(string[] args) {

            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student code: ");
            for (int i = 0; i < nA; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.WriteLine();
            Console.Write("How many students for course B? ");
            int nB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student code: ");
            for (int i = 0; i < nB; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.WriteLine();
            Console.Write("How many students for course C? ");
            int nC = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student code: ");
            for (int i = 0; i < nC; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
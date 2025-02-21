using System;

namespace FuncoesParaString {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper(); // Converte a string original para maiúscula
            string s2 = original.ToLower(); // Converte a string original para minúscula
            string s3 = original.Trim(); // Remove os espaços em branco no início e no final da string

            int n1 = original.IndexOf("bc"); // Retorna a posição da primeira ocorrência da string "bc"
            int n2 = original.LastIndexOf("bc"); // Retorna a posição da última ocorrência da string "bc"

            string s4 = original.Substring(3); // Retorna a substring a partir da posição 3
            string s5 = original.Substring(3, 5); // Retorna a substring a partir da posição 3 com 5 caracteres
            string s6 = original.Replace('a', 'x'); // Substitui todas as ocorrências do caractere 'a' pelo caractere 'x'
            string s7 = original.Replace("abc", "xy"); // Substitui todas as ocorrências da string "abc" pela string "xy"

            bool b1 = String.IsNullOrEmpty(original); // Verifica se a string é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); // Verifica se a string é nula, vazia ou contém apenas espaços em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine();
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace(\"abc\", \"xy\"): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
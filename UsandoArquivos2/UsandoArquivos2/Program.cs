using System;
using System.IO;

namespace UsandoArquivos2 {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;
            try {
                sr = File.OpenText(path); // Abre o arquivo no caminho especificado para leitura de texto.
                while (!sr.EndOfStream) { // Enquanto não chegar ao fim do arquivo, continua lendo linha por linha.
                    string line = sr.ReadLine(); // Lê uma linha do arquivo e armazena na variável 'line'.
                    Console.WriteLine(line);
                }               
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null) sr.Close();
            }
        }
    }
}
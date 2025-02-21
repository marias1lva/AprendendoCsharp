using System;
using System.IO;

namespace UsandoArquivos {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // Copia o conteúdo do file1 para o file2
                string[] lines = File.ReadAllLines(sourcePath); // Lê todas as linhas do file1 e armazena em um vetor de strings
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
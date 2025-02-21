using System;
using System.IO;

namespace UsandoArquivos4 {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath); // Lê todas as linhas do arquivo de origem e armazena em um array de strings
                using (StreamWriter sw = File.AppendText(targetPath)) { // Abre o arquivo de destino em modo de adição (append). Se não existir, cria o arquivo
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper()); // Escreve a linha convertida para letras maiúsculas no arquivo de destino
                    }
                } // O bloco 'using' garante que o StreamWriter será fechado automaticamente após o uso
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
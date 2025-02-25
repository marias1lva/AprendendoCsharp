using System;

public class ProcessFile {
    public static void Main() {
        string s1 = "Good morning dear students!"; // Cria uma string com uma mensagem

        // Chama o método de extensão Cut() para cortar a string até 10 caracteres
        Console.WriteLine(s1.Cut(10)); // O método retorna os primeiros 10 caracteres da string, adicionando "..." no final
        // Saída esperada: "Good morni..."
    }
}
using System;

public class ProcessFile {
    public static void Main() {

        // Cria um objeto DateTime representando a data e hora específicas: 26 de novembro de 2018, 08:10:45
        DateTime dt = new DateTime(2018, 11, 26, 8, 10, 45);

        // Chama o método de extensão ElapsedTime() para calcular o tempo decorrido desde a data especificada até o momento atual
        Console.WriteLine(dt.ElapsedTime()); // Imprime o tempo decorrido em horas ou dias
    }
}
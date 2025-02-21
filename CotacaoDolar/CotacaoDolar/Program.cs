using System;
using System.Globalization;

namespace CotacaoDolar {
    class Program {
        static void Main(string[] args) {
            double dolarCotado, quantosDolares, valorEmReais;
            Console.Write("Qaul é a cotação do dólar? ");
            dolarCotado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            quantosDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorEmReais = ConversorDeMoeda.DolarParaReal(quantosDolares, dolarCotado);
            Console.WriteLine("Valor a ser pago em reais = R$" + valorEmReais.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
﻿using System;
using System.Globalization;

namespace CircunferenciaEVolume3 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi);
        }
    }
}
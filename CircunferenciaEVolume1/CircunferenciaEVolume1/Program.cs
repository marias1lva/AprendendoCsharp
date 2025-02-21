using System;
using System.Globalization;

namespace CircunferenciaEVolume1 {
    class Program {

        static double Pi = 3.14;    
        static void Main(string[] args) {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi);
        }

        static double Circunferencia(double r) { // r = raio que a função recebe como entrada
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
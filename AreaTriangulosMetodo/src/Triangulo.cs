using System;

namespace AreaTriangulosMetodo {
    class Triangulo {
        public double A;
        public double B;
        public double C;

        //método para calcular a área do triângulo
        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

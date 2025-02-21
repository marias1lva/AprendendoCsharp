namespace CircunferenciaEVolume2 {
    class Calculadora {
        public double Pi = 3.14;

        public double Circunferencia(double r) { // r = raio que a função recebe como entrada
            return 2.0 * Pi * r;
        }

        public double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}

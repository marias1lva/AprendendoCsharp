using System;
using System.Globalization;

namespace ContaBancaria {
    class ContaBancaria {
        //numero = private set, não pode ser mudado
        //nome = public set, pode ser mudado
        //saldo = private set, não pode ser mudado
        //taxa de R$5.00 para saque
        //o saldo pode ficar negativo
        public string Titular;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= valor + 5.0;
        }

        public override string ToString() {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

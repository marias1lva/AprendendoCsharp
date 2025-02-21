using System;

namespace WorkerSalary.Entities {
    class HourContract { // Classe que representa um contrato por hora de um trabalhador.
        public DateTime Date { get; set; } // Data do contrato
        public double ValuePerHour { get; set; } // Valor pago por hora trabalhada
        public int Hours { get; set; } // Quantidade de horas trabalhadas no contrato
        public HourContract() { // Construtor padrão (sem parâmetros)
        }

        // Construtor que recebe os valores do contrato e inicializa os atributos
        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Método que calcula o valor total do contrato
        public double TotalValue() {
            return Hours * ValuePerHour;
        }
    }
}

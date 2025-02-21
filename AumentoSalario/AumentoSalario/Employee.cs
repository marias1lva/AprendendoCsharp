using System.Globalization;

namespace AumentoSalario {
    class Employee {
        // Propriedades do funcionário
        public int Id { get; set; }  // Identificador único do funcionário
        public string Name { get; set; }  // Nome do funcionário

        // Propriedade Salary (Salário) com encapsulamento - somente leitura pública
        public double Salary { get; private set; }

        // Construtor da classe Employee, responsável por inicializar os atributos
        public Employee(int id, string name, double salary) {
            Id = id;       // Atribui o ID passado ao atributo Id
            Name = name;   // Atribui o Nome passado ao atributo Name
            Salary = salary; // Atribui o Salário passado ao atributo Salary
        }

        // Método para aumentar o salário com base em uma porcentagem informada
        public void IncreaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0; // Calcula o novo salário com base na porcentagem
        }

        public override string ToString() {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

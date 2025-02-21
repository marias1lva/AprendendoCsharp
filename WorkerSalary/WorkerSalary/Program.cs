using System;
using System.Globalization;
using WorkerSalary.Entities;
using WorkerSalary.Entities.Enums;

namespace WorkerSalary {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // Converte para a enumeração WorkerLevel.
            Console.Write("Base salary: $");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Department dept = new Department(deptName); // Cria um objeto da classe Department com o nome informado.
            Worker worker = new Worker(name, level, baseSalary, dept); // Cria um objeto da classe Worker com os dados fornecidos.

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine()); // Converte para DateTime.
                Console.Write("Value per hour: $");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours); // Cria um novo objeto HourContract com os dados fornecidos.

                worker.AddContract(contract); // Adiciona o contrato à lista de contratos do trabalhador.
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            // Obtém o mês e o ano a partir da string digitada pelo usuário.
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
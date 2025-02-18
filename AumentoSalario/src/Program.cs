using System;
using System.Globalization;
using System.Collections.Generic;

namespace AumentoSalario {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many exployees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            // Criação de uma lista para armazenar os objetos do tipo Employee
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Cria um novo objeto Employee e adiciona à lista
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            // Busca o funcionário na lista usando uma expressão lambda
            Employee emp = list.Find(x => x.Id == searchId);

            // Verifica se o funcionário foi encontrado
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Chama o método que aumenta o salário do funcionário
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");

            // Percorre a lista e imprime os dados dos funcionários atualizados
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
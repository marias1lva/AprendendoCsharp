using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ExercicioDeFixacaoLINQ.Entities;


namespace ExercicioDeFixacaoLINQ {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("Enter salary: $");
                double salaryValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var emails = list.Where(e => e.Salary > salaryValue).OrderBy(e => e.Email).Select(e => e.Email);
                Console.WriteLine("Email of people whose salary is more than $" + salaryValue.ToString("F2", CultureInfo.InvariantCulture) + ":");
                foreach (string email in emails) {
                    Console.WriteLine(email);
                }

                var sum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': $" + sum);
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
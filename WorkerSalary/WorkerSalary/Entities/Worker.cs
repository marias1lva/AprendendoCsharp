using System;
using System.Collections.Generic;
using WorkerSalary.Entities.Enums;

namespace WorkerSalary.Entities {
    class Worker { // Classe que representa um trabalhador da empresa.
        public string Name { get; set; } // Nome do trabalhador.
        public WorkerLevel Level { get; set; } // Nível do trabalhador (Junior, MidLevel ou Senior).
        public double BaseSalary { get; set; } // Salário base do trabalhador, sem contar os contratos adicionais.
        public Department Department { get; set; } // Departamento ao qual o trabalhador pertence.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Lista de contratos por hora associados ao trabalhador.

        public Worker() { // Construtor padrão (sem parâmetros).
        }
        
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) { // Construtor que recebe os dados do trabalhador e inicializa os atributos.
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            // A lista de contratos já foi inicializada com uma instância vazia, então não precisa ser atribuída aqui.
        }

        // Método para adicionar um contrato à lista de contratos do trabalhador.
        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        // Método para remover um contrato da lista de contratos do trabalhador.
        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        // Método que calcula o ganho do trabalhador em um determinado mês e ano.
        public double Income(int year, int month) {
            double sum = BaseSalary; // Começa com o salário base.
            foreach (HourContract contract in Contracts) { // Percorre a lista de contratos.
                // Se o contrato for do mês e ano solicitados, soma o valor do contrato ao ganho total.
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum; // Retorna a soma total da renda do trabalhador no período especificado.
        }
    }
}

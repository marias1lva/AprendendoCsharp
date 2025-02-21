namespace WorkerSalary.Entities {
    class Department { // Classe que representa um departamento dentro da empresa.
        public string Name { get; set; } // Propriedade para armazenar o nome do departamento.
        public Department() { // Construtor padrão (sem parâmetros).
        }
        public Department(string name) { // Construtor que recebe um nome e inicializa a propriedade Name.
            Name = name;
        }
    }
}

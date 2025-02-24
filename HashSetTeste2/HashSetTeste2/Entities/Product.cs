namespace HashSetTeste2.Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}

// A classe 'Product' não sobrescreve ps métodos 'Equals()' e 'GetHashCode()', por isso, mesmo que dois objetos tenham os mesmos dados, eles
// são considerados diferentes, pois a comparação padrão em classes é feita por referência de memória. 
// Para funcionar corretamente no 'HashSet', seria necessário sobrescrever os métodos comparando os valores das propriedades 'Name' e 'Price'.
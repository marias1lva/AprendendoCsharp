namespace HashSetTeste2.Entities {
    struct Point {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y) : this() {
            X = x;
            Y = y;
        }
    }
}

// 'Point' é uma struct e, por padrão, structs em C# já implementam 'Equals()' e 'GetHashCode()' automaticamente, comparando os valores de seus campos.
// Por isso, no 'HashSet', dois objetos 'Point' com os mesmos valores de 'X' e 'Y' são considerados iguais.
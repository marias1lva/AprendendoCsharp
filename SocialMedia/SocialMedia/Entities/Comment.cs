namespace SocialMedia.Entities {
    class Comment {
        public string Text { get; set; } // Propriedade que armazena o texto do comentário
        public Comment() { // Construtor padrão sem argumentos
        }
        public Comment(string text) { // Construtor que inicializa a propriedade 'Text' com um valor passado como argumento
            Text = text;
        }
    }
}

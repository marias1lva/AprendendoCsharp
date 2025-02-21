using System;
using System.Text;
using System.Collections.Generic;

namespace SocialMedia.Entities {
    class Post {
        public DateTime Moment { get; set; } // Data e hora da postagem
        public string Title { get; set; } // Título da postagem
        public string Content { get; set; } // Conteúdo da postagem
        public int Likes { get; set; } // Número de curtidas da postagem
        public List<Comment> Comments { get; set; } = new List<Comment>(); // Lista de comentários da postagem

        public Post() { // Construtor padrão sem argumentos
        }

        public Post(DateTime moment, string title, string content, int likes) { // Construtor parametrizado que inicializa todas as propriedades
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) { // Método que adiciona um comentário à lista de comentários
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) { // Método que remove um comentário da lista de comentários
            Comments.Remove(comment);
        }

        public override string ToString() { // Sobrescrita do método ToString para formatar a saída do objeto Post
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title); // Adiciona o título da postagem
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss")); // Formata a data e hora da postagem
            sb.AppendLine(Content); // Adiciona o conteúdo da postagem
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments) { // Adiciona todos os comentários à saída formatada
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}

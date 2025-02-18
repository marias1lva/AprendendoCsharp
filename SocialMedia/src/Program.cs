using System;
using SocialMedia.Entities;

namespace SocialMedia {
    class Program {
        static void Main(string[] args) {

            // Cria dois comentários 
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            // Cria um post com data e hora, título, conteúdo e número de curtidas
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), // Moment
                "Traveling to New Zealand", // Title
                "I'm going to visit this wonderful country!", // Content
                12 // Likes
            );

            // Adiciona os comentários ao post
            p1.AddComment(c1);
            p1.AddComment(c2);

            // Cria mais dois comentários
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            // Cria outro post com data e hora, título, conteúdo e número de curtidas
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys",
                    "See you tomorrow",
                    5);

            // Adiciona os comentários ao post
            p2.AddComment(c3);
            p2.AddComment(c4);

            // Imprime os posts (chamando o método ToString de Post)
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
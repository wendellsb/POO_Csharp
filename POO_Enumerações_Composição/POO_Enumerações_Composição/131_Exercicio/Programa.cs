using POO_Enumerações_Composição._131_Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Enumerações_Composição._131_Exercicio
{
    public class Programa
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visiit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/08/2018 23:14:44"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine();
        }
    }
}
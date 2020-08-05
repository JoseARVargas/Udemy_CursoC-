using Cap9_Exercicio_02_StringBuilder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_Exercicio_02_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that´s awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:54:45"),
                "Travelling to New Zealand",
                "I´m going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1.ToString());
        }
    }
}

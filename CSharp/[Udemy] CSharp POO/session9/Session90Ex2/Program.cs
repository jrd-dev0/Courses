using Session90Ex2.Entities;

namespace Session90Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Parse("21/06/2018 13:05:44");
            string title = "Traveling to New Zealand";
            string content = "I'm going to visit this wonderful country!";
            int likes = 12;
            Post post1 = new Post(moment, title, content, likes);
            post1.AddComment(new Comment("Have a nice trip"));
            post1.AddComment(new Comment("Wow that's awesome!"));

            moment = DateTime.Parse("28/07/2018 23:14:19");
            title = "Good night guys";
            content = "See you tomorrow";
            likes = 5;
            Post post2 = new Post(moment, title, content, likes);
            post2.AddComment(new Comment("Good Night"));
            post2.AddComment(new Comment("May the force be with you"));

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
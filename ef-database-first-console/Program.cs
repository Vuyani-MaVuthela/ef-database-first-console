using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_database_first_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDbEntities1();
            var post = new Post()
            { Body = "Body", DatePublished = DateTime.Now, Title = "Title", PostID = 1 };
            context.Posts.Add(post);
            context.SaveChanges();
            Console.WriteLine("saved!");
            Console.ReadKey();
        }
    }
}

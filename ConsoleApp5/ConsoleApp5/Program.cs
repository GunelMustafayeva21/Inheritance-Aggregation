using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Comment c1 = new Comment("Interesting", "21.03.2022");
            Comment c2 = new Comment("Boring", "22.03.2022");
            
            //Shows that post1  has two comments such as comment1 and comment2
            //And shows text of first comment of post1
            Post p1 = new Post("First Lesson", "20.03.2022", 400, 300);
            p1.comment = new Comment[] { c1, c2 };
            Console.WriteLine(p1.comment[0].Text);

            Post p2 = new Post("Second Lesson", "19.03.2022", 350, 250);

            //Shows that user1 and user2 have different posts
            //And shows text of post of user2
            User user1 = new User("Kate", "Brown", "kate.brown@gmail.com", "10.10.1995", "single");
            user1.post =new Post[] { p1};

            User user2 = new User("John", "Rivera", "john.rivera@gmail.com", "08.12.1994", "single");
            user2.post=new Post[] { p2 };
            Console.WriteLine(user2.post[0].Text);

            //Shows that comments have  users
            //And shows users name for comment3 and comment4
            Comment c3=new Comment("c# programming","19.03.2022");
            c3.user = user1;
            Console.WriteLine(c3.user.name);

            Comment c4 = new Comment("object oriented programming", "20.03.2022");
            c4.user = user2;
            Console.WriteLine(c4.user.name);
        }
    }
}

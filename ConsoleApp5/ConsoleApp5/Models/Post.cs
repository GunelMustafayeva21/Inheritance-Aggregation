using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Post
    {
        public string Text;
        public string SharedDate;
        public int LikeCount;
        public int CommentCount;
        public Comment[] comment;

        

        public Post(string Text, string SharedDate, int LikeCount, int CommentCount)
        {
            this.Text = Text;
            this.SharedDate = SharedDate;
            this.LikeCount = LikeCount;
            this.CommentCount = CommentCount;
        }
    }
}

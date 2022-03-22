using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Comment
    {
        public string Text;
        public string CommentedDate;
        public User user;
        public Comment(){

        }
        public Comment(string Text, string CommentedDate)
        {
            this.Text = Text;
            this.CommentedDate = CommentedDate;
        }
    }

    
}

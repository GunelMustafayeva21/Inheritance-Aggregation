using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class User
    {
        public string name;
        public string surname;
        public string email;
        public string dateOfBirth;
        public string isSingle;
        public Post[] post;
        
        public User()
        {
            
        }
        public User(string name, string surname):this()
        {
            this.name = name;
            this.surname = surname;
        }
        public User(string name, string surname, string email, string dateOfBirth, string isSingle):this(name, surname)
        {
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.isSingle = isSingle;
        }
    }
}

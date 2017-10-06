using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public User(string UserName, string Password, string Name, string Surname, string Mail, string Telephone)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.Mail = Mail;
            this.Telephone = Telephone;
        }
    }
}

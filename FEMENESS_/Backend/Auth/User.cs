using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace FEMENESS_.Backend
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}

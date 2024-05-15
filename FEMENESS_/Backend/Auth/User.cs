using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace FEMENESS_.Backend
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber{ get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            PhoneNumber = null;
            Address = null;

        }

        public void UpdateUserDetails(string newUsername, string newEmail, string newPhoneNumber, string newAddress)
        {
            if (!string.IsNullOrEmpty(newUsername))
            {
                Username = newUsername;
            }

            if (!string.IsNullOrEmpty(newEmail))
            {
                Email = newEmail;
            }

            if (!string.IsNullOrEmpty(newPhoneNumber))
            {
                PhoneNumber = newPhoneNumber;
            }

            if (!string.IsNullOrEmpty(newAddress))
            {
                Address = newAddress;
            }
        }
    }
}

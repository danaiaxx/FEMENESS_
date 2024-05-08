using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace FEMENESS_.Backend.Auth
{

    public class Customer
    {
        public string Username { get; }
        public string Email { get; }
        public string Password { get; }

        public Customer(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }


    public interface IOrderable
    {
        List<Order> Orders { get; }
        void AddOrder(Order order);
    }

}

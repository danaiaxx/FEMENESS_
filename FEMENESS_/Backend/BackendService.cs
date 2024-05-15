using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEMENESS_.Backend
{
    public class BackendService
    {
        private List<User> userList = new List<User>();


        public User Register(string username, string email, string password)
        {
            if (userList.Any(user => user.Username == username || user.Email == email))
            {
                return null;
            }

            User newUser = new User(username, email, password);

            userList.Add(newUser);

            return newUser;
        }


        public User Login(string username, string password)
        {
            User loggedInUser = userList.FirstOrDefault(user => user.Username == username && user.Password == password);

            if (loggedInUser != null)
            {
                return loggedInUser;
            }
            else
            {
                return null;
            }
        }

        public void UpdateUserDetails(string username, string email, string phoneNo, string address)
        {
            User loggedUser = userList.FirstOrDefault(u => u.Username == username || u.Email == email);

            if (loggedUser != null)
            {
                loggedUser.UpdateUserDetails(username, email, phoneNo, address);
                return;
            }
        }
    }
}

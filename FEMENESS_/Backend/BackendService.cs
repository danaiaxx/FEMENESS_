using FEMENESS_.Backend.Auth;
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
        private List<ProductCategory> productCategories = new List<ProductCategory>();
        

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

        public void ForgotPassword(string email, string password)
        {
            User loggedUser = userList.FirstOrDefault(u =>  u.Email == email);

            if (loggedUser != null)
            {
                loggedUser.Password = password;
            }
        }

        public string GetCurrentPassword(string email)
        {
            User user = userList.FirstOrDefault(u => u.Email == email);
            return user?.Password;
        }

        public void AddProductCategory(string categoryName)
        {
            if (!productCategories.Any(category => category.Category == categoryName))
            {
                productCategories.Add(new ProductCategory(categoryName));
            }
        }

        public void AddProductToCategory(string categoryName, string productName, string productDescription, double productPrice)
        {
            ProductCategory category = productCategories.FirstOrDefault(cat => cat.Category == categoryName);
            if (category != null)
            {
                category.AddProduct(new Product(productName, productDescription, productPrice));
            }
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            ProductCategory category = productCategories.FirstOrDefault(cat => cat.Category == categoryName);
            return category?.Products;
        }

    }
}

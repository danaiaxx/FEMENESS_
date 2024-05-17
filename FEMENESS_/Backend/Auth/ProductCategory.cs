using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEMENESS_.Backend.Auth
{
    internal class ProductCategory
    {
        
        public string Category {  get; set; }
        //public string Description { get; set; }

        public List<Product> Products { get; set; }

        public ProductCategory(string Category) { 
            this.Category = Category;
            //this.Description = description;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}

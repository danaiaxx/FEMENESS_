using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEMENESS_.Backend.Auth
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Order(int orderId, string productName, double price)
        {
            OrderId = orderId;
            ProductName = productName;
            Price = price;
        }
    }

}

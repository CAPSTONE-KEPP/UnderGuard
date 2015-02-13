using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class OrderDetails
    {
        private Product product;
        private int quantity;
        private Order order;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Order Order
        {
            get { return order; }
            set { order = value; }
        }
    }
}

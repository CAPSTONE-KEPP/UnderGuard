using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesSystem
{
    public class OrderDetails
    {

        private Product products;
        private int quantity;
        private Order order;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product Products
        {
            get { return products; }
            set { products = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class OrderDetails
    {
        private Product product;
        private Findings finding;

        public Findings Finding
        {
            get { return finding; }
            set { finding = value; }
        }
        private int quantity;
        private Order order;

        public OrderDetails()
        {

        }

        public OrderDetails(Product p, int quantity)
        {
            this.product = p;
            this.quantity = quantity;
        }

        public OrderDetails(Findings f, int quantity)
        {
            this.finding = f;
            this.quantity = quantity;
        }

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

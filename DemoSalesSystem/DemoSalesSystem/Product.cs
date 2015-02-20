using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DemoSalesSystem
{
    public class Product
    {
        private int productID;
        private string name;
        private string description;
        private double price;
        private string size;
        private Image image;
        private string color;
        private DateTime dateEntered;
        private Status status;
        private BOM bom;
        private int quantityOnHand;

        public int QuantityOnHand
        {
            get { return quantityOnHand; }
            set { quantityOnHand = value; }
        }

        public Product()
        {
            bom = new BOM();
        }

        public Product(int id, string name, string size, string color)
        {
            this.productID = id;
            this.name = name;
            this.size = size;
            this.color = color;
        }

        public Product(int id, string name)
        {
            this.productID = id;
            this.name = name;
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BOM BOM
        {
            get { return bom; }
            set { bom = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public DateTime DateEntered
        {
            get { return dateEntered; }
            set { dateEntered = value; }
        }

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

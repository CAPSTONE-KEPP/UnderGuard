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
        private bool status;

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
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
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

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

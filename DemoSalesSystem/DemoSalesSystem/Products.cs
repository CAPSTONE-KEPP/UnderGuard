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
        private bool statusl;

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
    }
}

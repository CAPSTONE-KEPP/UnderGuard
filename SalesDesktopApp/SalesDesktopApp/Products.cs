using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesDesktopApp
{
    public class Product
    {
        private int productID;
        private string name;


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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Catalog
    {
        private int id;
        private List<Product> products;
        private DateTime startDate;
        private DateTime endDate;
        private string name;
        private string note;
        private string description;
        private bool status;

        public Product Product
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

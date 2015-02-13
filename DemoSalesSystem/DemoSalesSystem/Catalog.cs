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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

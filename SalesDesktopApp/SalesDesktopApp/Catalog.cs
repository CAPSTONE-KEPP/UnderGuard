﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesDesktopApp
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

        public string Description
        {
          get { return description; }
          set { description = value; }
        }

        public string Note
        {
          get { return note; }
          set { note = value; }
        }

        public string Name
        {
          get { return name; }
          set { name = value; }
        }

        public DateTime EndDate
        {
          get { return endDate; }
          set { endDate = value; }
        }

        public DateTime StartDate
        {
          get { return startDate; }
          set { startDate = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

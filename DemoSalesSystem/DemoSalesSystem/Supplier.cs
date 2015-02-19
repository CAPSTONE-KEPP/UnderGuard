using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Supplier : Contact
    {
        private bool standings;
        private string name;

        public Supplier()
        {

        }

        public Supplier(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public bool Standings
        {
            get { return standings; }
            set { standings = value; }
        }
    }
}

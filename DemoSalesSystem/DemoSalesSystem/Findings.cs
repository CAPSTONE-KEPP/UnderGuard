using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Findings
    {
        private int id;
        private string name;
        private string description;
        private double price;
        private SLA sla;
        private Supplier supplier;
        private string color;
        private int quantityOnHand;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public SLA Sla
        {
            get { return sla; }
            set { sla = value; }
        }

        public Supplier Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int QuantityOnHand
        {
            get { return quantityOnHand; }
            set { quantityOnHand = value; }
        }

        public Supplier Supplier1
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

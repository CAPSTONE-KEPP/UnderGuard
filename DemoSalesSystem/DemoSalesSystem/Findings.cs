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

        public SLA Sla
        {
            get { return sla; }
            set { sla = value; }
        }
        private List<SLA> slaList;

        public List<SLA> SlaList
        {
            get { return slaList; }
            set { slaList = value; }
        }
        private Supplier supplier;

        public Supplier Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        private List<Supplier> supplierList;

        public List<Supplier> SupplierList
        {
            get { return supplierList; }
            set { supplierList = value; }
        }
        private string color;
        private int quantityOnHand;

        public Findings(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Findings() 
        {

        }

        public Findings(int in_id, string in_name, string in_description, double in_price, SLA in_sla, Supplier in_supplier, string in_color, int in_QuantityOnHand)
        {
            id = in_id;
            name = in_name;
            description = in_description;
            price = in_price;
            sla = in_sla;
            supplier = in_supplier;
            color = in_color;
            quantityOnHand = in_QuantityOnHand;
        }



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

    }
}

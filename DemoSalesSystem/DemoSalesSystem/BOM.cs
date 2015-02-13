using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class BOM
    {
        private int productID;
        private List<Findings> findings;
        private int quantityOfFindings;
        private DateTime productionTime;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public List<Findings> Findings1
        {
            get { return findings; }
            set { findings = value; }
        }

        public int QuantityOfFindings
        {
            get { return quantityOfFindings; }
            set { quantityOfFindings = value; }
        }

        public DateTime ProductionTime
        {
            get { return productionTime; }
            set { productionTime = value; }
        }

        public Findings Findings
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

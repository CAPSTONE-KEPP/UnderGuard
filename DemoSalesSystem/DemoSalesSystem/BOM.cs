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
        private List<int> quantityOfFindings;
        private int productionTime;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public List<Findings> Findings
        {
            get { return findings; }
            set { findings = value; }
        }

        public List<int> QuantityOfFindings
        {
            get { return quantityOfFindings; }
            set { quantityOfFindings = value; }
        }

        public int ProductionTime
        {
            get { return productionTime; }
            set { productionTime = value; }
        }
    }
}

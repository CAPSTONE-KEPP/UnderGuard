using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class BOM
    {
        private int productID;
        private ICollection<Findings> findings;
        private int quantityOfFindings;
        private DateTime productionTime;

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

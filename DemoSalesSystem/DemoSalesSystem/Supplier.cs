using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Supplier : Contact
    {
        private int ID;
        private string notes;
        private bool standings;

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

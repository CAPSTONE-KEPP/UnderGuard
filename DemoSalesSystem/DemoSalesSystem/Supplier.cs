using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Supplier : Contact
    {
        private int id;
        private string notes;
        private bool standings;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public bool Standings
        {
            get { return standings; }
            set { standings = value; }
        }
    }
}

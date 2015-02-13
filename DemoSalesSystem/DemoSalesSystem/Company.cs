using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Company : Contact
    {
        private string name;
        private string missionStatement;
        private string slogan;
        public Company(int id, string name) { //constructor
        
        
        }

        public CompanyContact CompanyContact
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

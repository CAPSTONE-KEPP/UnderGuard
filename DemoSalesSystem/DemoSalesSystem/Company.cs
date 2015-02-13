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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MissionStatement
        {
            get { return missionStatement; }
            set { missionStatement = value; }
        }

        public string Slogan
        {
            get { return slogan; }
            set { slogan = value; }
        }
    }
}

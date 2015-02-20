using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class SLA
    {
        private DateTime deliveryTime;
        private int amount;
        private int id;
        private string description;
        private double cost;
        private int findingID;

        public int FindingID
        {
            get { return findingID; }
            set { findingID = value; }
        }

        public SLA(int id, int findingID)
        {
            this.id = id;
            this.findingID = findingID;
        }

        public SLA()
        {

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

        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
            set { deliveryTime = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}

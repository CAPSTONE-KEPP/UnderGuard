using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesSystem
{
    public class Order
    {

        private DateTime orderDate;
        private int companyID;
        private OrderStatus orderStatus;
        private CompanyContact companyContact;
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }


        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
       

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
        

        public OrderStatus OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }
    

        public CompanyContact CompanyContact
        {
            get { return companyContact; }
            set { companyContact = value; }
        }

    }
}

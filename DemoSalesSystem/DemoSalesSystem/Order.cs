using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class Order
    {
        #region class level variables
        private DateTime orderDate;
        private Company company;
        private OrderStatus orderStatus;
        private CompanyContact companyContact;
        private string note;
        private string type;
        #endregion
        #region getters and setters
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        public Company Company
        {
            get { return company; }
            set { company = value; }
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
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        #endregion

        public OrderDetails OrderDetails
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Company Company1
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public OrderLineItem OrderLineItem
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Product Product
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

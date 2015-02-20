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

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

        public Order() 
        {

        }

        public Order(DateTime in_orderDate, Company in_company, OrderStatus in_orderStatus, CompanyContact in_companyContact, string in_note, string in_type) 
        {
            orderDate = in_orderDate;
            company = in_company;
            orderStatus = in_orderStatus;
            companyContact = in_companyContact;
            note = in_note;
            type = in_type;
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

    }
}

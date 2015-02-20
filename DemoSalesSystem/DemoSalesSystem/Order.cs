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
        private List<OrderDetails> orderDetailsList;

        public List<OrderDetails> OrderDetailsList
        {
            get { return orderDetailsList; }
            set { orderDetailsList = value; }
        }
        private string note;
        private string type;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
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

        public Order(Company c, CompanyContact cc, string type, int id)
        {
            this.company = c;
            this.companyContact = cc;
            this.type = type;
            this.id = id;
            orderDetailsList = new List<OrderDetails>();
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

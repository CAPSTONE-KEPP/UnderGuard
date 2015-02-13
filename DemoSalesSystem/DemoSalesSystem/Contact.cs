using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public abstract class Contact
    {
        #region class variables
        private short id;
        private string address;
        private string city;
        private string province;
        private string postalCode;
        private string phone;
        private string alternatePhone;
        private string fax;
        private DateTime creationDate;
        private Status status;
        public string notes;
        private string eMail;
        #endregion
        #region getters and setters
        public short Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Province
        {
            get { return province; }
            set { province = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string AlternatePhone
        {
            get { return alternatePhone; }
            set { alternatePhone = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }
        private string Notes        
        {
            get { return notes; }
            set { notes = value; }
        }

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        #endregion
    }
}

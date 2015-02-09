using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDesktopApp
{
    abstract class Contact
    {
     
        private int id;
        private string address;
        private string city;
        private string province;
        private string postalCode;
        private string phone;
        private string altPhone;
        private string fax;
        private string email;
        private DateTime creationDate;
        private Status status;
        private string notes;

        public int Id
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
       

        public string AltPhone
        {
            get { return altPhone; }
            set { altPhone = value; }
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
     

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}

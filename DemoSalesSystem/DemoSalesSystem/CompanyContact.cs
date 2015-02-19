using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public class CompanyContact : Contact
    {
        #region class level variables
        private string firstName;
        private string lastName;
        private string title;
        private int extension;
        private string signature;
        private int branchID;
        private Salutation salutation;
        #endregion
        public CompanyContact(int id, string firstName, string lastName)
        {
            this.Id = (short)id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        #region getters and setters
        public Salutation Salutation
        {
            get { return salutation; }
            set { salutation = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        public string Signature
        {
            get { return signature; }
            set { signature = value; }
        }
        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }
        #endregion
    }
}

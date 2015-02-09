using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesDesktopApp
{
    public class CompanyContact : Contact
    {

        private string firstName;
        private string lastName;
        private string title;
        private int extension;
        private string signature;
        private int branchID;
        private Salutation salutation;

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

        public Salutation Salutation
        {
            get { return salutation; }
            set { salutation = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSalesSystem
{
    //public enum Provinces { AB, BC, MB, NB, NL, NS, NT, NU, ON, PE, QC, SK, YT};

    public partial class CompanyForm : Form
    {
        List<Company> companyList;

        public List<Company> CompanyList
        {
            get { return companyList; }
        }
        int companyID = 0;
        int contactID = 0;

    
        /// <summary>
        /// Sets necessary ui properties on creation
        /// </summary>
        public CompanyForm()
        {
            InitializeComponent();
            companyList = new List<Company>();
            cboStatus.DataSource = Enum.GetValues(typeof(Status));
            updateListOfCompanies();
            cboSalutation.DataSource = Enum.GetValues(typeof(Salutation));
            cboCompanyProvince.DataSource = Enum.GetValues(typeof(Provinces));
            cboContactProvince.DataSource = Enum.GetValues(typeof(Provinces));
            
            cboCompanyProvince.DropDownStyle = ComboBoxStyle.DropDownList;
           
            cboContactProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSalutation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Saves the company enables CRUD of contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompanySave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateNoEmptyStrings(gbxCompany))
                {
                    if (!ValidateAllPhoneNumbers(0))
                    {
                        MessageBox.Show("Invalid Phone Number");
                        return;
                    }
                    if (!ValidatePostalCode(txtCompanyPostal.Text))
                    {
                        MessageBox.Show("Invalid Postal code");
                        return;
                    }
                    companyID = GetNextCompanyIndex();

                    companyList.Add(new Company(companyID, txtCompanyName.Text));
                    companyList.ElementAt(companyID).Name = txtCompanyName.Text;
                    companyList.ElementAt(companyID).Address = txtCompanyAddress.Text;
                    companyList.ElementAt(companyID).AlternatePhone = txtCompanyAltPhone.Text;
                    companyList.ElementAt(companyID).City = txtCompanyCity.Text;
                    companyList.ElementAt(companyID).CreationDate = DateTime.Now;
                    companyList.ElementAt(companyID).Fax = txtCompanyFax.Text;
                    companyList.ElementAt(companyID).MissionStatement = txtMission.Text;
                    companyList.ElementAt(companyID).Phone = txtCompanyPhone.Text;
                    companyList.ElementAt(companyID).PostalCode = txtCompanyPostal.Text;
                    companyList.ElementAt(companyID).Province = (Provinces) Enum.Parse(typeof(Provinces), cboCompanyProvince.Text);
                    companyList.ElementAt(companyID).Slogan = txtSlogan.Text;
                    companyList.ElementAt(companyID).Status = (Status)Enum.Parse(typeof(Status), cboStatus.Text);
                    updateListOfCompanies();
                    switchContactBox();
                    lstCompanies.SelectedIndex = companyID;
                    btnCompanyDelete.Enabled = true;
                    btnCompanyUpdate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("All fields must be filled in");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Updates the currently selected company
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateNoEmptyStrings(gbxCompany))
            {
                if (!ValidateAllPhoneNumbers(0))
                {
                    MessageBox.Show("Invalid Phone Number");
                    return;
                }
                if (!ValidatePostalCode(txtCompanyPostal.Text))
                {
                    MessageBox.Show("Invalid Postal code");
                    return;
                }
                int ID = lstCompanies.SelectedIndex;
                companyList.ElementAt(ID).Name = txtCompanyName.Text;
                companyList.ElementAt(ID).Address = txtCompanyAddress.Text;
                companyList.ElementAt(ID).AlternatePhone = txtCompanyAltPhone.Text;
                companyList.ElementAt(ID).City = txtCompanyCity.Text;
                companyList.ElementAt(ID).Fax = txtCompanyFax.Text;
                companyList.ElementAt(ID).MissionStatement = txtMission.Text;
                companyList.ElementAt(ID).Phone = txtCompanyPhone.Text;
                companyList.ElementAt(ID).PostalCode = txtCompanyPostal.Text;
                companyList.ElementAt(ID).Province = (Provinces)Enum.Parse(typeof(Provinces), cboCompanyProvince.Text);
                companyList.ElementAt(ID).Slogan = txtSlogan.Text;
                companyList.ElementAt(ID).Status = (Status)Enum.Parse(typeof(Status), cboStatus.Text);
                updateListOfCompanies();
            }
            else
            {
                MessageBox.Show("All fields must be filled in");
            }
        }

        /// <summary>
        /// Deletes the currently selected company, will disable contact CRUD if no companies are left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            if (companyList.Count > 0)
            {
                companyList.RemoveAt(lstCompanies.SelectedIndex);
                updateListOfCompanies();
                switchContactBox();
                if (companyList.Count <= 0)
                {
                    btnCompanyDelete.Enabled = false;
                    btnCompanyUpdate.Enabled = false;
                }
                else
                {
                    lstCompanies.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("No companies to delete");
            }
        }

        /// <summary>
        /// Gets next company ID
        /// </summary>
        /// <returns></returns>
        private int GetNextCompanyIndex()
        {
            if (companyList.Count <= 0)
            {
                return 0;
            }
            else
            {
                return companyList.Count;
            }
        }

        /// <summary>
        /// Gets next contact id to be used
        /// </summary>
        /// <returns></returns>
        private int GetNextContactIndex()
        {
            if (companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Count <= 0)
            {
                return 0;
            }
            else
            {
                return companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Count;
            }
        }

        /// <summary>
        /// Updates the list of companies with all current companies
        /// </summary>
        private void updateListOfCompanies()
        {
            lstCompanies.Items.Clear();
            for (int i = 0; i < companyList.Count; i++)
            {
                lstCompanies.Items.Add(companyList.ElementAt(i).Name);
            }
        }

        /// <summary>
        /// Sets UI elements for the currently selected company
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtCompanyID.Text = companyList.ElementAt(lstCompanies.SelectedIndex).Id.ToString();
             txtCompanyName.Text = companyList.ElementAt(lstCompanies.SelectedIndex).Name;
            txtCompanyAddress.Text= companyList.ElementAt(lstCompanies.SelectedIndex).Address;
            txtCompanyAltPhone.Text= companyList.ElementAt(lstCompanies.SelectedIndex).AlternatePhone;
            txtCompanyCity.Text= companyList.ElementAt(lstCompanies.SelectedIndex).City;
            txtCompanyFax.Text= companyList.ElementAt(lstCompanies.SelectedIndex).Fax;
            txtMission.Text= companyList.ElementAt(lstCompanies.SelectedIndex).MissionStatement;
            txtCompanyPhone.Text= companyList.ElementAt(lstCompanies.SelectedIndex).Phone;
            txtCompanyPostal.Text = companyList.ElementAt(lstCompanies.SelectedIndex).PostalCode;
            cboCompanyProvince.Text = companyList.ElementAt(lstCompanies.SelectedIndex).Province.ToString();
            txtSlogan.Text = companyList.ElementAt(lstCompanies.SelectedIndex).Slogan;
            txtCompanyCreationDate.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CreationDate.ToString();
            cboStatus.Text = companyList.ElementAt(lstCompanies.SelectedIndex).Status.ToString();
            switchContactBox();
            contactID = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Count();
            clearContact();
            updateListOfContacts();

        }

        /// <summary>
        /// Disbales/enables the contact CRUD
        /// </summary>
        private void switchContactBox()
        {
            if (companyList.Count > 0)
            {
                gbxContacts.Enabled = true;
            }
            else
            {
                gbxContacts.Enabled = false;
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ensures all fields are filled for the given groupbox
        /// </summary>
        /// <param name="gb"></param>
        /// <returns></returns>
        private bool ValidateNoEmptyStrings(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    if ((c.Text == "" || c.Text == null) && (c != txtCompanyCreationDate && c != txtContactCreation && c != txtCompanyID && c!= txtContactID))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Saves the current contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContactSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateNoEmptyStrings(gbxContacts))
                {
                    if (!ValidateAllPhoneNumbers(1))
                    {
                        MessageBox.Show("Invalid Phone Number");
                        return;
                    }
                    if (!CheckIfIsNumber(txtContactBranch.Text))
                    {
                        MessageBox.Show("Invalid branch Id");
                        return;
                    }
                    if (!CheckIfIsNumber(txtContactExtension.Text))
                    {
                        MessageBox.Show("Invalid Extension Number");
                        return;
                    }
                    if (!ValidateEmail(txtContactEmail.Text))
                    {
                        MessageBox.Show("Invalid Email");
                        return;
                    }
                    if (!ValidatePostalCode(txtContactPostal.Text))
                    {
                        MessageBox.Show("Invalid Postal code");
                        return;
                    }
                    contactID = GetNextContactIndex();

                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Add(new CompanyContact(contactID, txtFirstName.Text, txtLastName.Text));
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Address = txtContactAddress.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).AlternatePhone = txtContactAltPhone.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).BranchID = Convert.ToInt32(txtContactBranch.Text);
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).City = txtCompanyCity.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).CreationDate = DateTime.Now;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).EMail = txtContactEmail.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Extension = Convert.ToInt32(txtContactExtension.Text);
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Fax = txtContactFax.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Phone = txtContactPhone.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).PostalCode = txtContactPostal.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Province = (Provinces) Enum.Parse(typeof(Provinces), cboContactProvince.Text);
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Salutation = (Salutation)Enum.Parse(typeof(Salutation), cboSalutation.Text);
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Signature = txtContactSignature.Text;
                    companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(contactID).Title = txtContactTitle.Text;
                    updateListOfContacts();
                    lstContacts.SelectedIndex = contactID;
                    btnContactDelete.Enabled = true;
                    btnContactUpdate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("All fields must be filled");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// Updates the selected contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContactUpdate_Click(object sender, EventArgs e)
        {

            if (ValidateNoEmptyStrings(gbxContacts))
            {
                if (!ValidateAllPhoneNumbers(1))
                {
                    MessageBox.Show("Invalid Phone Number");
                    return;
                }
                if (!CheckIfIsNumber(txtContactBranch.Text))
                {
                    MessageBox.Show("Invalid branch Id");
                    return;
                }
                if (!CheckIfIsNumber(txtContactExtension.Text))
                {
                    MessageBox.Show("Invalid Extension Number");
                    return;
                }
                if (!ValidateEmail(txtContactEmail.Text))
                {
                    MessageBox.Show("Invalid Email");
                    return;
                }
                if (!ValidatePostalCode(txtContactPostal.Text))
                {
                    MessageBox.Show("Invalid Postal code");
                    return;
                }
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).FirstName = txtFirstName.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).LastName = txtLastName.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Address = txtContactAddress.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).AlternatePhone = txtContactAltPhone.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).BranchID = Convert.ToInt32(txtContactBranch.Text);
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).City = txtCompanyCity.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).EMail = txtContactEmail.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Extension = Convert.ToInt32(txtContactExtension.Text);
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Fax = txtContactFax.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Phone = txtContactPhone.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).PostalCode = txtContactPostal.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Province = (Provinces)Enum.Parse(typeof(Provinces), cboContactProvince.Text);
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Salutation = (Salutation)Enum.Parse(typeof(Salutation), cboSalutation.Text);
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Signature = txtContactSignature.Text;
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Title = txtContactTitle.Text;
                updateListOfContacts();
            }
            else
            {
                MessageBox.Show("All fields must be filled");
            }
        }

        /// <summary>
        /// Deletes the selected contact, if none remain disables update and delete functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContactDelete_Click(object sender, EventArgs e)
        {
            if (companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Count > 0)
            {
                companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.RemoveAt(lstContacts.SelectedIndex);

                updateListOfContacts();
                
                if (companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Count <= 0)
                {
                    btnContactDelete.Enabled = false;
                    btnContactUpdate.Enabled = false;
                }
                else
                {
                    lstContacts.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("No contacts to delete");
            }
            
        }

        /// <summary>
        /// determines if given input is a number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool CheckIfIsNumber(string input)
        {
            int i;
            return int.TryParse(input, out i);
        }

        /// <summary>
        /// Regex for 9 digit phone numbers
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        private bool ValidatePhoneNumber(string phone)
        {
            Regex r = new Regex(@"([(]?\d\d\d[)]?[-]?)?\d\d\d[-]?[ ]?\d\d\d\d");
            return r.IsMatch(phone);           
        }

        /// <summary>
        /// Regex for canadian postal codes
        /// </summary>
        /// <param name="postal"></param>
        /// <returns></returns>
        private bool ValidatePostalCode(string postal)
        {
            Regex r = new Regex(@"[A-z][0-9][A-z] ?[0-9][A-z][0-9]");
            return r.IsMatch(postal);  
        }

        /// <summary>
        /// validates email addresses
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool ValidateEmail(string email)
        {
            Regex r = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            return r.IsMatch(email);  
        }


        /// <summary>
        /// Does validation for all phone fields
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool ValidateAllPhoneNumbers(int type)
        {
            if (type == 0)
            {
                if (!ValidatePhoneNumber(txtCompanyAltPhone.Text))
                {
                    return false;
                }
                if (!ValidatePhoneNumber(txtCompanyFax.Text))
                {
                    return false;
                }
                if (!ValidatePhoneNumber(txtCompanyPhone.Text))
                {
                    return false;
                }
                return true;
            }
            else
            {
                if (!ValidatePhoneNumber(txtContactAltPhone.Text))
                {
                    return false;
                }
                if (!ValidatePhoneNumber(txtContactFax.Text))
                {
                    return false;
                }
                if (!ValidatePhoneNumber(txtContactPhone.Text))
                {
                    return false;
                }
                return true;
            }
            
        }

        /// <summary>
        /// Updates the list of contacts with all contacts for the given company
        /// </summary>
        private void updateListOfContacts()
        {
            lstContacts.Items.Clear();
            for (int i = 0; i < companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.Count; i++)
            {
                lstContacts.Items.Add(companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(i).FirstName +" " + companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(i).LastName);
            }
        }

        /// <summary>
        /// clear all contact fields
        /// </summary>
        private void clearContact()
        {
            foreach (Control c in gbxContacts.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        /// <summary>
        /// Sets ui elements to currently selected contact values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtContactEmail.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).EMail;
            txtFirstName.Text =  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).FirstName;
            txtLastName.Text =  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).LastName;
            txtContactAddress.Text=  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Address;
            txtContactAltPhone.Text=  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).AlternatePhone;
            txtContactBranch.Text=  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).BranchID.ToString();
            txtContactCity.Text=  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).City;
            txtContactCreation.Text=  companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).CreationDate.ToString();
            txtContactExtension.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Extension.ToString();
            txtContactFax.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Fax;
            txtContactPhone.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Phone;
            txtContactPostal.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).PostalCode;
            cboContactProvince.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Province.ToString();
            cboSalutation.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Salutation.ToString();
            txtContactSignature.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Signature;
            txtContactTitle.Text = companyList.ElementAt(lstCompanies.SelectedIndex).CompanyContact.ElementAt(lstContacts.SelectedIndex).Title;
            
        }

        /// <summary>
        /// sets dummy data into all company ui fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDummyComp_Click(object sender, EventArgs e)
        {
            txtCompanyName.Text = "Company corp";
            txtCompanyAddress.Text = "123 fake st.";
            txtCompanyAltPhone.Text = "9021111111";
            txtCompanyCity.Text = "Cityson";
            txtCompanyFax.Text = "9022222222";
            txtMission.Text = "This is a mission statement";
            txtCompanyPhone.Text = "9023333333";
            txtCompanyPostal.Text = "B3L 2Y1";
            cboCompanyProvince.Text = "NS";
            txtSlogan.Text = "SLOGANS ARE US";
            cboStatus.Text = "GoodStanding";
        }

        /// <summary>
        /// sets dummy data into all contact ui fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDummyCont_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "Steve";
            txtLastName.Text = "Stevenson";
            txtContactAddress.Text = "2525 street st";
            txtContactAltPhone.Text = "9029999999";
            txtContactBranch.Text = "123";
            txtContactCity.Text = "Cityson";
            txtContactExtension.Text = "321";
            txtContactFax.Text = "9028888888";
            txtContactPhone.Text = "9027777777";
            cboContactProvince.Text = "NS";
            txtContactPostal.Text = "B3L 1Y2";
            cboSalutation.Text = "Mr.";
            txtContactSignature.Text = "Signature";
            txtContactTitle.Text = "Senior VP";
        }
    }
}

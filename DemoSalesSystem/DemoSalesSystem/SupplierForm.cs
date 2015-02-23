using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSalesSystem
{
    public partial class SupplierForm : Form
    {
        private List<Supplier> supplierList;
        private int index = -1;

        public SupplierForm(List<Supplier> supplierList)
        {
            InitializeComponent();
            this.supplierList = supplierList;

            //binds enums to comboboxes
            cmbProvince.DataSource = Enum.GetValues(typeof(Provinces));
            cmbStatus.DataSource = Enum.GetValues(typeof(Status));
            cboStanding.Items.Add("Good");
            cboStanding.Items.Add("Negative");
            cboStanding.SelectedIndex = 0;
            cboStanding.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateListBox();
        }

        /// <summary>
        /// list selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstSuppliers.SelectedIndex;
            DisplayInformation();
        }


        /// <summary>
        /// saves the current supplier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier temp = new Supplier();
                temp.Id = supplierList.Count();
                temp.Name = txtName.Text;
                temp.Standings = ParseStanding();
                temp.Address = txtAddress.Text;
                temp.City = txtCity.Text;

                //get the combo box selection
                Provinces province;
                Enum.TryParse<Provinces>(cmbProvince.SelectedValue.ToString(), out province);
                temp.Province = province;

                temp.PostalCode = txtPostalCode.Text;
                Status status;
                Enum.TryParse<Status>(cmbStatus.SelectedValue.ToString(), out status);
                temp.Status = status;
                temp.Phone = txtPhone.Text;
                temp.AlternatePhone = txtAlternatePhone.Text;
                temp.Fax = txtFax.Text;
                temp.EMail = txtEmail.Text;
                temp.CreationDate = DateTime.Now;
                temp.notes = txtNote.Text;
                supplierList.Add(temp);

                UpdateListBox();
                index = -1;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Parses the standing combobox to bool
        /// </summary>
        /// <returns></returns>
        private bool ParseStanding() 
        {
            if (cboStanding.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// parses bool to standing combobox
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ReverseParseStanding(Supplier s)
        {
            if (s.Standings==true)
            {
                return "Good";
            }
            else
            {
                return "Negative";
            }
        }

        /// <summary>
        /// deletes the current supplier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                supplierList.RemoveAt(index);
                UpdateListBox();
                index = -1;
            }
        }

        /// <summary>
        /// updates the currently selected supplier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > -1)
                {
                    supplierList.ElementAt(index).Name = txtName.Text;
                    supplierList.ElementAt(index).Standings = ParseStanding();
                    supplierList.ElementAt(index).Address = txtAddress.Text;
                    supplierList.ElementAt(index).City = txtCity.Text;

                    //get the combo box selection
                    Provinces province;
                    Enum.TryParse<Provinces>(cmbProvince.SelectedValue.ToString(), out province);
                    supplierList.ElementAt(index).Province = province;

                    supplierList.ElementAt(index).PostalCode = txtPostalCode.Text;
                    Status status;
                    Enum.TryParse<Status>(cmbStatus.SelectedValue.ToString(), out status);
                    supplierList.ElementAt(index).Status = status;
                    supplierList.ElementAt(index).Phone = txtPhone.Text;
                    supplierList.ElementAt(index).AlternatePhone = txtAlternatePhone.Text;
                    supplierList.ElementAt(index).Fax = txtFax.Text;
                    supplierList.ElementAt(index).EMail = txtEmail.Text;
                    supplierList.ElementAt(index).notes = txtNote.Text;
                    UpdateListBox();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// clears the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            index = -1;
            lstSuppliers.ClearSelected();//deselects the items from the list
        }

        /// <summary>
        /// Clears the all the textboxes
        /// </summary>
        private void ClearTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
            }
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
            }
        }

        /// <summary>
        /// Displayes the supplies information in the textboxes and combo boxes
        /// </summary>
        private void DisplayInformation()
        {
            try
            {
                if (index > -1)
                {
                    txtName.Text = supplierList.ElementAt(index).Name; ;
                    cboStanding.Text = ReverseParseStanding(supplierList.ElementAt(index));
                    txtID.Text = supplierList.ElementAt(index).Id.ToString();
                    txtAddress.Text = supplierList.ElementAt(index).Address;
                    txtCity.Text = supplierList.ElementAt(index).City;
                    cmbProvince.SelectedItem = supplierList.ElementAt(index).Province;
                    txtPostalCode.Text = supplierList.ElementAt(index).PostalCode;
                    cmbStatus.SelectedItem = supplierList.ElementAt(index).Status.ToString();
                    txtPhone.Text = supplierList.ElementAt(index).Phone;
                    txtAlternatePhone.Text = supplierList.ElementAt(index).AlternatePhone;
                    txtFax.Text = supplierList.ElementAt(index).Fax;
                    txtEmail.Text = supplierList.ElementAt(index).EMail;
                    txtCreationDate.Text = supplierList.ElementAt(index).CreationDate.ToString("MM/dd/yyyy h:mm tt");
                    txtNote.Text = supplierList.ElementAt(index).notes;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// updates the list box with all suppliers
        /// </summary>
        private void UpdateListBox()
        {
            lstSuppliers.Items.Clear();
            foreach (Supplier item in supplierList)
            {
                if (item.Name != null)
                {
                    lstSuppliers.Items.Add(item.Name);
                }
            }
        }
    }
}

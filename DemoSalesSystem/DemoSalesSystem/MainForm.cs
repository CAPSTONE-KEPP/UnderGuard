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
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        private Form childForm;

        private List<Supplier> suppliers = new List<Supplier>();


        public MainForm()
        {
            InitializeComponent();

            MakeFakeData();

            childForm = new frmCompany();
            childForm.MdiParent = this;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;
        }


        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm.Close();
            childForm = new SupplierForm(suppliers);
            childForm.MdiParent = this;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;
        }


        /// <summary>
        /// makes fake data
        /// </summary>
        private void MakeFakeData()
        {
            //suppliers
            for (int i = 0; i < 10; i++)
            {
                Supplier temp = new Supplier();
                temp.Id = suppliers.Count();
                temp.Name = "Name " + i;
                temp.Standings = true;
                temp.Address = "Address";
                temp.City = "City" + i;
                temp.Province = Provinces.Alberta;

                temp.PostalCode = "PostalCode" + i;
                temp.Status = Status.GoodStanding;
                temp.Phone = "Phone" + i;
                temp.AlternatePhone = "AlternatePhone" + i;
                temp.Fax = "Fax" + i;
                temp.EMail = "Email" + i;
                temp.CreationDate = DateTime.Now;
                temp.notes = "Note" + i;
                suppliers.Add(temp);
            }
        }
    }
}

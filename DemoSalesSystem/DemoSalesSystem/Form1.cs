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
    public partial class frmCompany : Form
    {
        private List<Company> companies = null;
        private Company currentCompany;
        public frmCompany()
        {
            InitializeComponent();
            companies = new List<Company>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Company aCompany = new Company(companies.Count, txtName.Text);
            aCompany.Address = txtAddress.Text;

            companies.Add(aCompany);//adds to the list of companies
        }
    }
}

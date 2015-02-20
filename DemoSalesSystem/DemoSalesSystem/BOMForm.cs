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
    public partial class BOMForm : Form
    {
        List<Findings> listOfAllFindings = new List<Findings>();
        List<Findings> findings = new List<Findings>();
        List<int> quantity = new List<int>();
        Findings currentFinding = null;
        Product product;

        public BOMForm(Product currentProduct)
        {
            InitializeComponent();
            product = currentProduct;
            Findings a = new Findings();
            a.Name = "a";
            listOfAllFindings.Add(a);

            cbxFindings.DisplayMember = "Name";
            cbxFindings.DataSource = listOfAllFindings;
        }

        private void btnAddFinding_Click(object sender, EventArgs e)
        {
            quantity.Add(Convert.ToInt32(nudQuantity.Value));
            currentFinding = (Findings)cbxFindings.Items[cbxFindings.SelectedIndex];
            findings.Add(currentFinding);
            lbxFindings.Items.Add(currentFinding);
        }

        private void btnAddBOM_Click(object sender, EventArgs e)
        {
            product.BOM.ProductID = product.ProductID;
            product.BOM.Findings = findings;
            product.BOM.QuantityOfFindings = quantity;
            product.BOM.ProductionTime = Convert.ToInt32(nudHours.Value);
            this.Close();
        }

      
    }
}

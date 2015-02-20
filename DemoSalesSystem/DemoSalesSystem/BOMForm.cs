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
            if (currentProduct.BOM.QuantityOfFindings!= null)
            {
                RefreshBomInfo();
            }
        }

        private void btnAddFinding_Click(object sender, EventArgs e)
        {
            quantity.Add(Convert.ToInt32(nudQuantity.Value));
            currentFinding = (Findings)cbxFindings.Items[cbxFindings.SelectedIndex];
            findings.Add(currentFinding);
            lbxFindings.Items.Add(currentFinding.Name);
        }

        private void btnAddBOM_Click(object sender, EventArgs e)
        {
            product.BOM.ProductID = product.ProductID;
            product.BOM.Findings = findings;
            product.BOM.QuantityOfFindings = quantity;
            product.BOM.ProductionTime = Convert.ToInt32(nudHours.Value);
            this.Close();
        }

        private void lbxFindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxFindings.Text = lbxFindings.SelectedItem.ToString();
                nudQuantity.Value = quantity.ElementAt(lbxFindings.SelectedIndex);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private void RefreshBomInfo()
        {
            lbxFindings.Items.Clear();
            foreach (Findings f in product.BOM.Findings)
            {
                lbxFindings.Items.Add(f.Name);
            }
            quantity = new List<int>(product.BOM.QuantityOfFindings);
            findings = new List<Findings>(product.BOM.Findings);
        }

        private void btnDeleteBOM_Click(object sender, EventArgs e)
        {
            product.BOM.ProductID = 0;
            product.BOM.Findings.Clear();
            product.BOM.QuantityOfFindings.Clear();
            product.BOM.ProductionTime = 0;
            this.Close();
        }

        private void btnRemoveFinding_Click(object sender, EventArgs e)
        {
            if (lbxFindings.SelectedItem != null)
            {
                quantity.RemoveAt(lbxFindings.SelectedIndex);
                findings.RemoveAt(lbxFindings.SelectedIndex);
                lbxFindings.Items.RemoveAt(lbxFindings.SelectedIndex);
            }
        }

      
    }
}

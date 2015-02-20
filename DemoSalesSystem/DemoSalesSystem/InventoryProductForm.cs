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
    public partial class InventoryProductForm : Form
    {
        List<Product> product = new List<Product>();
        public InventoryProductForm()
        {
            InitializeComponent();
            product.Add(new Product(0, "shirt", "M", "green"));
            product.Add(new Product(0, "shirt", "L", "black"));
            product.Add(new Product(0, "pants", "M", "green"));
            foreach (Product p in product)
            {
                cboProducts.Items.Add(p.Name);
            }
            cboProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckIfIsNumber(txtQuantity.Text))
            {
                product.ElementAt(cboProducts.SelectedIndex).QuantityOnHand = Convert.ToInt32(txtQuantity.Text);
            }
            else
            {
                MessageBox.Show("Quantity must be a whole number");                  
            }
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProductColor.Text = product.ElementAt(cboProducts.SelectedIndex).Color;
            lblProductID.Text = product.ElementAt(cboProducts.SelectedIndex).ProductID.ToString();
            lblProductSize.Text = product.ElementAt(cboProducts.SelectedIndex).Size;
            txtQuantity.Text = product.ElementAt(cboProducts.SelectedIndex).QuantityOnHand.ToString();
        }
        private bool CheckIfIsNumber(string input)
        {
            int i;
            return int.TryParse(input, out i);
        }
    }
}

﻿using System;
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

        /// <summary>
        /// Construtcor
        /// </summary>
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

        /// <summary>
        /// Saves the current product quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// updates the field information with the currently selected product's information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProductColor.Text = product.ElementAt(cboProducts.SelectedIndex).Color;
            lblProductID.Text = product.ElementAt(cboProducts.SelectedIndex).ProductID.ToString();
            lblProductSize.Text = product.ElementAt(cboProducts.SelectedIndex).Size;
            txtQuantity.Text = product.ElementAt(cboProducts.SelectedIndex).QuantityOnHand.ToString();
        }

        /// <summary>
        /// checks if a string is an int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool CheckIfIsNumber(string input)
        {
            int i;
            return int.TryParse(input, out i);
        }
    }
}

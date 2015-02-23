using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSalesSystem
{
    public partial class ProductForm : Form
    {

        MainForm mdi;
        private List<Product> products;
        private Product currentProduct;
        BOMForm bomForm;


        public ProductForm(MainForm mdi)
        {

            this.mdi = mdi;
            InitializeComponent();

            products = new List<Product>();
            lbxProducts.DisplayMember = "Name";
            lbxProducts.ValueMember = "Id";
            cbxStatus.DataSource = Enum.GetValues(typeof(Status));
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        /// <summary>
        /// Saves the product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            currentProduct = UpdateOrAddProduct();
            if (currentProduct != null)
            {
                products.Add(currentProduct);
                lbxProducts.Items.Add(currentProduct);
            }
            //products.Add(currentProduct);
            //lbxProducts.DataSource = products;
        }


        /// <summary>
        /// updates a current product or creates a new product
        /// </summary>
        /// <returns></returns>
        public Product UpdateOrAddProduct()
        {

                Product product = new Product();
                product.Color = tbxColour.Text;
                product.DateEntered = System.DateTime.Now;
                product.Description = tbxDescription.Text;
                product.Name = tbxName.Text;
                product.Size = tbxSize.Text;
                product.Image = pbxPicture.Image;
                Status status;
                Enum.TryParse<Status>(cbxStatus.SelectedValue.ToString(), out status);
                product.Status = status;
                try
                {
                    product.Price = Convert.ToDouble(tbxPrice.Text);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                }

                return product;

        }

        /// <summary>
        /// Updates the current product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                currentProduct = UpdateOrAddProduct();

                int index = lbxProducts.SelectedIndex;
                products.RemoveAt(index);
                products.Insert(index, currentProduct);
                RefreshProductList();
                lbxProducts.SelectedIndex = index;
                //lbxProducts.SelectedIndex = index;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Updates the product list with current products
        /// </summary>
        private void RefreshProductList()
        {
            lbxProducts.Items.Clear();
            foreach (Product p in products)
            {
                lbxProducts.Items.Add(p);
            }
        }

        /// <summary>
        /// Delets the current product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (products.Count > 0)
                {
                    ClearTextBoxes(this);
                    currentProduct = null;

                    products.RemoveAt(lbxProducts.SelectedIndex);
                    RefreshProductList();
                }
                //delete from lsit
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// clears all text boxes on the form
        /// </summary>
        /// <param name="control"></param>
        public void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        /// <summary>
        /// Adds a picture to the current product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPic_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbxPicture.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// updates all fields with the selected product's information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProduct = products.ElementAt(lbxProducts.SelectedIndex);

            tbxName.Text = currentProduct.Name;
            tbxDescription.Text = currentProduct.Description;
            tbxPrice.Text = currentProduct.Price.ToString();
            tbxSize.Text = currentProduct.Size;
            tbxColour.Text = currentProduct.Color;
            cbxStatus.SelectedItem = currentProduct.Status;
            pbxPicture.Image = currentProduct.Image;
        }

        /// <summary>
        /// opens the current product's BOM CRUD form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBom_Click(object sender, EventArgs e)
        {
            if (currentProduct != null)
            {
                bomForm = new BOMForm(currentProduct);
                bomForm.Show();
            }
            else
            {
                MessageBox.Show("Must select or create a product first");
            }
        }
    }
}

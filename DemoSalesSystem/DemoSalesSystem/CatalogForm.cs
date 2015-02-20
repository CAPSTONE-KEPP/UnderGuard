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
    public partial class CatalogForm : Form
    {
        List<Product> products;
        List<Product> selectedProducts;
        List<Catalog> catalog;
        const String statusActive = "Active";
        const String statusInactive = "Inactive";
        int catalogID=0;


        /// <summary>
        /// Creates dummy products and sets necessary UI element properties
        /// </summary>
        public CatalogForm()
        {
            InitializeComponent();
            catalog = new List<Catalog>();
            products = new List<Product>();
            selectedProducts = new List<Product>();
            products.Add(new Product(0, "Shirt"));
            products.Add(new Product(1, "Pants"));
            products.Add(new Product(2, "Hat"));
            products.Add(new Product(3, "Shoes"));
            products.Add(new Product(4, "Gloves"));
            for (int i = 0; i < products.Count; i++)
            {
                cboProducts.Items.Add(products.ElementAt(i).Name);
            }
            cboProducts.SelectedIndex = 0;
            cboStatus.Items.Add(statusActive);
            cboStatus.Items.Add(statusInactive);
            cboStatus.SelectedIndex = 0;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Adds a product to the catalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            
            selectedProducts.Add(products.ElementAt(cboProducts.SelectedIndex));
            updateSelectedProductList();
            btnRemoveProd.Enabled = true;
        }

        /// <summary>
        /// removes a product from the catalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveProd_Click(object sender, EventArgs e)
        {
            if (selectedProducts.Count > 0)
            {
                selectedProducts.RemoveAt(lstCatalogProducts.SelectedIndex);
                updateSelectedProductList();
                if (selectedProducts.Count <= 0)
                {
                    btnRemoveProd.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Nothing to Remove");
            }
    
        }

        /// <summary>
        /// saves the current catalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                catalogID = getNextCatalogID();
                catalog.Add(new Catalog(catalogID, txtName.Text));
                catalog.ElementAt(catalogID).Description = txtDescription.Text;
                catalog.ElementAt(catalogID).EndDate = dateEnd.Value;
                catalog.ElementAt(catalogID).Note = txtNote.Text;
                catalog.ElementAt(catalogID).StartDate = dateStart.Value;
                catalog.ElementAt(catalogID).Status = parseStatus();
                catalog.ElementAt(catalogID).Products = new List<Product>(selectedProducts);
                updateCatalogList();
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

        }

        /// <summary>
        /// Deletes the selected catalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                catalog.RemoveAt(lstCatalogs.SelectedIndex);
                updateCatalogList();
                lstCatalogProducts.Items.Clear();
                if (catalog.Count <= 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Updates the selected catalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                catalogID = lstCatalogs.SelectedIndex;
                catalog.ElementAt(catalogID).Name = txtName.Text;
                catalog.ElementAt(catalogID).Description = txtDescription.Text;
                catalog.ElementAt(catalogID).EndDate = dateEnd.Value;
                catalog.ElementAt(catalogID).Note = txtNote.Text;
                catalog.ElementAt(catalogID).StartDate = dateStart.Value;
                catalog.ElementAt(catalogID).Status = parseStatus();
                catalog.ElementAt(catalogID).Products = new List<Product>(selectedProducts);
                updateCatalogList();
            }
            catch (NullReferenceException nre)
            {
                System.Console.WriteLine(nre);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Gets the next catalog ID to use
        /// </summary>
        /// <returns></returns>
        private int getNextCatalogID()
        {
            if (catalog.Count <= 0)
            {
                return 0;
            }
            else
            {
                return catalog.Count;
            }
        }

        /// <summary>
        /// Parses the status of the catalog into a bool
        /// </summary>
        /// <returns></returns>
        private bool parseStatus(){
            if(cboStatus.SelectedIndex==0){
                return true;
            }
            else{
                return false;
            }
        }

        /// <summary>
        /// parses bool into the status of the catalog
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private string ReverseParseStatus(bool b)
        {
            if (b)
            {
                return statusActive;
            }
            else
            {
                return statusInactive;
            }
        }

        /// <summary>
        /// Updates the list of catalogs
        /// </summary>
        private void updateCatalogList()
        {
            lstCatalogs.Items.Clear();
            foreach (Catalog c in catalog)
            {
                lstCatalogs.Items.Add(c.Name);
            }
        }

        /// <summary>
        /// Updates the list of selected products
        /// </summary>
        private void updateSelectedProductList()
        {
            lstCatalogProducts.Items.Clear();
            foreach (Product p in selectedProducts)
            {
                lstCatalogProducts.Items.Add(p.Name);
            }
        }

        /// <summary>
        /// Sets UI elements for the selected catalog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCatalogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = catalog.ElementAt(lstCatalogs.SelectedIndex).Name;
            txtDescription.Text = catalog.ElementAt(lstCatalogs.SelectedIndex).Description;
            dateEnd.Value = catalog.ElementAt(lstCatalogs.SelectedIndex).EndDate;
            txtNote.Text = catalog.ElementAt(lstCatalogs.SelectedIndex).Note;
            dateStart.Value = catalog.ElementAt(lstCatalogs.SelectedIndex).StartDate;
            cboStatus.Text = ReverseParseStatus(catalog.ElementAt(lstCatalogs.SelectedIndex).Status);
            txtID.Text = catalog.ElementAt(lstCatalogs.SelectedIndex).Id.ToString();
            selectedProducts = new List<Product>(catalog.ElementAt(lstCatalogs.SelectedIndex).Products);
            updateSelectedProductList();
        }


    }
}

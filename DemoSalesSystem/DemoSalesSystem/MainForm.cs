using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DemoSalesSystem
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        ProductForm productForm;
        private Form childForm;
        private List<Supplier> suppliers = new List<Supplier>();
        CatalogForm cf;
        OrderForm of;
        CompanyForm cof;
        FindingForm ff;
        FindingUpdateForm fuf;
        InventoryProductForm ipf;
        List<Company> companyList;
        List<Order> orderList;
        Findings currentFinding;
        Order currentMOOrder;


        /// <summary>
        /// constructor, initializes all the forms
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            txtMFId.Text = (lstMFindings.Items.Count + 1).ToString();

            productForm = new ProductForm(this);
            cf = new CatalogForm();
            cf.MdiParent = this;
            cf.Visible = false;
            cf.WindowState = FormWindowState.Maximized;
            of = new OrderForm();
            of.MdiParent = this;
            of.Visible = false;
            of.WindowState = FormWindowState.Maximized;
            cof = new CompanyForm();
            cof.MdiParent = this;
            cof.Visible = false;
            cof.WindowState = FormWindowState.Maximized;
            ff = new FindingForm();
            ff.MdiParent = this;
            ff.Visible = false;
            ff.WindowState = FormWindowState.Maximized;
            ipf = new InventoryProductForm();
            ipf.MdiParent = this;
            ipf.Visible = false;
            ipf.WindowState = FormWindowState.Maximized;
            MakeFakeData();
            childForm = new SupplierForm(suppliers);
            childForm.Visible = false;
            childForm.WindowState = FormWindowState.Maximized;

        }

        /// <summary>
        /// hides all forms except the selected form
        /// </summary>
        /// <param name="f"></param>
        private void showForm(Form f)
        {
            cf.Visible = false;
            of.Visible = false;
            cof.Visible = false;
            ff.Visible = false;
            f.Visible = true;
        }


        /// <summary>
        /// opens the products form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            productForm.MdiParent = this;
            productForm.WindowState = FormWindowState.Maximized;
            HidePanels();
            productForm.Show();
           // MakeFakeData();
            //childForm = new frmCompany();
            //childForm.MdiParent = this;
            //childForm.Show();
            //childForm.WindowState = FormWindowState.Maximized;
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

        /// <summary>
        /// clears the order panel
        /// </summary>
        public void MOClear()
        {
            cmbMOCompany.Text = "";
            cmbMOCompanyContact.Text = "";
            cmbMOOrderStatus.Text = "";
            txtMOType.Text = "";
            txtMONotes.Text = "";
            dtpMODate.Text = "";
        }

        /// <summary>
        /// opens the manufacturing findings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fuf = new FindingUpdateForm(ff.Findings);
            fuf.MdiParent = this;
            fuf.Visible = false;
            fuf.WindowState = FormWindowState.Maximized;
            Point l = this.Location;
            this.Bounds = fuf.Bounds;
            this.Location = l;
            HidePanels();
            fuf.Show();
        }

        /// <summary>
        /// gets all current sales orders for the order panel
        /// </summary>
        private void PopulateOrdersForm()
        {
            if (of.Orders.Count > 0)
            {
                orderList = new List<Order>(of.Orders);
                foreach (Order o in orderList)
                {                    
                    lstMOOrders.Items.Add(o.Id + " " + o.Company.Name);
                }
                lstMOOrders.SelectedIndex = 0;
            }
            cmbMOOrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            
        }

        /// <summary>
        /// Hides all forms
        /// </summary>
        private void HideForms()
        {
            try
            {
                ff.Visible = false;
                cof.Visible = false;
                cf.Visible = false;
                of.Visible = false;
                ipf.Visible = false;
                childForm.Visible = false;
                productForm.Visible = false;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// opens manufacturing view orders form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForms();
            PopulateOrdersForm();
            pnlMFindings.Visible = false;
            pnlMOrder.Visible = true;
        }

        /// <summary>
        /// clears the manufacturing order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMOClear_Click(object sender, EventArgs e)
        {
            MOClear();
        }

        /// <summary>
        /// Updates the currently selected order's status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMOUpdate_Click(object sender, EventArgs e)
        {
            //btn Manu Order Update is clicked, update Manu Order Obj from lst...
            bool goodMOSave = true;
            if (cmbMOCompany.Text.Length >= 24 || cmbMOCompany.Text.Length < 1)
            {
                goodMOSave = false;
            }
            if (cmbMOCompanyContact.Text.Length >= 24 || cmbMOCompanyContact.Text.Length < 1)
            {
                goodMOSave = false;
            }
            if (cmbMOOrderStatus.Text.Length >= 24 || cmbMOOrderStatus.Text.Length < 1)
            {
                goodMOSave = false;
            }
            if (txtMOType.Text.Length >= 24 || txtMOType.Text.Length < 1)
            {
                goodMOSave = false;
            }
            if (txtMONotes.Text.Length >= 1024 || txtMONotes.Text.Length < 1)
            {
                goodMOSave = false;
            }
            if (goodMOSave == true)
            {
                //valid MO save...
                //Valid fields for update.
                if (lstMOOrders.SelectedItem != null)
                {
                    currentMOOrder = UpdateMOOrder();
                    lstMOOrders.SelectedItem = currentMOOrder;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            goodMOSave = true;

        }


        /// <summary>
        /// gets and sets the necessary information to update the order
        /// </summary>
        /// <returns></returns>
        private Order UpdateMOOrder()
        {
            Order tempOrders = orderList.ElementAt(lstMOOrders.SelectedIndex);
            tempOrders.Note = txtMONotes.Text;
            tempOrders.OrderStatus = (OrderStatus) Enum.Parse(typeof(OrderStatus), cmbMOOrderStatus.Text);
            
            return tempOrders;
        }

        /// <summary>
        /// Opens the supplier form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suppliersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            //childForm.Close();
            
            childForm.MdiParent = this;
            Point l = this.Location;
            this.Bounds = childForm.Bounds;
            this.Location = l;
            childForm.Show();
            HidePanels();
            
        }

        /// <summary>
        /// Opens the company CRUD form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = cof.Bounds;
            this.Location = l;
            HidePanels();
            showForm(cof);
        }

        /// <summary>
        /// Opens the catalog CRUD form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void catalogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = cf.Bounds;
            this.Location = l;
            HidePanels();
            showForm(cf);
        }

        /// <summary>
        /// Opens the sales order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = of.Bounds;
            this.Location = l;
            of.Companies = cof.CompanyList;
            of.UpdateCompanyList();
            HidePanels();
            showForm(of);
        }

        /// <summary>
        /// Opens the inventory product update form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = ipf.Bounds;
            this.Location = l;
            HidePanels();
            showForm(ipf);
        }

        /// <summary>
        /// opens the findings CRUD form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findingsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = ff.Bounds;
            this.Location = l;
            HidePanels();
            showForm(ff);
        }

        /// <summary>
        /// hides all panels in the main form
        /// </summary>
        private void HidePanels()
        {
            pnlMFindings.Visible = false;
            pnlMOrder.Visible =false;
        }


        /// <summary>
        /// Updates the fields with the selected order's information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstMOOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMOCompany.Text = orderList.ElementAt(lstMOOrders.SelectedIndex).Company.Name;
            cmbMOCompanyContact.Text = orderList.ElementAt(lstMOOrders.SelectedIndex).CompanyContact.FirstName + " " + orderList.ElementAt(lstMOOrders.SelectedIndex).CompanyContact.LastName;
            cmbMOOrderStatus.Text = orderList.ElementAt(lstMOOrders.SelectedIndex).OrderStatus.ToString();
            txtMOType.Text = orderList.ElementAt(lstMOOrders.SelectedIndex).Type;
            dtpMODate.Value = orderList.ElementAt(lstMOOrders.SelectedIndex).OrderDate;
            txtMONotes.Text = orderList.ElementAt(lstMOOrders.SelectedIndex).Note;
        }



    }
}

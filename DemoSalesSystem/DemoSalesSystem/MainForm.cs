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



        //private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Point l = this.Location;
        //    this.Bounds = cf.Bounds;
        //    this.Location = l;
        //    showForm(cf);
        //}

        //private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Point l = this.Location;
        //    this.Bounds = of.Bounds;
        //    this.Location = l;
        //    of.Companies = cof.CompanyList;
        //    of.UpdateCompanyList();
        //    showForm(of);
        //}

        private void showForm(Form f)
        {
            cf.Visible = false;
            of.Visible = false;
            cof.Visible = false;
            ff.Visible = false;
            f.Visible = true;
        }

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
        private void btnMFClear_Click(object sender, EventArgs e)
        {
            MFClear();
        }

        private void btnMFSave_Click(object sender, EventArgs e)
        {

        }

        public void MFClear()
        {
            txtMFName.Text = "";
            txtMFSupplier.Text = "";
            txtMFColor.Text = "";
            txtMFQuantityOnHand.Text = "";
            txtMFPrice.Text = "";
            txtMFDescription.Text = "";
            txtMFSLA.Text = "";
        }

        public void MOClear()
        {
            cmbMOCompany.Text = "";
            cmbMOCompanyContact.Text = "";
            cmbMOOrderStatus.Text = "";
            txtMOType.Text = "";
            txtMONotes.Text = "";
            dtpMODate.Text = "";
        }

        private void btnMFDelete_Click(object sender, EventArgs e)
        {
            //when Manu Findings delete is clicked, delete selected object from lst.
        }

        private void btnMFUpdate_Click(object sender, EventArgs e)
        {
            //when Manu Findings update is clicked, update selected object from lst.
            //boolean used to check if fields are valid...
            bool goodMFSave = true;

            if (!Regex.IsMatch(txtMFId.Text, "[0-9]+") || txtMFId.Text.Length >= 24 || txtMFId.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (txtMFName.Text.Length >= 24 || txtMFName.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (txtMFSupplier.Text.Length >= 24 || txtMFSupplier.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (txtMFColor.Text.Length >= 24 || txtMFColor.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (!Regex.IsMatch(txtMFQuantityOnHand.Text, "[0-9]+") || txtMFQuantityOnHand.Text.Length >= 24 || txtMFQuantityOnHand.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (!Regex.IsMatch(txtMFPrice.Text, "^[0-9]*[.]?[0-9]{0,2}") || txtMFPrice.Text.Length >= 24 || txtMFPrice.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (txtMFSLA.Text.Length >= 512 || txtMFSLA.Text.Length < 1)
            {
                goodMFSave = false;
            }
            if (txtMFDescription.Text.Length >= 1024 || txtMFDescription.Text.Length < 1)
            {
                goodMFSave = false;
            }

            if (goodMFSave == true)
            {
                //Valid fields for update.
                if (lstMFindings.SelectedItem != null)
                {
                    //currentFinding = UpdateFindings();
                    lstMFindings.SelectedItem = currentFinding;
            }


            }
            else
            {
                MessageBox.Show("Please enter valid fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            goodMFSave = true;

        }

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

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideForms();
            PopulateOrdersForm();
            pnlMFindings.Visible = false;
            pnlMOrder.Visible = true;
        }

        private void btnMOClear_Click(object sender, EventArgs e)
        {
            MOClear();
        }

        private void btnMOSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMODelete_Click(object sender, EventArgs e)
        {
            //btn Manu Order Delete is clicked, delete Manu Order Obj from lst...
        }

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

        private Order UpdateMOOrder()
        {
            Order tempOrders = orderList.ElementAt(lstMOOrders.SelectedIndex);
            tempOrders.Note = txtMONotes.Text;
            tempOrders.OrderStatus = (OrderStatus) Enum.Parse(typeof(OrderStatus), cmbMOOrderStatus.Text);
            
            return tempOrders;
        }

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

        private void companyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = cof.Bounds;
            this.Location = l;
            HidePanels();
            showForm(cof);
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = cof.Bounds;
            this.Location = l;
            HidePanels();
            showForm(cof);
        }

        private void catalogToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = cf.Bounds;
            this.Location = l;
            HidePanels();
            showForm(cf);
        }

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

        private void productsToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = ipf.Bounds;
            this.Location = l;
            HidePanels();
            showForm(ipf);
        }

        private void findingsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Point l = this.Location;
            this.Bounds = ff.Bounds;
            this.Location = l;
            HidePanels();
            showForm(ff);
        }

        private void HidePanels()
        {
            pnlMFindings.Visible = false;
            pnlMOrder.Visible =false;
        }

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

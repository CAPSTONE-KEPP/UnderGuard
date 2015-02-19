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
    /// <summary>
    /// Order form class used by companies to place orders
    /// </summary>
    public partial class OrderForm : Form
    {
        List<Product> products;
        List<OrderDetails> orderDetails;
        List<Order> orders;
        List<Company> companies;
        int orderId = 0;

        public List<Company> Companies
        {
            get { return companies; }
            set { companies = value; }
        }

        /// <summary>
        /// Sets some dummy product data, sets necessary settings on all UI elements
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
            products = new List<Product>();
            orderDetails = new List<OrderDetails>();
            orders = new List<Order>();
            products.Add(new Product(0, "shirt"));
            products.Add(new Product(1, "pants"));
            products.Add(new Product(2, "shoes"));
            products.Add(new Product(3, "hat"));
            products.Add(new Product(4, "gloves"));
            cboStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            for(int i=0;i<products.Count;i++){
                lstProducts.Items.Add(products.ElementAt(i).Name);
            }
            cboCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContact.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            lsvCurrentOrder.Columns.Add("Product");
            lsvCurrentOrder.Columns.Add("Quantity");
            lsvCurrentOrder.View = View.Details;
            lsvCurrentOrder.MultiSelect = false;

            lsvOrders.Columns.Add("ID");
            lsvOrders.Columns.Add("Company");
            lsvOrders.Columns.Add("Date");
            lsvOrders.View = View.Details;
            lsvOrders.MultiSelect = false;
        }

        /// <summary>
        /// Updates the company combo box with all current companies
        /// </summary>
        public void UpdateCompanyList()
        {
            cboCompany.Items.Clear();
            for (int i = 0; i < companies.Count; i++)
            {
                cboCompany.Items.Add(companies.ElementAt(i).Name);
            }
        }

        /// <summary>
        /// adds a product to the current order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nudQuantity.Value) <= 0)
            {
                MessageBox.Show("Quantity cannot be zero");
                return;
            }
            if (lstProducts.SelectedItem==null)
            {
                MessageBox.Show("Must select a product to add");
                return;
            }
            {
                orderDetails.Add(new OrderDetails(products.ElementAt(lstProducts.SelectedIndex), Convert.ToInt32(nudQuantity.Value)));
                updateCurrentOrderList();
                btnRemove.Enabled = true;
            }
            
        }


        /// <summary>
        /// Displays all products currently on order
        /// </summary>
        private void updateCurrentOrderList()
        {
            lsvCurrentOrder.Items.Clear();
            for (int i = 0; i < orderDetails.Count; i++)
            {
                var addItem = new ListViewItem(new string[] { orderDetails.ElementAt(i).Product.Name, orderDetails.ElementAt(i).Quantity.ToString() });
                lsvCurrentOrder.Items.Add(addItem);
            }
        }

        /// <summary>
        /// Removes a product from the current order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvCurrentOrder.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Must select a product to remove");
                return;
            }
            if (orderDetails.Count > 0)
            {
                orderDetails.RemoveAt(lsvCurrentOrder.FocusedItem.Index);
                updateCurrentOrderList();
                if (orderDetails.Count <= 0)
                {
                    btnRemove.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Nothing to remove");
            }
        }


        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (companies.Count > 0 && cboContact.SelectedItem != null)
                {
                    if (companies.ElementAt(cboCompany.SelectedIndex).CompanyContact.Count > 0)
                    {
                        try
                        {
                            orderId = GetNextOrderId();
                            orders.Add(new Order(companies.ElementAt(cboCompany.SelectedIndex), companies.ElementAt(cboCompany.SelectedIndex).CompanyContact.ElementAt(cboContact.SelectedIndex), "sales", orderId));
                            orders.ElementAt(orderId).OrderDate = DateTime.Now;
                            orders.ElementAt(orderId).Note = txtNotes.Text;
                            orders.ElementAt(orderId).OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), cboStatus.Text);
                            for (int i = 0; i < orderDetails.Count; i++)
                            {
                                orderDetails.ElementAt(i).Order = orders.ElementAt(orderId);
                            }
                            orders.ElementAt(orderId).OrderDetailsList = orderDetails;
                            orderDetails = new List<OrderDetails>();
                            
                            updateCurrentOrderList();
                            UpdateOrdersList();
                            btnDelete.Enabled = true;
                            btnUpdate.Enabled = true;
                        }
                        catch (NullReferenceException nre)
                        {
                            System.Console.WriteLine(nre);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contact is required");
                    }
             }
                else
                {
                    MessageBox.Show("Cannot place order without a company");
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex);
            }
        }


        /// <summary>
        /// Gets the next ID to be used for orders
        /// </summary>
        /// <returns></returns>
        private int GetNextOrderId()
        {
            if (orders.Count <= 0)
            {
                return 0;
            }
            else
            {
                return orders.Count;
            }
        }

        /// <summary>
        /// Updates the currently selected order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (lsvOrders.Items.Count > 0)
                {
                    int orderId = lsvOrders.FocusedItem.Index;
                    orders.ElementAt(orderId).Note = txtNotes.Text;
                    orders.ElementAt(orderId).OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), cboStatus.Text);
                    orders.ElementAt(orderId).Company = companies.ElementAt(cboCompany.SelectedIndex);
                    orders.ElementAt(orderId).CompanyContact = companies.ElementAt(cboCompany.SelectedIndex).CompanyContact.ElementAt(cboContact.SelectedIndex);
                    UpdateOrdersList();
                }
                else
                {
                    MessageBox.Show("Nothing to Update");
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
        /// Deletes the currently selected order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (orders.Count > 0 && lsvOrders.SelectedItems.Count>0)
                {
                    orders.RemoveAt(lsvOrders.FocusedItem.Index);
                    UpdateOrdersList();
                    lsvCurrentOrder.Clear();
                    if (orders.Count <= 0)
                    {
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Nothing to delete");
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
        /// Updates the order list with all current orders
        /// </summary>
        public void UpdateOrdersList()
        {
            lsvOrders.Items.Clear();
            for (int i = 0; i < orders.Count; i++)
            {
                var addItem = new ListViewItem(new string[] { orders.ElementAt(i).Id.ToString(), orders.ElementAt(i).Company.Name, orders.ElementAt(i).OrderDate.ToString() });
                lsvOrders.Items.Add(addItem);
            }
        }

        /// <summary>
        /// Sets the product info when product is selected from add list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblID.Text = products.ElementAt(lstProducts.SelectedIndex).ProductID.ToString();
            lblName.Text = products.ElementAt(lstProducts.SelectedIndex).Name;         
        }

        /// <summary>
        /// Sets all contacts of currently selected company to contact combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContactList();
        }

        /// <summary>
        /// Sets all UI elements of currently selected order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvOrders.FocusedItem != null)
            {
                btnUpdate.Enabled = true;
                CopyOrderDetails();
                updateCurrentOrderList();
                txtNotes.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).Note;
                txtDate.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).OrderDate.ToString();
                cboCompany.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).Company.Name;
                UpdateContactList();
                cboStatus.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).OrderStatus.ToString();
                cboContact.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).CompanyContact.FirstName + " " + orders.ElementAt(lsvOrders.FocusedItem.Index).CompanyContact.LastName;
            }
        }

        /// <summary>
        /// Copys order list to the temp list on the ui
        /// </summary>
        private void CopyOrderDetails()
        {
            orderDetails.Clear();
            for (int i = 0; i < orders.ElementAt(lsvOrders.FocusedItem.Index).OrderDetailsList.Count; i++)
            {
                orderDetails.Add(orders.ElementAt(lsvOrders.FocusedItem.Index).OrderDetailsList.ElementAt(i));
            }
        }

        /// <summary>
        /// Sets all contacts of currently selected company to contact combo box
        /// </summary>
        private void UpdateContactList()
        {
            cboContact.Items.Clear();
            for (int i = 0; i < companies.ElementAt(cboCompany.SelectedIndex).CompanyContact.Count; i++)
            {
                cboContact.Items.Add(companies.ElementAt(cboCompany.SelectedIndex).CompanyContact.ElementAt(i).FirstName + " " + companies.ElementAt(cboCompany.SelectedIndex).CompanyContact.ElementAt(i).LastName);
            }
            cboContact.SelectedIndex = 0;
        }
    }
}

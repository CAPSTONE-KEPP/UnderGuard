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
    public partial class SupplierOrderForm : Form
    {
        List<Findings> findings;
        List<OrderDetails> orderDetails;
        List<Order> orders;
        

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        List<Supplier> suppliers;
        int orderId = 0;

        public List<Supplier> Suppliers
        {
            get { return suppliers; }
            set { suppliers = value; }
        }

        /// <summary>
        /// Sets some dummy product data, sets necessary settings on all UI elements
        /// </summary>
        public SupplierOrderForm()
        {
            InitializeComponent();
            findings = new List<Findings>();
            orderDetails = new List<OrderDetails>();
            orders = new List<Order>();
            findings.Add(new Findings(0, "button"));
            findings.Add(new Findings(1, "sleeve"));
            findings.Add(new Findings(2, "laces"));
            findings.Add(new Findings(3, "rubber"));
            cboStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            for(int i=0;i<findings.Count;i++){
                lstProducts.Items.Add(findings.ElementAt(i).Name);
            }
            cboCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            
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
            suppliers = new List<Supplier>();
            suppliers.Add(new Supplier(0, "Supplier 1"));
            suppliers.Add(new Supplier(1, "Supplier 2"));
            suppliers.Add(new Supplier(2, "Supplier 3"));
            suppliers.Add(new Supplier(3, "Supplier 4"));
            UpdateCompanyList();
        }

        /// <summary>
        /// Updates the company combo box with all current companies
        /// </summary>
        public void UpdateCompanyList()
        {
            cboCompany.Items.Clear();
            for (int i = 0; i < suppliers.Count; i++)
            {
                cboCompany.Items.Add(suppliers.ElementAt(i).Name);
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
                orderDetails.Add(new OrderDetails(findings.ElementAt(lstProducts.SelectedIndex), Convert.ToInt32(nudQuantity.Value)));
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
                var addItem = new ListViewItem(new string[] { orderDetails.ElementAt(i).Finding.Name, orderDetails.ElementAt(i).Quantity.ToString() });
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
                if (suppliers.Count > 0 && orderDetails.Count>0)
                {

                        try
                        {
                            orderId = GetNextOrderId();
                            orders.Add(new Order(suppliers.ElementAt(cboCompany.SelectedIndex),  "sales", orderId));
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
                    MessageBox.Show("Cannot place empty order");
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
                    orders.ElementAt(orderId).Supplier = suppliers.ElementAt(cboCompany.SelectedIndex);
                    for (int i = 0; i < orderDetails.Count; i++)
                    {
                        orderDetails.ElementAt(i).Order = orders.ElementAt(orderId);
                    }
                    orders.ElementAt(orderId).OrderDetailsList = orderDetails;
                    orderDetails = new List<OrderDetails>();
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
                    updateCurrentOrderList();
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
                var addItem = new ListViewItem(new string[] { orders.ElementAt(i).Id.ToString(), orders.ElementAt(i).Supplier.Name, orders.ElementAt(i).OrderDate.ToString() });
                lsvOrders.Items.Add(addItem);
            }
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
                cboCompany.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).Supplier.Name;
                cboStatus.Text = orders.ElementAt(lsvOrders.FocusedItem.Index).OrderStatus.ToString();
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
    }
}

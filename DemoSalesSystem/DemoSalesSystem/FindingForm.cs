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
    public partial class FindingForm : Form
    {
        private List<Supplier> supplier = new List<Supplier>();
        private List<Findings> findings = new List<Findings>();
        private List<Supplier> selectedSupplier = new List<Supplier>();
        int findingId = 0;
        public FindingForm()
        {
            InitializeComponent();
            supplier.Add(new Supplier(0,"Supplier1"));
            supplier.Add(new Supplier(0, "Supplier2"));
            supplier.Add(new Supplier(0, "Supplier3"));
            supplier.Add(new Supplier(0, "Supplier4"));
            supplier.Add(new Supplier(0, "Supplier5"));
            foreach (Supplier s in supplier)
            {
                cboSuppliers.Items.Add(s.Name);
            }
            cboSuppliers.SelectedIndex = 0;
            cboSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            lsvFindings.Columns.Add("ID");
            lsvFindings.Columns.Add("Name");
            lsvFindings.Columns.Add("Color");
            lsvFindings.View = View.Details;
            lsvFindings.MultiSelect = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboSuppliers.SelectedItem == null)
            {
                MessageBox.Show("Must select a supplier");
                return;
            }
            if (!selectedSupplier.Contains(supplier.ElementAt(cboSuppliers.SelectedIndex)))
            {
                selectedSupplier.Add(supplier.ElementAt(cboSuppliers.SelectedIndex));
                UpdateSupplierList();
                btnRemove.Enabled = true;
            }
            


        }

        private void UpdateSupplierList(){
            lstSuppliers.Items.Clear();
                foreach(Supplier s in selectedSupplier){
                    lstSuppliers.Items.Add(s.Name);
                }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSuppliers.SelectedItem == null)
            {
                MessageBox.Show("Must select a supplier to remove");
                return;
            }
            if (selectedSupplier.Count > 0)
            {
                selectedSupplier.RemoveAt(lstSuppliers.SelectedIndex);
                UpdateSupplierList();
                if (selectedSupplier.Count <= 0)
                {
                    btnRemove.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Nothing to remove");
            }

        }

        private void btnSaveFinding_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckIfIsDecimalNumber(txtFindingPrice.Text))
                {
                    MessageBox.Show("Price must be a number");
                    return;
                }
                if (!CheckIfIsWholeNumber(txtFindingQuantity.Text))
                {
                    MessageBox.Show("Quantity must be a whole number");
                    return;
                }
                    try
                    {
                        findingId = GetNextFindingID();
                        findings.Add(new Findings(findingId, txtFindingName.Text));
                        findings.ElementAt(findingId).Price = Convert.ToDouble(txtFindingPrice.Text);
                        findings.ElementAt(findingId).QuantityOnHand = Convert.ToInt32(txtFindingQuantity.Text);
                        findings.ElementAt(findingId).Description = txtFindingDescription.Text;
                        findings.ElementAt(findingId).Color = txtFindingColor.Text;
                        findings.ElementAt(findingId).SupplierList = new List<Supplier>(selectedSupplier);
                        UpdateFindingsList();
                        ToggleSLABox();
                        btnDeleteFinding.Enabled = true;
                        btnUpdateFinding.Enabled = true;
                    }
                    catch (NullReferenceException nre)
                    {
                        System.Console.WriteLine(nre);
                    }
                    catch (InvalidCastException ice)
                    {
                        System.Console.WriteLine(ice);
                    }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private int GetNextFindingID()
        {
            if (findings.Count <= 0)
            {
                return 0;
            }
            else
            {
                return findings.ElementAt(findings.Count-1).Id + 1;
            }
        }

        private void UpdateFindingsList()
        {
            lsvFindings.Items.Clear();
            foreach (Findings f in findings)
            {
                var additem = new ListViewItem(new string[] { f.Id.ToString(), f.Name, f.Color });
                lsvFindings.Items.Add(additem);
            }
        }

        private void btnUpdateFinding_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvFindings.SelectedItems.Count > 0)
                {

                    if (!CheckIfIsDecimalNumber(txtFindingPrice.Text))
                    {
                        MessageBox.Show("Price must be a number");
                        return;
                    }
                    if (!CheckIfIsWholeNumber(txtFindingQuantity.Text))
                    {
                        MessageBox.Show("Quantity must be a whole number");
                        return;
                    }
                    try
                    {
                        findingId = lsvFindings.FocusedItem.Index;
                        findings.ElementAt(findingId).Price = Convert.ToDouble(txtFindingPrice.Text);
                        findings.ElementAt(findingId).QuantityOnHand = Convert.ToInt32(txtFindingQuantity.Text);
                        findings.ElementAt(findingId).Description = txtFindingDescription.Text;
                        findings.ElementAt(findingId).Color = txtFindingColor.Text;
                        findings.ElementAt(findingId).SupplierList = new List<Supplier>(selectedSupplier);
                        UpdateFindingsList();
                    }
                    catch (NullReferenceException nre)
                    {
                        System.Console.WriteLine(nre);
                    }
                    catch (InvalidCastException ice)
                    {
                        System.Console.WriteLine(ice);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private void btnDeleteFinding_Click(object sender, EventArgs e)
        {
            try
            {
                if (findings.Count > 0 && lsvFindings.SelectedItems.Count > 0)
                {
                    findings.RemoveAt(lsvFindings.FocusedItem.Index);
                    UpdateFindingsList();
                    lstSuppliers.Items.Clear();
                    if (findings.Count <= 0)
                    {
                        btnDeleteFinding.Enabled = false;
                        btnUpdateFinding.Enabled = false;
                    }
                    ToggleSLABox();
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

        private void btnSaveSLA_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvFindings.SelectedItems.Count > 0)
                {
                    if(!CheckIfIsWholeNumber(txtSLAAmount.Text)){
                        MessageBox.Show("Amount must be a whole number");
                        return;
                    }
                    if (!CheckIfIsDecimalNumber(txtSLACost.Text))
                    {
                        MessageBox.Show("Cost must be a number");
                        return;
                    }

                    int SLAID = GetNextSLAID();

                    try
                    {
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.Add(new SLA(SLAID, findings.ElementAt(lsvFindings.FocusedItem.Index).Id));
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).Amount = Convert.ToInt32(txtSLAAmount.Text);
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).Cost = Convert.ToDouble(txtSLACost.Text);
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).DeliveryTime = dateSLA.Value;
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).Description = txtSLADescription.Text;
                        UpdateSLAList();
                    }
                    catch (NullReferenceException nre)
                    {
                        System.Console.WriteLine(nre);
                    }
                    catch (InvalidCastException ice)
                    {
                        System.Console.WriteLine(ice);
                    }
                }
                else
                {
                    MessageBox.Show("Must select a finding first");
                    return;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private int GetNextSLAID()
        {
            if (findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.Count <= 0)
            {
                return 0;
            }
            else
            {
                return findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.Count-1).Id +1;
            }
        }

        private void UpdateSLAList()
        {
            lstSLA.Items.Clear();
            foreach (SLA s in findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList)
            {
                lstSLA.Items.Add(s.Id);
            }
        }

        private void btnUpdateSLA_Click(object sender, EventArgs e)
        {
            int SLAID = lstSLA.SelectedIndex;
            try
            {
                if (lsvFindings.SelectedItems.Count > 0)
                {
                    if (!CheckIfIsWholeNumber(txtSLAAmount.Text))
                    {
                        MessageBox.Show("Amount must be a whole number");
                        return;
                    }
                    if (!CheckIfIsDecimalNumber(txtSLACost.Text))
                    {
                        MessageBox.Show("Cost must be a number");
                        return;
                    }
                    try
                    {
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).Amount = Convert.ToInt32(txtSLAAmount.Text);
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).Cost = Convert.ToDouble(txtSLACost.Text);
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).DeliveryTime = dateSLA.Value;
                        findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(SLAID).Description = txtSLADescription.Text;
                        UpdateSLAList();
                    }
                    catch (NullReferenceException nre)
                    {
                        System.Console.WriteLine(nre);
                    }
                    catch (InvalidCastException ice)
                    {
                        System.Console.WriteLine(ice);
                    }
                }
                else
                {
                    MessageBox.Show("Must select a finding first");
                    return;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private void btnDeleteSLA_Click(object sender, EventArgs e)
        {
            try
            {
                if (findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.Count > 0 && lstSLA.SelectedItem != null)
                {
                    findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.RemoveAt(lstSLA.SelectedIndex);
                    UpdateSLAList();
                    if (findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.Count <= 0)
                    {
                        btnDeleteSLA.Enabled = false;
                        btnUpdateSLA.Enabled = false;
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

        private bool CheckIfIsWholeNumber(string input)
        {
            int i;
            return int.TryParse(input, out i);
        }

        private bool CheckIfIsDecimalNumber(string input)
        {
            double d;
            return double.TryParse(input, out d);
        }

        private void lsvFindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvFindings.FocusedItem != null)
            {
                txtFindingColor.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Color;
                txtFindingDescription.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Color;
                txtFindingID.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Color;
                txtFindingName.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Name;
                txtFindingPrice.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Price.ToString();
                txtFindingQuantity.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).QuantityOnHand.ToString();
                try
                {
                    if (findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.Count> 0) ;
                    {
                        UpdateSLAList();
                    }
                }
                catch (NullReferenceException nre)
                {
                    System.Console.WriteLine(nre);
                }
            }
        }

        private void lstSLA_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSLAAmount.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(lstSLA.SelectedIndex).Amount.ToString();
                txtSLACost.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(lstSLA.SelectedIndex).Cost.ToString();
                txtSLADescription.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(lstSLA.SelectedIndex).Description;
                txtSLAID.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(lstSLA.SelectedIndex).Id.ToString();
                dateSLA.Value = findings.ElementAt(lsvFindings.FocusedItem.Index).SlaList.ElementAt(lstSLA.SelectedIndex).DeliveryTime;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private void ToggleSLABox(){
            if (findings.Count > 0)
            {
                gbxSLA.Enabled = true;
            }
            else
            {
                gbxSLA.Enabled = false;
            }
        }

        private void ClearBoxFields(GroupBox b)
        {
            foreach (Control c in b.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}

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
    public partial class FindingUpdateForm : Form
    {
        private List<Findings> findings = new List<Findings>();
        int findingId = 0;
        public FindingUpdateForm(List<Findings> f)
        {
            InitializeComponent();
            //cboSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            lsvFindings.Columns.Add("ID");
            lsvFindings.Columns.Add("Name");
            lsvFindings.Columns.Add("Color");
            lsvFindings.View = View.Details;
            lsvFindings.MultiSelect = false;
            if (f.Count > 0)
            {
                findings = new List<Findings>(f);
                UpdateFindingsList();
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

                    if (!CheckIfIsWholeNumber(txtFindingQuantity.Text))
                    {
                        MessageBox.Show("Quantity must be a whole number");
                        return;
                    }
                    try
                    {
                        findingId = lsvFindings.FocusedItem.Index;
                        findings.ElementAt(findingId).QuantityOnHand = Convert.ToInt32(txtFindingQuantity.Text);
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

     
       

        private bool CheckIfIsWholeNumber(string input)
        {
            int i;
            return int.TryParse(input, out i);
        }

    

        private void lsvFindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lsvFindings.FocusedItem != null)
            {
                txtFindingColor.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Color;
                txtFindingDescription.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Description;
                txtFindingID.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Id.ToString();
                txtFindingName.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Name;
                txtFindingPrice.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Price.ToString();
                txtFindingQuantity.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).QuantityOnHand.ToString();
                txtSupplier.Text = findings.ElementAt(lsvFindings.FocusedItem.Index).Supplier.Name;

               
            }
        }
    }
}

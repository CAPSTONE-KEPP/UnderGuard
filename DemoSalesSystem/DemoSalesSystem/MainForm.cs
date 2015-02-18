﻿using System;
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

        public MainForm()
        {
            InitializeComponent();
            txtMFId.Text = (lstMFindings.Items.Count + 1).ToString();
        }

        private void btnMFClear_Click(object sender, EventArgs e)
        {
            MFClear();
        }

        private void btnMFSave_Click(object sender, EventArgs e)
        {
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
                //Valid fields for save.
                txtMFId.Text = (lstMFindings.Items.Count + 1).ToString();
                MFClear();
            }
            else 
            {
                MessageBox.Show("Please enter valid fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            goodMFSave = true;
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
        }

        private void findingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMFindings.Visible = true;
            pnlMOrder.Visible = false;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMFindings.Visible = false;
            pnlMOrder.Visible = true;
        }

        private void btnMOClear_Click(object sender, EventArgs e)
        {
            MOClear(); 
        }

        private void btnMOSave_Click(object sender, EventArgs e)
        {
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
                //lstMOOrders.Items.Add("");
            }
            else 
            {
                MessageBox.Show("Please enter valid fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            goodMOSave = true;
        }

        private void btnMODelete_Click(object sender, EventArgs e)
        {
            //btn Manu Order Delete is clicked, delete Manu Order Obj from lst...
        }

        private void btnMOUpdate_Click(object sender, EventArgs e)
        {
            //btn Manu Order Update is clicked, update Manu Order Obj from lst...
        }


        
    }
}

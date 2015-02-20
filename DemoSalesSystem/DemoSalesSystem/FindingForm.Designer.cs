namespace DemoSalesSystem
{
    partial class FindingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtFindingID = new System.Windows.Forms.TextBox();
            this.txtFindingName = new System.Windows.Forms.TextBox();
            this.txtFindingDescription = new System.Windows.Forms.TextBox();
            this.txtFindingPrice = new System.Windows.Forms.TextBox();
            this.txtFindingColor = new System.Windows.Forms.TextBox();
            this.txtFindingQuantity = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.btnSaveSLA = new System.Windows.Forms.Button();
            this.btnUpdateSLA = new System.Windows.Forms.Button();
            this.btnDeleteSLA = new System.Windows.Forms.Button();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstSLA = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDeleteFinding = new System.Windows.Forms.Button();
            this.btnUpdateFinding = new System.Windows.Forms.Button();
            this.btnSaveFinding = new System.Windows.Forms.Button();
            this.gbxFindings = new System.Windows.Forms.GroupBox();
            this.lblFindings = new System.Windows.Forms.Label();
            this.lblSupplierList = new System.Windows.Forms.Label();
            this.lsvFindings = new System.Windows.Forms.ListView();
            this.gbxSLA = new System.Windows.Forms.GroupBox();
            this.dateSLA = new System.Windows.Forms.DateTimePicker();
            this.txtSLADescription = new System.Windows.Forms.TextBox();
            this.txtSLACost = new System.Windows.Forms.TextBox();
            this.txtSLAAmount = new System.Windows.Forms.TextBox();
            this.txtSLAID = new System.Windows.Forms.TextBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblSLADescription = new System.Windows.Forms.Label();
            this.lblSLACost = new System.Windows.Forms.Label();
            this.lblSLAAmount = new System.Windows.Forms.Label();
            this.lblSLAID = new System.Windows.Forms.Label();
            this.gbxFindings.SuspendLayout();
            this.gbxSLA.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(26, 136);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(26, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(26, 213);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(95, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity On Hand:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(26, 178);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // txtFindingID
            // 
            this.txtFindingID.Enabled = false;
            this.txtFindingID.Location = new System.Drawing.Point(93, 35);
            this.txtFindingID.Name = "txtFindingID";
            this.txtFindingID.Size = new System.Drawing.Size(55, 20);
            this.txtFindingID.TabIndex = 6;
            // 
            // txtFindingName
            // 
            this.txtFindingName.Location = new System.Drawing.Point(93, 67);
            this.txtFindingName.Name = "txtFindingName";
            this.txtFindingName.Size = new System.Drawing.Size(100, 20);
            this.txtFindingName.TabIndex = 7;
            // 
            // txtFindingDescription
            // 
            this.txtFindingDescription.Location = new System.Drawing.Point(93, 101);
            this.txtFindingDescription.Name = "txtFindingDescription";
            this.txtFindingDescription.Size = new System.Drawing.Size(239, 20);
            this.txtFindingDescription.TabIndex = 8;
            // 
            // txtFindingPrice
            // 
            this.txtFindingPrice.Location = new System.Drawing.Point(93, 136);
            this.txtFindingPrice.Name = "txtFindingPrice";
            this.txtFindingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtFindingPrice.TabIndex = 9;
            // 
            // txtFindingColor
            // 
            this.txtFindingColor.Location = new System.Drawing.Point(93, 178);
            this.txtFindingColor.Name = "txtFindingColor";
            this.txtFindingColor.Size = new System.Drawing.Size(100, 20);
            this.txtFindingColor.TabIndex = 10;
            // 
            // txtFindingQuantity
            // 
            this.txtFindingQuantity.Location = new System.Drawing.Point(127, 210);
            this.txtFindingQuantity.Name = "txtFindingQuantity";
            this.txtFindingQuantity.Size = new System.Drawing.Size(66, 20);
            this.txtFindingQuantity.TabIndex = 11;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(209, 35);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = "Supplier:";
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Location = new System.Drawing.Point(282, 32);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cboSuppliers.TabIndex = 14;
            // 
            // btnSaveSLA
            // 
            this.btnSaveSLA.Location = new System.Drawing.Point(267, 169);
            this.btnSaveSLA.Name = "btnSaveSLA";
            this.btnSaveSLA.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSLA.TabIndex = 17;
            this.btnSaveSLA.Text = "Save";
            this.btnSaveSLA.UseVisualStyleBackColor = true;
            this.btnSaveSLA.Click += new System.EventHandler(this.btnSaveSLA_Click);
            // 
            // btnUpdateSLA
            // 
            this.btnUpdateSLA.Enabled = false;
            this.btnUpdateSLA.Location = new System.Drawing.Point(348, 169);
            this.btnUpdateSLA.Name = "btnUpdateSLA";
            this.btnUpdateSLA.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSLA.TabIndex = 18;
            this.btnUpdateSLA.Text = "Update";
            this.btnUpdateSLA.UseVisualStyleBackColor = true;
            this.btnUpdateSLA.Click += new System.EventHandler(this.btnUpdateSLA_Click);
            // 
            // btnDeleteSLA
            // 
            this.btnDeleteSLA.Enabled = false;
            this.btnDeleteSLA.Location = new System.Drawing.Point(430, 169);
            this.btnDeleteSLA.Name = "btnDeleteSLA";
            this.btnDeleteSLA.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSLA.TabIndex = 19;
            this.btnDeleteSLA.Text = "Delete";
            this.btnDeleteSLA.UseVisualStyleBackColor = true;
            this.btnDeleteSLA.Click += new System.EventHandler(this.btnDeleteSLA_Click);
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(409, 32);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(163, 199);
            this.lstSuppliers.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SLA IDs:";
            // 
            // lstSLA
            // 
            this.lstSLA.FormattingEnabled = true;
            this.lstSLA.Location = new System.Drawing.Point(57, 19);
            this.lstSLA.Name = "lstSLA";
            this.lstSLA.Size = new System.Drawing.Size(121, 173);
            this.lstSLA.TabIndex = 22;
            this.lstSLA.SelectedIndexChanged += new System.EventHandler(this.lstSLA_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(282, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(348, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(55, 23);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDeleteFinding
            // 
            this.btnDeleteFinding.Enabled = false;
            this.btnDeleteFinding.Location = new System.Drawing.Point(784, 250);
            this.btnDeleteFinding.Name = "btnDeleteFinding";
            this.btnDeleteFinding.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFinding.TabIndex = 27;
            this.btnDeleteFinding.Text = "Delete";
            this.btnDeleteFinding.UseVisualStyleBackColor = true;
            this.btnDeleteFinding.Click += new System.EventHandler(this.btnDeleteFinding_Click);
            // 
            // btnUpdateFinding
            // 
            this.btnUpdateFinding.Enabled = false;
            this.btnUpdateFinding.Location = new System.Drawing.Point(702, 250);
            this.btnUpdateFinding.Name = "btnUpdateFinding";
            this.btnUpdateFinding.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFinding.TabIndex = 26;
            this.btnUpdateFinding.Text = "Update";
            this.btnUpdateFinding.UseVisualStyleBackColor = true;
            this.btnUpdateFinding.Click += new System.EventHandler(this.btnUpdateFinding_Click);
            // 
            // btnSaveFinding
            // 
            this.btnSaveFinding.Location = new System.Drawing.Point(621, 250);
            this.btnSaveFinding.Name = "btnSaveFinding";
            this.btnSaveFinding.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFinding.TabIndex = 25;
            this.btnSaveFinding.Text = "Save";
            this.btnSaveFinding.UseVisualStyleBackColor = true;
            this.btnSaveFinding.Click += new System.EventHandler(this.btnSaveFinding_Click);
            // 
            // gbxFindings
            // 
            this.gbxFindings.Controls.Add(this.lblFindings);
            this.gbxFindings.Controls.Add(this.lblSupplierList);
            this.gbxFindings.Controls.Add(this.lsvFindings);
            this.gbxFindings.Controls.Add(this.btnDeleteFinding);
            this.gbxFindings.Controls.Add(this.lblID);
            this.gbxFindings.Controls.Add(this.btnUpdateFinding);
            this.gbxFindings.Controls.Add(this.lblName);
            this.gbxFindings.Controls.Add(this.btnSaveFinding);
            this.gbxFindings.Controls.Add(this.lblDescription);
            this.gbxFindings.Controls.Add(this.btnRemove);
            this.gbxFindings.Controls.Add(this.lblPrice);
            this.gbxFindings.Controls.Add(this.btnAdd);
            this.gbxFindings.Controls.Add(this.lblColor);
            this.gbxFindings.Controls.Add(this.lblQuantity);
            this.gbxFindings.Controls.Add(this.txtFindingID);
            this.gbxFindings.Controls.Add(this.lstSuppliers);
            this.gbxFindings.Controls.Add(this.txtFindingName);
            this.gbxFindings.Controls.Add(this.txtFindingDescription);
            this.gbxFindings.Controls.Add(this.txtFindingPrice);
            this.gbxFindings.Controls.Add(this.txtFindingColor);
            this.gbxFindings.Controls.Add(this.cboSuppliers);
            this.gbxFindings.Controls.Add(this.txtFindingQuantity);
            this.gbxFindings.Controls.Add(this.lblSupplier);
            this.gbxFindings.Location = new System.Drawing.Point(12, 12);
            this.gbxFindings.Name = "gbxFindings";
            this.gbxFindings.Size = new System.Drawing.Size(886, 296);
            this.gbxFindings.TabIndex = 28;
            this.gbxFindings.TabStop = false;
            this.gbxFindings.Text = "Findings";
            // 
            // lblFindings
            // 
            this.lblFindings.AutoSize = true;
            this.lblFindings.Location = new System.Drawing.Point(656, 16);
            this.lblFindings.Name = "lblFindings";
            this.lblFindings.Size = new System.Drawing.Size(49, 13);
            this.lblFindings.TabIndex = 30;
            this.lblFindings.Text = "Findings:";
            // 
            // lblSupplierList
            // 
            this.lblSupplierList.AutoSize = true;
            this.lblSupplierList.Location = new System.Drawing.Point(406, 16);
            this.lblSupplierList.Name = "lblSupplierList";
            this.lblSupplierList.Size = new System.Drawing.Size(53, 13);
            this.lblSupplierList.TabIndex = 29;
            this.lblSupplierList.Text = "Suppliers:";
            // 
            // lsvFindings
            // 
            this.lsvFindings.Location = new System.Drawing.Point(659, 32);
            this.lsvFindings.Name = "lsvFindings";
            this.lsvFindings.Size = new System.Drawing.Size(226, 199);
            this.lsvFindings.TabIndex = 28;
            this.lsvFindings.UseCompatibleStateImageBehavior = false;
            this.lsvFindings.SelectedIndexChanged += new System.EventHandler(this.lsvFindings_SelectedIndexChanged);
            // 
            // gbxSLA
            // 
            this.gbxSLA.Controls.Add(this.dateSLA);
            this.gbxSLA.Controls.Add(this.txtSLADescription);
            this.gbxSLA.Controls.Add(this.txtSLACost);
            this.gbxSLA.Controls.Add(this.txtSLAAmount);
            this.gbxSLA.Controls.Add(this.txtSLAID);
            this.gbxSLA.Controls.Add(this.lblDelivery);
            this.gbxSLA.Controls.Add(this.lblSLADescription);
            this.gbxSLA.Controls.Add(this.lblSLACost);
            this.gbxSLA.Controls.Add(this.lblSLAAmount);
            this.gbxSLA.Controls.Add(this.lblSLAID);
            this.gbxSLA.Controls.Add(this.lstSLA);
            this.gbxSLA.Controls.Add(this.label8);
            this.gbxSLA.Controls.Add(this.btnDeleteSLA);
            this.gbxSLA.Controls.Add(this.btnUpdateSLA);
            this.gbxSLA.Controls.Add(this.btnSaveSLA);
            this.gbxSLA.Enabled = false;
            this.gbxSLA.Location = new System.Drawing.Point(12, 323);
            this.gbxSLA.Name = "gbxSLA";
            this.gbxSLA.Size = new System.Drawing.Size(592, 231);
            this.gbxSLA.TabIndex = 29;
            this.gbxSLA.TabStop = false;
            this.gbxSLA.Text = "SLA";
            // 
            // dateSLA
            // 
            this.dateSLA.Location = new System.Drawing.Point(335, 127);
            this.dateSLA.Name = "dateSLA";
            this.dateSLA.Size = new System.Drawing.Size(200, 20);
            this.dateSLA.TabIndex = 33;
            // 
            // txtSLADescription
            // 
            this.txtSLADescription.Location = new System.Drawing.Point(335, 96);
            this.txtSLADescription.Name = "txtSLADescription";
            this.txtSLADescription.Size = new System.Drawing.Size(237, 20);
            this.txtSLADescription.TabIndex = 32;
            // 
            // txtSLACost
            // 
            this.txtSLACost.Location = new System.Drawing.Point(335, 70);
            this.txtSLACost.Name = "txtSLACost";
            this.txtSLACost.Size = new System.Drawing.Size(92, 20);
            this.txtSLACost.TabIndex = 31;
            // 
            // txtSLAAmount
            // 
            this.txtSLAAmount.Location = new System.Drawing.Point(335, 43);
            this.txtSLAAmount.Name = "txtSLAAmount";
            this.txtSLAAmount.Size = new System.Drawing.Size(92, 20);
            this.txtSLAAmount.TabIndex = 30;
            // 
            // txtSLAID
            // 
            this.txtSLAID.Enabled = false;
            this.txtSLAID.Location = new System.Drawing.Point(335, 20);
            this.txtSLAID.Name = "txtSLAID";
            this.txtSLAID.Size = new System.Drawing.Size(58, 20);
            this.txtSLAID.TabIndex = 29;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(245, 133);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(74, 13);
            this.lblDelivery.TabIndex = 28;
            this.lblDelivery.Text = "Delivery Time:";
            // 
            // lblSLADescription
            // 
            this.lblSLADescription.AutoSize = true;
            this.lblSLADescription.Location = new System.Drawing.Point(256, 99);
            this.lblSLADescription.Name = "lblSLADescription";
            this.lblSLADescription.Size = new System.Drawing.Size(63, 13);
            this.lblSLADescription.TabIndex = 26;
            this.lblSLADescription.Text = "Description:";
            // 
            // lblSLACost
            // 
            this.lblSLACost.AutoSize = true;
            this.lblSLACost.Location = new System.Drawing.Point(288, 73);
            this.lblSLACost.Name = "lblSLACost";
            this.lblSLACost.Size = new System.Drawing.Size(31, 13);
            this.lblSLACost.TabIndex = 25;
            this.lblSLACost.Text = "Cost:";
            // 
            // lblSLAAmount
            // 
            this.lblSLAAmount.AutoSize = true;
            this.lblSLAAmount.Location = new System.Drawing.Point(273, 46);
            this.lblSLAAmount.Name = "lblSLAAmount";
            this.lblSLAAmount.Size = new System.Drawing.Size(46, 13);
            this.lblSLAAmount.TabIndex = 24;
            this.lblSLAAmount.Text = "Amount:";
            // 
            // lblSLAID
            // 
            this.lblSLAID.AutoSize = true;
            this.lblSLAID.Location = new System.Drawing.Point(298, 23);
            this.lblSLAID.Name = "lblSLAID";
            this.lblSLAID.Size = new System.Drawing.Size(21, 13);
            this.lblSLAID.TabIndex = 23;
            this.lblSLAID.Text = "ID:";
            // 
            // FindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 560);
            this.Controls.Add(this.gbxSLA);
            this.Controls.Add(this.gbxFindings);
            this.Name = "FindingForm";
            this.Text = "FindingForm";
            this.gbxFindings.ResumeLayout(false);
            this.gbxFindings.PerformLayout();
            this.gbxSLA.ResumeLayout(false);
            this.gbxSLA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtFindingID;
        private System.Windows.Forms.TextBox txtFindingName;
        private System.Windows.Forms.TextBox txtFindingDescription;
        private System.Windows.Forms.TextBox txtFindingPrice;
        private System.Windows.Forms.TextBox txtFindingColor;
        private System.Windows.Forms.TextBox txtFindingQuantity;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cboSuppliers;
        private System.Windows.Forms.Button btnSaveSLA;
        private System.Windows.Forms.Button btnUpdateSLA;
        private System.Windows.Forms.Button btnDeleteSLA;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSLA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDeleteFinding;
        private System.Windows.Forms.Button btnUpdateFinding;
        private System.Windows.Forms.Button btnSaveFinding;
        private System.Windows.Forms.GroupBox gbxFindings;
        private System.Windows.Forms.GroupBox gbxSLA;
        private System.Windows.Forms.Label lblSLAAmount;
        private System.Windows.Forms.Label lblSLAID;
        private System.Windows.Forms.DateTimePicker dateSLA;
        private System.Windows.Forms.TextBox txtSLADescription;
        private System.Windows.Forms.TextBox txtSLACost;
        private System.Windows.Forms.TextBox txtSLAAmount;
        private System.Windows.Forms.TextBox txtSLAID;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblSLADescription;
        private System.Windows.Forms.Label lblSLACost;
        private System.Windows.Forms.ListView lsvFindings;
        private System.Windows.Forms.Label lblFindings;
        private System.Windows.Forms.Label lblSupplierList;
    }
}
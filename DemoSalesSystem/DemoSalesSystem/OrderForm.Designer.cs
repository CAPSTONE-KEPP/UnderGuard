namespace DemoSalesSystem
{
    partial class OrderForm
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
            this.lsvCurrentOrder = new System.Windows.Forms.ListView();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblIdTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lsvOrders = new System.Windows.Forms.ListView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.cboContact = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvCurrentOrder
            // 
            this.lsvCurrentOrder.Location = new System.Drawing.Point(14, 30);
            this.lsvCurrentOrder.Name = "lsvCurrentOrder";
            this.lsvCurrentOrder.Size = new System.Drawing.Size(174, 336);
            this.lsvCurrentOrder.TabIndex = 0;
            this.lsvCurrentOrder.UseCompatibleStateImageBehavior = false;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(533, 30);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(179, 342);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // lblIdTitle
            // 
            this.lblIdTitle.AutoSize = true;
            this.lblIdTitle.Location = new System.Drawing.Point(194, 13);
            this.lblIdTitle.Name = "lblIdTitle";
            this.lblIdTitle.Size = new System.Drawing.Size(22, 13);
            this.lblIdTitle.TabIndex = 2;
            this.lblIdTitle.Text = "Id: ";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(194, 30);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(41, 13);
            this.lblNameTitle.TabIndex = 3;
            this.lblNameTitle.Text = "Name: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(251, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(10, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(251, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "-";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(197, 54);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(197, 94);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(441, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(252, 52);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
            this.nudQuantity.Size = new System.Drawing.Size(56, 20);
            this.nudQuantity.TabIndex = 11;
            // 
            // lsvOrders
            // 
            this.lsvOrders.Location = new System.Drawing.Point(193, 384);
            this.lsvOrders.Name = "lsvOrders";
            this.lsvOrders.Size = new System.Drawing.Size(337, 115);
            this.lsvOrders.TabIndex = 12;
            this.lsvOrders.UseCompatibleStateImageBehavior = false;
            this.lsvOrders.SelectedIndexChanged += new System.EventHandler(this.lsvOrders_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(200, 143);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(57, 13);
            this.lblCompany.TabIndex = 15;
            this.lblCompany.Text = "Company: ";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(200, 166);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(50, 13);
            this.lblContact.TabIndex = 16;
            this.lblContact.Text = "Contact: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(200, 189);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status: ";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(200, 215);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 13);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes: ";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(194, 246);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(65, 13);
            this.lblOrderDate.TabIndex = 19;
            this.lblOrderDate.Text = "Order Date: ";
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(257, 139);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(121, 21);
            this.cboCompany.TabIndex = 20;
            this.cboCompany.SelectedIndexChanged += new System.EventHandler(this.cboCompany_SelectedIndexChanged);
            // 
            // cboContact
            // 
            this.cboContact.FormattingEnabled = true;
            this.cboContact.Location = new System.Drawing.Point(257, 163);
            this.cboContact.Name = "cboContact";
            this.cboContact.Size = new System.Drawing.Size(121, 21);
            this.cboContact.TabIndex = 21;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(257, 186);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 22;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(257, 212);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(274, 20);
            this.txtNotes.TabIndex = 23;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(257, 243);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 24;
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(13, 11);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentOrder.TabIndex = 25;
            this.lblCurrentOrder.Text = "Current Order:";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(533, 12);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(55, 13);
            this.lblProducts.TabIndex = 26;
            this.lblProducts.Text = "Products: ";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(195, 365);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(41, 13);
            this.lblOrders.TabIndex = 27;
            this.lblOrders.Text = "Orders:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 500);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboContact);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lsvOrders);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblIdTitle);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lsvCurrentOrder);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvCurrentOrder;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblIdTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ListView lsvOrders;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.ComboBox cboContact;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblOrders;
    }
}
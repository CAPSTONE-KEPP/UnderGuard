namespace DemoSalesSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.findingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMFindings = new System.Windows.Forms.Panel();
            this.grpMFDescription = new System.Windows.Forms.GroupBox();
            this.txtMFDescription = new System.Windows.Forms.TextBox();
            this.grpMFSLA = new System.Windows.Forms.GroupBox();
            this.txtMFSLA = new System.Windows.Forms.TextBox();
            this.btnMFUpdate = new System.Windows.Forms.Button();
            this.btnMFSave = new System.Windows.Forms.Button();
            this.btnMFDelete = new System.Windows.Forms.Button();
            this.btnMFClear = new System.Windows.Forms.Button();
            this.txtMFPrice = new System.Windows.Forms.TextBox();
            this.lblMFPrice = new System.Windows.Forms.Label();
            this.txtMFQuantityOnHand = new System.Windows.Forms.TextBox();
            this.lblMFQuanityOnHand = new System.Windows.Forms.Label();
            this.txtMFColor = new System.Windows.Forms.TextBox();
            this.lblMFColor = new System.Windows.Forms.Label();
            this.txtMFSupplier = new System.Windows.Forms.TextBox();
            this.lblMFSupplier = new System.Windows.Forms.Label();
            this.txtMFName = new System.Windows.Forms.TextBox();
            this.lblMFName = new System.Windows.Forms.Label();
            this.txtMFId = new System.Windows.Forms.TextBox();
            this.lblMFId = new System.Windows.Forms.Label();
            this.lstMFindings = new System.Windows.Forms.ListBox();
            this.lblMFindings = new System.Windows.Forms.Label();
            this.pnlMOrder = new System.Windows.Forms.Panel();
            this.grpMONotes = new System.Windows.Forms.GroupBox();
            this.txtMONotes = new System.Windows.Forms.TextBox();
            this.lblMODate = new System.Windows.Forms.Label();
            this.dtpMODate = new System.Windows.Forms.DateTimePicker();
            this.btnMOUpdate = new System.Windows.Forms.Button();
            this.btnMOSave = new System.Windows.Forms.Button();
            this.btnMODelete = new System.Windows.Forms.Button();
            this.btnMOClear = new System.Windows.Forms.Button();
            this.txtMOType = new System.Windows.Forms.TextBox();
            this.lblMOType = new System.Windows.Forms.Label();
            this.cmbMOOrderStatus = new System.Windows.Forms.ComboBox();
            this.lblMOOrderStatus = new System.Windows.Forms.Label();
            this.cmbMOCompanyContact = new System.Windows.Forms.ComboBox();
            this.cmbMOCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMOCompanyContact = new System.Windows.Forms.Label();
            this.lblMOCompany = new System.Windows.Forms.Label();
            this.lstMOOrders = new System.Windows.Forms.ListBox();
            this.lblMOOrder = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.pnlMFindings.SuspendLayout();
            this.grpMFDescription.SuspendLayout();
            this.grpMFSLA.SuspendLayout();
            this.pnlMOrder.SuspendLayout();
            this.grpMONotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.manufacturingToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.catalogToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.catalogToolStripMenuItem.Text = "Catalog";
            this.catalogToolStripMenuItem.Click += new System.EventHandler(this.catalogToolStripMenuItem_Click_1);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click_1);
            // 
            // manufacturingToolStripMenuItem
            // 
            this.manufacturingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.ordersToolStripMenuItem,
            this.findingsToolStripMenuItem});
            this.manufacturingToolStripMenuItem.Name = "manufacturingToolStripMenuItem";
            this.manufacturingToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.manufacturingToolStripMenuItem.Text = "Manufacturing";
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.productsToolStripMenuItem1.Text = "Product";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.productsToolStripMenuItem1_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.ordersToolStripMenuItem.Text = "Order";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // findingsToolStripMenuItem
            // 
            this.findingsToolStripMenuItem.Name = "findingsToolStripMenuItem";
            this.findingsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.findingsToolStripMenuItem.Text = "Finding";
            this.findingsToolStripMenuItem.Click += new System.EventHandler(this.findingsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suppliersToolStripMenuItem,
            this.ordersToolStripMenuItem1,
            this.productsToolStripMenuItem2,
            this.findingsToolStripMenuItem1});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.suppliersToolStripMenuItem.Text = "Supplier";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click_1);
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.ordersToolStripMenuItem1.Text = "Order";
            this.ordersToolStripMenuItem1.Click += new System.EventHandler(this.ordersToolStripMenuItem1_Click);
            // 
            // productsToolStripMenuItem2
            // 
            this.productsToolStripMenuItem2.Name = "productsToolStripMenuItem2";
            this.productsToolStripMenuItem2.Size = new System.Drawing.Size(175, 24);
            this.productsToolStripMenuItem2.Text = "Product";
            this.productsToolStripMenuItem2.Click += new System.EventHandler(this.productsToolStripMenuItem2_Click_1);
            // 
            // findingsToolStripMenuItem1
            // 
            this.findingsToolStripMenuItem1.Name = "findingsToolStripMenuItem1";
            this.findingsToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.findingsToolStripMenuItem1.Text = "Finding";
            this.findingsToolStripMenuItem1.Click += new System.EventHandler(this.findingsToolStripMenuItem1_Click_1);
            // 
            // pnlMFindings
            // 
            this.pnlMFindings.Controls.Add(this.grpMFDescription);
            this.pnlMFindings.Controls.Add(this.grpMFSLA);
            this.pnlMFindings.Controls.Add(this.btnMFUpdate);
            this.pnlMFindings.Controls.Add(this.btnMFSave);
            this.pnlMFindings.Controls.Add(this.btnMFDelete);
            this.pnlMFindings.Controls.Add(this.btnMFClear);
            this.pnlMFindings.Controls.Add(this.txtMFPrice);
            this.pnlMFindings.Controls.Add(this.lblMFPrice);
            this.pnlMFindings.Controls.Add(this.txtMFQuantityOnHand);
            this.pnlMFindings.Controls.Add(this.lblMFQuanityOnHand);
            this.pnlMFindings.Controls.Add(this.txtMFColor);
            this.pnlMFindings.Controls.Add(this.lblMFColor);
            this.pnlMFindings.Controls.Add(this.txtMFSupplier);
            this.pnlMFindings.Controls.Add(this.lblMFSupplier);
            this.pnlMFindings.Controls.Add(this.txtMFName);
            this.pnlMFindings.Controls.Add(this.lblMFName);
            this.pnlMFindings.Controls.Add(this.txtMFId);
            this.pnlMFindings.Controls.Add(this.lblMFId);
            this.pnlMFindings.Controls.Add(this.lstMFindings);
            this.pnlMFindings.Controls.Add(this.lblMFindings);
            this.pnlMFindings.Location = new System.Drawing.Point(0, 33);
            this.pnlMFindings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMFindings.Name = "pnlMFindings";
            this.pnlMFindings.Size = new System.Drawing.Size(843, 522);
            this.pnlMFindings.TabIndex = 2;
            this.pnlMFindings.Visible = false;
            // 
            // grpMFDescription
            // 
            this.grpMFDescription.Controls.Add(this.txtMFDescription);
            this.grpMFDescription.Location = new System.Drawing.Point(185, 210);
            this.grpMFDescription.Margin = new System.Windows.Forms.Padding(4);
            this.grpMFDescription.Name = "grpMFDescription";
            this.grpMFDescription.Padding = new System.Windows.Forms.Padding(4);
            this.grpMFDescription.Size = new System.Drawing.Size(641, 263);
            this.grpMFDescription.TabIndex = 19;
            this.grpMFDescription.TabStop = false;
            this.grpMFDescription.Text = "Description";
            // 
            // txtMFDescription
            // 
            this.txtMFDescription.Location = new System.Drawing.Point(9, 25);
            this.txtMFDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFDescription.Multiline = true;
            this.txtMFDescription.Name = "txtMFDescription";
            this.txtMFDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMFDescription.Size = new System.Drawing.Size(623, 230);
            this.txtMFDescription.TabIndex = 0;
            // 
            // grpMFSLA
            // 
            this.grpMFSLA.Controls.Add(this.txtMFSLA);
            this.grpMFSLA.Location = new System.Drawing.Point(547, 22);
            this.grpMFSLA.Margin = new System.Windows.Forms.Padding(4);
            this.grpMFSLA.Name = "grpMFSLA";
            this.grpMFSLA.Padding = new System.Windows.Forms.Padding(4);
            this.grpMFSLA.Size = new System.Drawing.Size(280, 181);
            this.grpMFSLA.TabIndex = 18;
            this.grpMFSLA.TabStop = false;
            this.grpMFSLA.Text = "SLA";
            // 
            // txtMFSLA
            // 
            this.txtMFSLA.Location = new System.Drawing.Point(9, 25);
            this.txtMFSLA.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFSLA.Multiline = true;
            this.txtMFSLA.Name = "txtMFSLA";
            this.txtMFSLA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMFSLA.Size = new System.Drawing.Size(261, 148);
            this.txtMFSLA.TabIndex = 0;
            // 
            // btnMFUpdate
            // 
            this.btnMFUpdate.Location = new System.Drawing.Point(403, 480);
            this.btnMFUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMFUpdate.Name = "btnMFUpdate";
            this.btnMFUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnMFUpdate.TabIndex = 17;
            this.btnMFUpdate.Text = "Update";
            this.btnMFUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMFSave
            // 
            this.btnMFSave.Enabled = false;
            this.btnMFSave.Location = new System.Drawing.Point(511, 480);
            this.btnMFSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnMFSave.Name = "btnMFSave";
            this.btnMFSave.Size = new System.Drawing.Size(100, 28);
            this.btnMFSave.TabIndex = 16;
            this.btnMFSave.Text = "Save";
            this.btnMFSave.UseVisualStyleBackColor = true;
            // 
            // btnMFDelete
            // 
            this.btnMFDelete.Enabled = false;
            this.btnMFDelete.Location = new System.Drawing.Point(619, 480);
            this.btnMFDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMFDelete.Name = "btnMFDelete";
            this.btnMFDelete.Size = new System.Drawing.Size(100, 28);
            this.btnMFDelete.TabIndex = 15;
            this.btnMFDelete.Text = "Delete";
            this.btnMFDelete.UseVisualStyleBackColor = true;
            // 
            // btnMFClear
            // 
            this.btnMFClear.Location = new System.Drawing.Point(727, 480);
            this.btnMFClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnMFClear.Name = "btnMFClear";
            this.btnMFClear.Size = new System.Drawing.Size(100, 28);
            this.btnMFClear.TabIndex = 14;
            this.btnMFClear.Text = "Clear";
            this.btnMFClear.UseVisualStyleBackColor = true;
            // 
            // txtMFPrice
            // 
            this.txtMFPrice.Location = new System.Drawing.Point(317, 178);
            this.txtMFPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFPrice.Name = "txtMFPrice";
            this.txtMFPrice.Size = new System.Drawing.Size(220, 22);
            this.txtMFPrice.TabIndex = 13;
            // 
            // lblMFPrice
            // 
            this.lblMFPrice.AutoSize = true;
            this.lblMFPrice.Location = new System.Drawing.Point(181, 182);
            this.lblMFPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFPrice.Name = "lblMFPrice";
            this.lblMFPrice.Size = new System.Drawing.Size(52, 17);
            this.lblMFPrice.TabIndex = 12;
            this.lblMFPrice.Text = "Price:  ";
            // 
            // txtMFQuantityOnHand
            // 
            this.txtMFQuantityOnHand.Location = new System.Drawing.Point(317, 146);
            this.txtMFQuantityOnHand.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFQuantityOnHand.Name = "txtMFQuantityOnHand";
            this.txtMFQuantityOnHand.Size = new System.Drawing.Size(220, 22);
            this.txtMFQuantityOnHand.TabIndex = 11;
            // 
            // lblMFQuanityOnHand
            // 
            this.lblMFQuanityOnHand.AutoSize = true;
            this.lblMFQuanityOnHand.Location = new System.Drawing.Point(181, 150);
            this.lblMFQuanityOnHand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFQuanityOnHand.Name = "lblMFQuanityOnHand";
            this.lblMFQuanityOnHand.Size = new System.Drawing.Size(126, 17);
            this.lblMFQuanityOnHand.TabIndex = 10;
            this.lblMFQuanityOnHand.Text = "Quanity On Hand: ";
            // 
            // txtMFColor
            // 
            this.txtMFColor.Location = new System.Drawing.Point(317, 117);
            this.txtMFColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFColor.Name = "txtMFColor";
            this.txtMFColor.Size = new System.Drawing.Size(220, 22);
            this.txtMFColor.TabIndex = 9;
            // 
            // lblMFColor
            // 
            this.lblMFColor.AutoSize = true;
            this.lblMFColor.Location = new System.Drawing.Point(181, 121);
            this.lblMFColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFColor.Name = "lblMFColor";
            this.lblMFColor.Size = new System.Drawing.Size(49, 17);
            this.lblMFColor.TabIndex = 8;
            this.lblMFColor.Text = "Color: ";
            // 
            // txtMFSupplier
            // 
            this.txtMFSupplier.Location = new System.Drawing.Point(317, 85);
            this.txtMFSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFSupplier.Name = "txtMFSupplier";
            this.txtMFSupplier.Size = new System.Drawing.Size(220, 22);
            this.txtMFSupplier.TabIndex = 7;
            // 
            // lblMFSupplier
            // 
            this.lblMFSupplier.AutoSize = true;
            this.lblMFSupplier.Location = new System.Drawing.Point(181, 89);
            this.lblMFSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFSupplier.Name = "lblMFSupplier";
            this.lblMFSupplier.Size = new System.Drawing.Size(68, 17);
            this.lblMFSupplier.TabIndex = 6;
            this.lblMFSupplier.Text = "Supplier: ";
            // 
            // txtMFName
            // 
            this.txtMFName.Location = new System.Drawing.Point(317, 53);
            this.txtMFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFName.Name = "txtMFName";
            this.txtMFName.Size = new System.Drawing.Size(220, 22);
            this.txtMFName.TabIndex = 5;
            // 
            // lblMFName
            // 
            this.lblMFName.AutoSize = true;
            this.lblMFName.Location = new System.Drawing.Point(181, 57);
            this.lblMFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFName.Name = "lblMFName";
            this.lblMFName.Size = new System.Drawing.Size(53, 17);
            this.lblMFName.TabIndex = 4;
            this.lblMFName.Text = "Name: ";
            // 
            // txtMFId
            // 
            this.txtMFId.Enabled = false;
            this.txtMFId.Location = new System.Drawing.Point(317, 22);
            this.txtMFId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMFId.Name = "txtMFId";
            this.txtMFId.Size = new System.Drawing.Size(220, 22);
            this.txtMFId.TabIndex = 3;
            // 
            // lblMFId
            // 
            this.lblMFId.AutoSize = true;
            this.lblMFId.Location = new System.Drawing.Point(181, 26);
            this.lblMFId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFId.Name = "lblMFId";
            this.lblMFId.Size = new System.Drawing.Size(25, 17);
            this.lblMFId.TabIndex = 2;
            this.lblMFId.Text = "ID:";
            // 
            // lstMFindings
            // 
            this.lstMFindings.FormattingEnabled = true;
            this.lstMFindings.ItemHeight = 16;
            this.lstMFindings.Location = new System.Drawing.Point(5, 26);
            this.lstMFindings.Margin = new System.Windows.Forms.Padding(4);
            this.lstMFindings.Name = "lstMFindings";
            this.lstMFindings.ScrollAlwaysVisible = true;
            this.lstMFindings.Size = new System.Drawing.Size(167, 484);
            this.lstMFindings.TabIndex = 1;
            // 
            // lblMFindings
            // 
            this.lblMFindings.AutoSize = true;
            this.lblMFindings.Location = new System.Drawing.Point(4, 6);
            this.lblMFindings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMFindings.Name = "lblMFindings";
            this.lblMFindings.Size = new System.Drawing.Size(61, 17);
            this.lblMFindings.TabIndex = 0;
            this.lblMFindings.Text = "Findings";
            // 
            // pnlMOrder
            // 
            this.pnlMOrder.Controls.Add(this.grpMONotes);
            this.pnlMOrder.Controls.Add(this.lblMODate);
            this.pnlMOrder.Controls.Add(this.dtpMODate);
            this.pnlMOrder.Controls.Add(this.btnMOUpdate);
            this.pnlMOrder.Controls.Add(this.btnMOSave);
            this.pnlMOrder.Controls.Add(this.btnMODelete);
            this.pnlMOrder.Controls.Add(this.btnMOClear);
            this.pnlMOrder.Controls.Add(this.txtMOType);
            this.pnlMOrder.Controls.Add(this.lblMOType);
            this.pnlMOrder.Controls.Add(this.cmbMOOrderStatus);
            this.pnlMOrder.Controls.Add(this.lblMOOrderStatus);
            this.pnlMOrder.Controls.Add(this.cmbMOCompanyContact);
            this.pnlMOrder.Controls.Add(this.cmbMOCompany);
            this.pnlMOrder.Controls.Add(this.label1);
            this.pnlMOrder.Controls.Add(this.lblMOCompanyContact);
            this.pnlMOrder.Controls.Add(this.lblMOCompany);
            this.pnlMOrder.Controls.Add(this.lstMOOrders);
            this.pnlMOrder.Controls.Add(this.lblMOOrder);
            this.pnlMOrder.Location = new System.Drawing.Point(0, 33);
            this.pnlMOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMOrder.Name = "pnlMOrder";
            this.pnlMOrder.Size = new System.Drawing.Size(843, 522);
            this.pnlMOrder.TabIndex = 20;
            this.pnlMOrder.Visible = false;
            // 
            // grpMONotes
            // 
            this.grpMONotes.Controls.Add(this.txtMONotes);
            this.grpMONotes.Location = new System.Drawing.Point(173, 185);
            this.grpMONotes.Margin = new System.Windows.Forms.Padding(4);
            this.grpMONotes.Name = "grpMONotes";
            this.grpMONotes.Padding = new System.Windows.Forms.Padding(4);
            this.grpMONotes.Size = new System.Drawing.Size(665, 290);
            this.grpMONotes.TabIndex = 19;
            this.grpMONotes.TabStop = false;
            this.grpMONotes.Text = "Notes";
            // 
            // txtMONotes
            // 
            this.txtMONotes.Location = new System.Drawing.Point(9, 18);
            this.txtMONotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtMONotes.MaxLength = 1024;
            this.txtMONotes.Multiline = true;
            this.txtMONotes.Name = "txtMONotes";
            this.txtMONotes.Size = new System.Drawing.Size(647, 264);
            this.txtMONotes.TabIndex = 0;
            // 
            // lblMODate
            // 
            this.lblMODate.AutoSize = true;
            this.lblMODate.Location = new System.Drawing.Point(173, 160);
            this.lblMODate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMODate.Name = "lblMODate";
            this.lblMODate.Size = new System.Drawing.Size(46, 17);
            this.lblMODate.TabIndex = 18;
            this.lblMODate.Text = "Date: ";
            // 
            // dtpMODate
            // 
            this.dtpMODate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMODate.Location = new System.Drawing.Point(316, 153);
            this.dtpMODate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMODate.MaxDate = new System.DateTime(2115, 2, 18, 0, 0, 0, 0);
            this.dtpMODate.MinDate = new System.DateTime(2015, 2, 18, 0, 0, 0, 0);
            this.dtpMODate.Name = "dtpMODate";
            this.dtpMODate.Size = new System.Drawing.Size(521, 22);
            this.dtpMODate.TabIndex = 17;
            this.dtpMODate.Value = new System.DateTime(2015, 2, 18, 0, 55, 5, 0);
            // 
            // btnMOUpdate
            // 
            this.btnMOUpdate.Location = new System.Drawing.Point(415, 482);
            this.btnMOUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMOUpdate.Name = "btnMOUpdate";
            this.btnMOUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnMOUpdate.TabIndex = 16;
            this.btnMOUpdate.Text = "Update";
            this.btnMOUpdate.UseVisualStyleBackColor = true;
            this.btnMOUpdate.Click += new System.EventHandler(this.btnMOUpdate_Click);
            // 
            // btnMOSave
            // 
            this.btnMOSave.Enabled = false;
            this.btnMOSave.Location = new System.Drawing.Point(523, 482);
            this.btnMOSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnMOSave.Name = "btnMOSave";
            this.btnMOSave.Size = new System.Drawing.Size(100, 28);
            this.btnMOSave.TabIndex = 15;
            this.btnMOSave.Text = "Save";
            this.btnMOSave.UseVisualStyleBackColor = true;
            // 
            // btnMODelete
            // 
            this.btnMODelete.Enabled = false;
            this.btnMODelete.Location = new System.Drawing.Point(631, 482);
            this.btnMODelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMODelete.Name = "btnMODelete";
            this.btnMODelete.Size = new System.Drawing.Size(100, 28);
            this.btnMODelete.TabIndex = 14;
            this.btnMODelete.Text = "Delete";
            this.btnMODelete.UseVisualStyleBackColor = true;
            // 
            // btnMOClear
            // 
            this.btnMOClear.Location = new System.Drawing.Point(739, 482);
            this.btnMOClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnMOClear.Name = "btnMOClear";
            this.btnMOClear.Size = new System.Drawing.Size(100, 28);
            this.btnMOClear.TabIndex = 13;
            this.btnMOClear.Text = "Clear";
            this.btnMOClear.UseVisualStyleBackColor = true;
            this.btnMOClear.Click += new System.EventHandler(this.btnMOClear_Click);
            // 
            // txtMOType
            // 
            this.txtMOType.Location = new System.Drawing.Point(317, 121);
            this.txtMOType.Margin = new System.Windows.Forms.Padding(4);
            this.txtMOType.Name = "txtMOType";
            this.txtMOType.Size = new System.Drawing.Size(520, 22);
            this.txtMOType.TabIndex = 12;
            // 
            // lblMOType
            // 
            this.lblMOType.AutoSize = true;
            this.lblMOType.Location = new System.Drawing.Point(173, 124);
            this.lblMOType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMOType.Name = "lblMOType";
            this.lblMOType.Size = new System.Drawing.Size(52, 17);
            this.lblMOType.TabIndex = 11;
            this.lblMOType.Text = "Type:  ";
            // 
            // cmbMOOrderStatus
            // 
            this.cmbMOOrderStatus.FormattingEnabled = true;
            this.cmbMOOrderStatus.Location = new System.Drawing.Point(317, 89);
            this.cmbMOOrderStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMOOrderStatus.Name = "cmbMOOrderStatus";
            this.cmbMOOrderStatus.Size = new System.Drawing.Size(520, 24);
            this.cmbMOOrderStatus.TabIndex = 10;
            // 
            // lblMOOrderStatus
            // 
            this.lblMOOrderStatus.AutoSize = true;
            this.lblMOOrderStatus.Location = new System.Drawing.Point(173, 92);
            this.lblMOOrderStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMOOrderStatus.Name = "lblMOOrderStatus";
            this.lblMOOrderStatus.Size = new System.Drawing.Size(101, 17);
            this.lblMOOrderStatus.TabIndex = 9;
            this.lblMOOrderStatus.Text = "Order Status:  ";
            // 
            // cmbMOCompanyContact
            // 
            this.cmbMOCompanyContact.Enabled = false;
            this.cmbMOCompanyContact.FormattingEnabled = true;
            this.cmbMOCompanyContact.Location = new System.Drawing.Point(317, 57);
            this.cmbMOCompanyContact.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMOCompanyContact.Name = "cmbMOCompanyContact";
            this.cmbMOCompanyContact.Size = new System.Drawing.Size(520, 24);
            this.cmbMOCompanyContact.TabIndex = 8;
            // 
            // cmbMOCompany
            // 
            this.cmbMOCompany.Enabled = false;
            this.cmbMOCompany.FormattingEnabled = true;
            this.cmbMOCompany.Location = new System.Drawing.Point(317, 23);
            this.cmbMOCompany.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMOCompany.Name = "cmbMOCompany";
            this.cmbMOCompany.Size = new System.Drawing.Size(520, 24);
            this.cmbMOCompany.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // lblMOCompanyContact
            // 
            this.lblMOCompanyContact.AutoSize = true;
            this.lblMOCompanyContact.Location = new System.Drawing.Point(173, 60);
            this.lblMOCompanyContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMOCompanyContact.Name = "lblMOCompanyContact";
            this.lblMOCompanyContact.Size = new System.Drawing.Size(127, 17);
            this.lblMOCompanyContact.TabIndex = 4;
            this.lblMOCompanyContact.Text = "Company Contact: ";
            // 
            // lblMOCompany
            // 
            this.lblMOCompany.AutoSize = true;
            this.lblMOCompany.Location = new System.Drawing.Point(173, 27);
            this.lblMOCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMOCompany.Name = "lblMOCompany";
            this.lblMOCompany.Size = new System.Drawing.Size(75, 17);
            this.lblMOCompany.TabIndex = 2;
            this.lblMOCompany.Text = "Company: ";
            // 
            // lstMOOrders
            // 
            this.lstMOOrders.FormattingEnabled = true;
            this.lstMOOrders.ItemHeight = 16;
            this.lstMOOrders.Location = new System.Drawing.Point(5, 27);
            this.lstMOOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lstMOOrders.Name = "lstMOOrders";
            this.lstMOOrders.ScrollAlwaysVisible = true;
            this.lstMOOrders.Size = new System.Drawing.Size(159, 484);
            this.lstMOOrders.TabIndex = 1;
            this.lstMOOrders.SelectedIndexChanged += new System.EventHandler(this.lstMOOrders_SelectedIndexChanged);
            // 
            // lblMOOrder
            // 
            this.lblMOOrder.AutoSize = true;
            this.lblMOOrder.Location = new System.Drawing.Point(4, 6);
            this.lblMOOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMOOrder.Name = "lblMOOrder";
            this.lblMOOrder.Size = new System.Drawing.Size(45, 17);
            this.lblMOOrder.TabIndex = 0;
            this.lblMOOrder.Text = "Order";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlMOrder);
            this.Controls.Add(this.pnlMFindings);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "UnderGuard";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlMFindings.ResumeLayout(false);
            this.pnlMFindings.PerformLayout();
            this.grpMFDescription.ResumeLayout(false);
            this.grpMFDescription.PerformLayout();
            this.grpMFSLA.ResumeLayout(false);
            this.grpMFSLA.PerformLayout();
            this.pnlMOrder.ResumeLayout(false);
            this.pnlMOrder.PerformLayout();
            this.grpMONotes.ResumeLayout(false);
            this.grpMONotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findingsToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlMFindings;
        private System.Windows.Forms.ListBox lstMFindings;
        private System.Windows.Forms.Label lblMFindings;
        private System.Windows.Forms.Label lblMFName;
        private System.Windows.Forms.TextBox txtMFId;
        private System.Windows.Forms.Label lblMFId;
        private System.Windows.Forms.TextBox txtMFName;
        private System.Windows.Forms.TextBox txtMFSupplier;
        private System.Windows.Forms.Label lblMFSupplier;
        private System.Windows.Forms.Button btnMFClear;
        private System.Windows.Forms.TextBox txtMFPrice;
        private System.Windows.Forms.Label lblMFPrice;
        private System.Windows.Forms.TextBox txtMFQuantityOnHand;
        private System.Windows.Forms.Label lblMFQuanityOnHand;
        private System.Windows.Forms.TextBox txtMFColor;
        private System.Windows.Forms.Label lblMFColor;
        private System.Windows.Forms.Button btnMFDelete;
        private System.Windows.Forms.GroupBox grpMFDescription;
        private System.Windows.Forms.TextBox txtMFDescription;
        private System.Windows.Forms.GroupBox grpMFSLA;
        private System.Windows.Forms.TextBox txtMFSLA;
        private System.Windows.Forms.Button btnMFUpdate;
        private System.Windows.Forms.Button btnMFSave;
        private System.Windows.Forms.Panel pnlMOrder;
        private System.Windows.Forms.Label lblMOOrder;
        private System.Windows.Forms.ListBox lstMOOrders;
        private System.Windows.Forms.Label lblMOCompany;
        private System.Windows.Forms.Label lblMOCompanyContact;
        private System.Windows.Forms.ComboBox cmbMOCompanyContact;
        private System.Windows.Forms.ComboBox cmbMOCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMOType;
        private System.Windows.Forms.Label lblMOType;
        private System.Windows.Forms.ComboBox cmbMOOrderStatus;
        private System.Windows.Forms.Label lblMOOrderStatus;
        private System.Windows.Forms.Label lblMODate;
        private System.Windows.Forms.DateTimePicker dtpMODate;
        private System.Windows.Forms.Button btnMOUpdate;
        private System.Windows.Forms.Button btnMOSave;
        private System.Windows.Forms.Button btnMODelete;
        private System.Windows.Forms.Button btnMOClear;
        private System.Windows.Forms.GroupBox grpMONotes;
        private System.Windows.Forms.TextBox txtMONotes;
    }
}




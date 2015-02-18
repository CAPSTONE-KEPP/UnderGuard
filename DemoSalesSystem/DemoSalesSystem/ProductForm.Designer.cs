namespace DemoSalesSystem
{
    partial class ProductForm
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
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.tbxColour = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.Location = new System.Drawing.Point(13, 13);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(120, 290);
            this.lbxProducts.TabIndex = 0;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(174, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(149, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(178, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price: ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(182, 175);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size: ";
            // 
            // pbxPicture
            // 
            this.pbxPicture.Location = new System.Drawing.Point(412, 13);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(149, 138);
            this.pbxPicture.TabIndex = 5;
            this.pbxPicture.TabStop = false;
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(172, 211);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(43, 13);
            this.lblColour.TabIndex = 6;
            this.lblColour.Text = "Colour: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(172, 243);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status: ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(253, 5);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 8;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(253, 43);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(121, 69);
            this.tbxDescription.TabIndex = 9;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(253, 130);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 10;
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(253, 167);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(100, 20);
            this.tbxSize.TabIndex = 11;
            // 
            // tbxColour
            // 
            this.tbxColour.Location = new System.Drawing.Point(253, 203);
            this.tbxColour.Name = "tbxColour";
            this.tbxColour.Size = new System.Drawing.Size(100, 20);
            this.tbxColour.TabIndex = 12;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(253, 234);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 13;
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(412, 165);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(75, 23);
            this.btnAddPic.TabIndex = 14;
            this.btnAddPic.Text = "Add Picture";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(269, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBom
            // 
            this.btnBom.Location = new System.Drawing.Point(486, 280);
            this.btnBom.Name = "btnBom";
            this.btnBom.Size = new System.Drawing.Size(75, 23);
            this.btnBom.TabIndex = 18;
            this.btnBom.Text = "Add BOM";
            this.btnBom.UseVisualStyleBackColor = true;
            this.btnBom.Click += new System.EventHandler(this.btnBom_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 331);
            this.Controls.Add(this.btnBom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.tbxColour);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblColour);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbxProducts);
            this.Name = "ProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.TextBox tbxColour;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBom;
    }
}
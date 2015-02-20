namespace DemoSalesSystem
{
    partial class FindingUpdateForm
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
            this.btnUpdateFinding = new System.Windows.Forms.Button();
            this.gbxFindings = new System.Windows.Forms.GroupBox();
            this.lblFindings = new System.Windows.Forms.Label();
            this.lsvFindings = new System.Windows.Forms.ListView();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.gbxFindings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 43);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 86);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(35, 167);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(35, 124);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(35, 262);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(126, 17);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity On Hand:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(35, 219);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // txtFindingID
            // 
            this.txtFindingID.Enabled = false;
            this.txtFindingID.Location = new System.Drawing.Point(124, 43);
            this.txtFindingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindingID.Name = "txtFindingID";
            this.txtFindingID.Size = new System.Drawing.Size(72, 22);
            this.txtFindingID.TabIndex = 6;
            // 
            // txtFindingName
            // 
            this.txtFindingName.Enabled = false;
            this.txtFindingName.Location = new System.Drawing.Point(124, 82);
            this.txtFindingName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindingName.Name = "txtFindingName";
            this.txtFindingName.Size = new System.Drawing.Size(132, 22);
            this.txtFindingName.TabIndex = 7;
            // 
            // txtFindingDescription
            // 
            this.txtFindingDescription.Enabled = false;
            this.txtFindingDescription.Location = new System.Drawing.Point(124, 124);
            this.txtFindingDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindingDescription.Name = "txtFindingDescription";
            this.txtFindingDescription.Size = new System.Drawing.Size(317, 22);
            this.txtFindingDescription.TabIndex = 8;
            // 
            // txtFindingPrice
            // 
            this.txtFindingPrice.Enabled = false;
            this.txtFindingPrice.Location = new System.Drawing.Point(124, 167);
            this.txtFindingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindingPrice.Name = "txtFindingPrice";
            this.txtFindingPrice.Size = new System.Drawing.Size(132, 22);
            this.txtFindingPrice.TabIndex = 9;
            // 
            // txtFindingColor
            // 
            this.txtFindingColor.Enabled = false;
            this.txtFindingColor.Location = new System.Drawing.Point(124, 219);
            this.txtFindingColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindingColor.Name = "txtFindingColor";
            this.txtFindingColor.Size = new System.Drawing.Size(132, 22);
            this.txtFindingColor.TabIndex = 10;
            // 
            // txtFindingQuantity
            // 
            this.txtFindingQuantity.Location = new System.Drawing.Point(169, 258);
            this.txtFindingQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtFindingQuantity.Name = "txtFindingQuantity";
            this.txtFindingQuantity.Size = new System.Drawing.Size(87, 22);
            this.txtFindingQuantity.TabIndex = 11;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(279, 43);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(64, 17);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = "Supplier:";
            // 
            // btnUpdateFinding
            // 
            this.btnUpdateFinding.Location = new System.Drawing.Point(688, 300);
            this.btnUpdateFinding.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFinding.Name = "btnUpdateFinding";
            this.btnUpdateFinding.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateFinding.TabIndex = 26;
            this.btnUpdateFinding.Text = "Update";
            this.btnUpdateFinding.UseVisualStyleBackColor = true;
            this.btnUpdateFinding.Click += new System.EventHandler(this.btnUpdateFinding_Click);
            // 
            // gbxFindings
            // 
            this.gbxFindings.Controls.Add(this.txtSupplier);
            this.gbxFindings.Controls.Add(this.lblFindings);
            this.gbxFindings.Controls.Add(this.lsvFindings);
            this.gbxFindings.Controls.Add(this.lblID);
            this.gbxFindings.Controls.Add(this.btnUpdateFinding);
            this.gbxFindings.Controls.Add(this.lblName);
            this.gbxFindings.Controls.Add(this.lblDescription);
            this.gbxFindings.Controls.Add(this.lblPrice);
            this.gbxFindings.Controls.Add(this.lblColor);
            this.gbxFindings.Controls.Add(this.lblQuantity);
            this.gbxFindings.Controls.Add(this.txtFindingID);
            this.gbxFindings.Controls.Add(this.txtFindingName);
            this.gbxFindings.Controls.Add(this.txtFindingDescription);
            this.gbxFindings.Controls.Add(this.txtFindingPrice);
            this.gbxFindings.Controls.Add(this.txtFindingColor);
            this.gbxFindings.Controls.Add(this.txtFindingQuantity);
            this.gbxFindings.Controls.Add(this.lblSupplier);
            this.gbxFindings.Location = new System.Drawing.Point(16, 15);
            this.gbxFindings.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFindings.Name = "gbxFindings";
            this.gbxFindings.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFindings.Size = new System.Drawing.Size(935, 364);
            this.gbxFindings.TabIndex = 28;
            this.gbxFindings.TabStop = false;
            this.gbxFindings.Text = "Findings";
            // 
            // lblFindings
            // 
            this.lblFindings.AutoSize = true;
            this.lblFindings.Location = new System.Drawing.Point(592, 14);
            this.lblFindings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFindings.Name = "lblFindings";
            this.lblFindings.Size = new System.Drawing.Size(65, 17);
            this.lblFindings.TabIndex = 30;
            this.lblFindings.Text = "Findings:";
            // 
            // lsvFindings
            // 
            this.lsvFindings.Location = new System.Drawing.Point(596, 33);
            this.lsvFindings.Margin = new System.Windows.Forms.Padding(4);
            this.lsvFindings.Name = "lsvFindings";
            this.lsvFindings.Size = new System.Drawing.Size(300, 244);
            this.lsvFindings.TabIndex = 28;
            this.lsvFindings.UseCompatibleStateImageBehavior = false;
            this.lsvFindings.SelectedIndexChanged += new System.EventHandler(this.lsvFindings_SelectedIndexChanged);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Location = new System.Drawing.Point(351, 43);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(169, 22);
            this.txtSupplier.TabIndex = 31;
            // 
            // FindingUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 394);
            this.Controls.Add(this.gbxFindings);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindingUpdateForm";
            this.Text = "FindingForm";
            this.gbxFindings.ResumeLayout(false);
            this.gbxFindings.PerformLayout();
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
        private System.Windows.Forms.Button btnUpdateFinding;
        private System.Windows.Forms.GroupBox gbxFindings;
        private System.Windows.Forms.ListView lsvFindings;
        private System.Windows.Forms.Label lblFindings;
        private System.Windows.Forms.TextBox txtSupplier;
    }
}
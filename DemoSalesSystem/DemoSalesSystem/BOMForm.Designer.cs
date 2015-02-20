namespace DemoSalesSystem
{
    partial class BOMForm
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
            this.lbxFindings = new System.Windows.Forms.ListBox();
            this.lblFindings = new System.Windows.Forms.Label();
            this.cbxFindings = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductionTime = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.btnAddFinding = new System.Windows.Forms.Button();
            this.btnAddBOM = new System.Windows.Forms.Button();
            this.btnDeleteBOM = new System.Windows.Forms.Button();
            this.btnRemoveFinding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxFindings
            // 
            this.lbxFindings.FormattingEnabled = true;
            this.lbxFindings.Location = new System.Drawing.Point(13, 13);
            this.lbxFindings.Name = "lbxFindings";
            this.lbxFindings.Size = new System.Drawing.Size(120, 277);
            this.lbxFindings.TabIndex = 0;
            this.lbxFindings.SelectedIndexChanged += new System.EventHandler(this.lbxFindings_SelectedIndexChanged);
            // 
            // lblFindings
            // 
            this.lblFindings.AutoSize = true;
            this.lblFindings.Location = new System.Drawing.Point(137, 15);
            this.lblFindings.Name = "lblFindings";
            this.lblFindings.Size = new System.Drawing.Size(47, 13);
            this.lblFindings.TabIndex = 1;
            this.lblFindings.Text = "Finding: ";
            // 
            // cbxFindings
            // 
            this.cbxFindings.FormattingEnabled = true;
            this.cbxFindings.Location = new System.Drawing.Point(208, 12);
            this.cbxFindings.Name = "cbxFindings";
            this.cbxFindings.Size = new System.Drawing.Size(121, 21);
            this.cbxFindings.TabIndex = 2;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(209, 44);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(137, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity: ";
            // 
            // lblProductionTime
            // 
            this.lblProductionTime.AutoSize = true;
            this.lblProductionTime.Location = new System.Drawing.Point(137, 127);
            this.lblProductionTime.Name = "lblProductionTime";
            this.lblProductionTime.Size = new System.Drawing.Size(136, 13);
            this.lblProductionTime.TabIndex = 5;
            this.lblProductionTime.Text = "Production Time(In Hours): ";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(305, 120);
            this.nudHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(33, 20);
            this.nudHours.TabIndex = 9;
            // 
            // btnAddFinding
            // 
            this.btnAddFinding.Location = new System.Drawing.Point(139, 78);
            this.btnAddFinding.Name = "btnAddFinding";
            this.btnAddFinding.Size = new System.Drawing.Size(75, 23);
            this.btnAddFinding.TabIndex = 10;
            this.btnAddFinding.Text = "Add Finding";
            this.btnAddFinding.UseVisualStyleBackColor = true;
            this.btnAddFinding.Click += new System.EventHandler(this.btnAddFinding_Click);
            // 
            // btnAddBOM
            // 
            this.btnAddBOM.Location = new System.Drawing.Point(140, 169);
            this.btnAddBOM.Name = "btnAddBOM";
            this.btnAddBOM.Size = new System.Drawing.Size(93, 38);
            this.btnAddBOM.TabIndex = 11;
            this.btnAddBOM.Text = "Add or update BOM";
            this.btnAddBOM.UseVisualStyleBackColor = true;
            this.btnAddBOM.Click += new System.EventHandler(this.btnAddBOM_Click);
            // 
            // btnDeleteBOM
            // 
            this.btnDeleteBOM.Location = new System.Drawing.Point(239, 169);
            this.btnDeleteBOM.Name = "btnDeleteBOM";
            this.btnDeleteBOM.Size = new System.Drawing.Size(90, 38);
            this.btnDeleteBOM.TabIndex = 12;
            this.btnDeleteBOM.Text = "Delete BOM";
            this.btnDeleteBOM.UseVisualStyleBackColor = true;
            this.btnDeleteBOM.Click += new System.EventHandler(this.btnDeleteBOM_Click);
            // 
            // btnRemoveFinding
            // 
            this.btnRemoveFinding.Location = new System.Drawing.Point(221, 78);
            this.btnRemoveFinding.Name = "btnRemoveFinding";
            this.btnRemoveFinding.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveFinding.TabIndex = 13;
            this.btnRemoveFinding.Text = "Remove Finding";
            this.btnRemoveFinding.UseVisualStyleBackColor = true;
            this.btnRemoveFinding.Click += new System.EventHandler(this.btnRemoveFinding_Click);
            // 
            // BOMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 302);
            this.Controls.Add(this.btnRemoveFinding);
            this.Controls.Add(this.btnDeleteBOM);
            this.Controls.Add(this.btnAddBOM);
            this.Controls.Add(this.btnAddFinding);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.lblProductionTime);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbxFindings);
            this.Controls.Add(this.lblFindings);
            this.Controls.Add(this.lbxFindings);
            this.Name = "BOMForm";
            this.Text = "BOMForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFindings;
        private System.Windows.Forms.Label lblFindings;
        private System.Windows.Forms.ComboBox cbxFindings;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductionTime;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Button btnAddFinding;
        private System.Windows.Forms.Button btnAddBOM;
        private System.Windows.Forms.Button btnDeleteBOM;
        private System.Windows.Forms.Button btnRemoveFinding;
    }
}
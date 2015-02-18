namespace SalesDesktopApp
{
    partial class Form1
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
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tbgInfo = new System.Windows.Forms.TabPage();
            this.tpgOrder = new System.Windows.Forms.TabPage();
            this.tpgProductInfo = new System.Windows.Forms.TabPage();
            this.tpgCatalog = new System.Windows.Forms.TabPage();
            this.tclMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclMain
            // 
            this.tclMain.Controls.Add(this.tbgInfo);
            this.tclMain.Controls.Add(this.tpgOrder);
            this.tclMain.Controls.Add(this.tpgProductInfo);
            this.tclMain.Controls.Add(this.tpgCatalog);
            this.tclMain.Location = new System.Drawing.Point(2, 2);
            this.tclMain.Name = "tclMain";
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(497, 267);
            this.tclMain.TabIndex = 0;
            // 
            // tbgInfo
            // 
            this.tbgInfo.Location = new System.Drawing.Point(4, 22);
            this.tbgInfo.Name = "tbgInfo";
            this.tbgInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbgInfo.Size = new System.Drawing.Size(489, 241);
            this.tbgInfo.TabIndex = 0;
            this.tbgInfo.Text = "Info";
            this.tbgInfo.UseVisualStyleBackColor = true;
            this.tbgInfo.Click += new System.EventHandler(this.tbgInfo_Click);
            // 
            // tpgOrder
            // 
            this.tpgOrder.Location = new System.Drawing.Point(4, 22);
            this.tpgOrder.Name = "tpgOrder";
            this.tpgOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tpgOrder.Size = new System.Drawing.Size(489, 241);
            this.tpgOrder.TabIndex = 1;
            this.tpgOrder.Text = "Order";
            this.tpgOrder.UseVisualStyleBackColor = true;
            // 
            // tpgProductInfo
            // 
            this.tpgProductInfo.Location = new System.Drawing.Point(4, 22);
            this.tpgProductInfo.Name = "tpgProductInfo";
            this.tpgProductInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProductInfo.Size = new System.Drawing.Size(489, 241);
            this.tpgProductInfo.TabIndex = 2;
            this.tpgProductInfo.Text = "Product Info";
            this.tpgProductInfo.UseVisualStyleBackColor = true;
            this.tpgProductInfo.Click += new System.EventHandler(this.tpgProductInfo_Click);
            // 
            // tpgCatalog
            // 
            this.tpgCatalog.Location = new System.Drawing.Point(4, 22);
            this.tpgCatalog.Name = "tpgCatalog";
            this.tpgCatalog.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCatalog.Size = new System.Drawing.Size(489, 241);
            this.tpgCatalog.TabIndex = 3;
            this.tpgCatalog.Text = "Catalog";
            this.tpgCatalog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 281);
            this.Controls.Add(this.tclMain);
            this.Name = "Form1";
            this.Text = "Index";
            this.tclMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tbgInfo;
        private System.Windows.Forms.TabPage tpgOrder;
        private System.Windows.Forms.TabPage tpgProductInfo;
        private System.Windows.Forms.TabPage tpgCatalog;

    }
}


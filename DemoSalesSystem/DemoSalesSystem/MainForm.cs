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
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        ProductForm productForm;

        public MainForm()
        {
            InitializeComponent();

            productForm = new ProductForm(this);
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            productForm.MdiParent = this;
            productForm.WindowState = FormWindowState.Maximized;
            productForm.Show();
        }
        
    }
}

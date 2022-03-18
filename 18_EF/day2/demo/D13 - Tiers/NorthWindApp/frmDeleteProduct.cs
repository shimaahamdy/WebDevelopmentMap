using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindApp
{
    public partial class frmDeleteProduct : Form
    {
        public frmDeleteProduct()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ( int.TryParse (txtProductID.Text, out int productID ) )
                this.Text= ProductManager.DeleteProductByID ( productID ).ToString();
        }
    }
}

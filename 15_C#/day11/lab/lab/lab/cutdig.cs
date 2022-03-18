using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class frmCutDig : Form
    {
        public frmCutDig()
        {
            InitializeComponent();
            
        }
        public string TextBox {
        get { return this.RText.Text; }
            //set { this.RText.Text = value;}
        }

        private void RText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCutDigOK_Click(object sender, EventArgs e)
        {
           
        }
    }
}

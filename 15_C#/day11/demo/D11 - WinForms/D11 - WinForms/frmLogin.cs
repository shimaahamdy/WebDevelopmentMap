using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D11___WinForms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.btnClose.Click += (sender, e) => Application.Exit();

            this.FormClosing += FrmLogin_FormClosing;

        
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( 
            MessageBox.Show("Are You Sure You Want To Exit (Y|N) ? ",
                "Warning",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) 
                 == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        frmWelcomeScreen frm = new frmWelcomeScreen();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // if ((txtUserName.Text == "ABC") && (txtPassword.Text == "123"))

            {
                this.Hide();

                frm.ShowDialog();

                this.Visible = true;
            }
        }
    }
}

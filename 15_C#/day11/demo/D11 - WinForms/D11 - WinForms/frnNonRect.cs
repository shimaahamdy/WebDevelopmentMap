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
    public partial class frnNonRect : Form
    {
        public frnNonRect()
        {
            InitializeComponent();
        }

        private void frnNonRect_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}

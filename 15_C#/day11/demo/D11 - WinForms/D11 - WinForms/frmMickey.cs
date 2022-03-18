using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace D11___WinForms
{
    public partial class frmMickey : Form
    {
        public frmMickey()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0 , this.ClientSize.Width, this.ClientSize.Height);
            path.AddRectangle(new Rectangle(0, 0, 150, 150));

            path.FillMode = FillMode.Winding;



            this.Region = new Region(path);
            base.OnPaint(e);
        }
    }
}

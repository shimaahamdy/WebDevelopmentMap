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
    public partial class frmGDI : Form
    {
        public frmGDI()
        {
            InitializeComponent();

            //this.ResizeRedraw = true;
            //Or
            this.Resize += (sender, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            String Str = "Hello GDI+";
            Font MyFont = new Font(this.Font.FontFamily, 18);

            var TextSize = e.Graphics.MeasureString(Str, MyFont);

            Brush brush = new SolidBrush(Color.FromArgb(this.Width %255, this.Height%255 , (Width + Height)%255));

            e.Graphics.DrawString(Str,// this.Font,
                                                MyFont,brush,
                                                //Brushes.DarkBlue, //100, 100
                                                (this.ClientSize.Width - TextSize.Width) /2,
                                                (this.ClientSize.Height - TextSize.Height) /2);
            foreach (var item in Circles)
            {
                e.Graphics.FillEllipse(Brushes.DarkCyan, item.X - 15, item.Y - 15, 30, 30);
                e.Graphics.DrawEllipse(Pens.Red, item.X - 15, item.Y - 15, 30, 30);
            }


            base.OnPaint(e);
        }

        List<Point> Circles = new();
        private void frmGDI_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics grfx = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                Circles.Add(e.Location);
                grfx.FillEllipse ( Brushes.DarkCyan, e.X - 15, e.Y - 15, 30, 30);
                grfx.DrawEllipse(Pens.Red, e.X - 15, e.Y - 15, 30, 30);
            }
        }
    }
}

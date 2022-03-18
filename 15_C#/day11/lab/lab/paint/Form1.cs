namespace paint
{
    public partial class frmPaint : Form
    {

        Brush brush;
        public frmPaint()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Black);
            this.BackColor = Color.White;
        }

        private void frmPaint_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gfx = this.CreateGraphics();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    gfx.FillEllipse(brush, e.X, e.Y, 5,5 );
                    break;
                case MouseButtons.Right:
                    gfx.FillEllipse(Brushes.White, e.X, e.Y, 5, 5);
                    break;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.dlgColor.ShowDialog() == DialogResult.OK)
                brush = new SolidBrush(dlgColor.Color);
        }

        private void frmPaint_Load(object sender, EventArgs e)
        {

        }
    }
}
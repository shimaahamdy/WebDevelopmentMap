using System.Drawing.Drawing2D;
namespace mickymouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

      
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.ClientSize.Width , this.ClientSize.Width );
            path.AddEllipse(0,0, this.ClientSize.Width / 3, this.ClientSize.Width / 3);
            path.AddEllipse(this.ClientSize.Width-this.ClientSize.Width/3, 0, this.ClientSize.Width/3, this.ClientSize.Width / 3);
            //path.AddEllipse(this.ClientSize.Width - 100, this.ClientSize.Height - 100, 100, 100);
            //path.AddEllipse(this.ClientRectangle.X+87, this.ClientRectangle.Y+ 430, 95, 95);
            //path.AddEllipse(this.ClientRectangle.X+150, this.ClientRectangle.X+ 430, 95, 95);
            //path.AddEllipse(this.ClientSize.Width - 100, 0, 100, 100);
            //path.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            //path.AddEllipse(0, 0, 100, 100);

            path.FillMode = FillMode.Winding;


            this.Region = new Region(path);
            base.OnPaint(e);


           
        }

        private bool mouseDown;
        private Point lastLocation;

        private void mDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void mMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void mUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
           
        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
          
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
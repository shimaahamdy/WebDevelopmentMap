namespace DragDrop
{
    public partial class frmDrgDrop : Form
    {
        Graphics g;
        Rectangle r;
        public frmDrgDrop()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            r = new Rectangle(10, 10, 100, 100);
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Violet, r);
            base.OnPaint(e);
        }

        private bool mouseDown;
        Point lastLocation;
       

        private void mDown(object sender, MouseEventArgs e)
        {
            if ((e.X >= r.X && e.X <= r.Right) && (e.Y >= r.Y && e.Y <= r.Bottom))
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
             

        }

        private void mMove(object sender, MouseEventArgs e)
        {

            
            if (mouseDown) 
            {
                int dx = lastLocation.X - r.X;
                int dy = lastLocation.Y - r.Y;
                int x = e.X;
                int y = e.Y;
                r.Location = new Point(x-dx, y-dy);
                lastLocation = e.Location;
                
               
            }
            Refresh();
           
        }

        private void mUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void frmDrgDrop_Load(object sender, EventArgs e)
        {

        }
    }
}
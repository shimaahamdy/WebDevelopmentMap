namespace D11___WinForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            //btnClose.Text = "Null Ref Exception";

            InitializeComponent();

            //Load += this.frmHome_Load;

            //btnClose.Click += (sender, e) => this.Close();
        }

        ///Child , Subsc. to Base event
        protected override void OnLoad(EventArgs e)
        {
            this.BackColor = Color.Lavender;

            base.OnLoad(e);

            this.ResizeBegin += (sender, e) => this.Opacity = 0.7;

            this.ResizeEnd += FrmHome_ResizeEnd;
        }

        private void FrmHome_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CallBack Method
        //private void frmHome_Load(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.Lavender;

        //}
    }
}
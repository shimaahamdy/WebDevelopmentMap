namespace playingBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, 50, 50, 75, 75);
            e.Graphics.DrawLine(Pens.Black, 90, 130, 90, 300);
            e.Graphics.DrawLine(Pens.Black, 40, 200, 90, 150);
            e.Graphics.DrawLine(Pens.Black, 150, 200, 90, 150);
            e.Graphics.DrawLine(Pens.Black, 40, 350, 90, 300);
            e.Graphics.DrawLine(Pens.Black, 150, 350, 90, 300);


            e.Graphics.DrawEllipse(Pens.Black, 700, 50, 75, 75);
            e.Graphics.DrawLine(Pens.Black, 740, 130, 740, 300);
            e.Graphics.DrawLine(Pens.Black, 690, 200, 740, 150);
            e.Graphics.DrawLine(Pens.Black, 800, 200, 740, 150);
            e.Graphics.DrawLine(Pens.Black, 690, 350, 740, 300);
            e.Graphics.DrawLine(Pens.Black, 800, 350, 740, 300);

            base.OnPaint(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int cordX = 170;
        int stepX = 1;
        bool flage = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics grfx = this.CreateGraphics();
            while(flage)
            {
                while(cordX <600)
                {
                    grfx.FillEllipse(Brushes.Yellow, cordX, 300, 75, 75);
                    cordX += stepX;
                    grfx.FillEllipse(Brushes.White, cordX - stepX, 300, 75, 75);
                }
                while(cordX>180)
                {
                    grfx.FillEllipse(Brushes.Yellow, cordX, 300, 75, 75);
                    cordX -= stepX;
                    grfx.FillEllipse(Brushes.White, cordX + stepX, 300, 75, 75);
                    
                }

            }
            
                 
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            flage = false;
        }
    }
}